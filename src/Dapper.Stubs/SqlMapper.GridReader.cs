using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Dapper;

public static partial class SqlMapper
{
    public class GridReader : IAsyncDisposable, IDisposable
    {
        private DbDataReader? reader;
        private readonly bool addToCache;
        private readonly Action<object?>? onCompleted;
        private readonly object? state;
        private readonly CancellationToken cancel;
        private int _resultIndexAndConsumedFlag;

        private const int CONSUMED_FLAG = int.MinValue;

        protected int ResultIndex => _resultIndexAndConsumedFlag & 0x7FFFFFFF;

        public bool IsConsumed => (_resultIndexAndConsumedFlag & CONSUMED_FLAG) != 0;

        public IDbCommand? Command { get; set; }

        protected DbDataReader Reader => reader!;

        protected CancellationToken CancellationToken => cancel;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected GridReader(
            IDbCommand command,
            DbDataReader reader,
            Identity? identity,
            Action<object?>? onCompleted = null,
            object? state = null,
            bool addToCache = false,
            CancellationToken cancellationToken = default)
        {
            Command = command;
            this.reader = reader;
            this.onCompleted = onCompleted;
            this.state = state;
            this.addToCache = addToCache;
            cancel = cancellationToken;
        }

        protected int OnBeforeGrid()
        {
            if (reader == null)
            {
                throw new ObjectDisposedException(
                    GetType().FullName,
                    "The reader has been disposed; this can happen after all data has been consumed");
            }
            if (IsConsumed)
            {
                throw new InvalidOperationException(
                    "Query results must be consumed in the correct order, and each result can only be consumed once");
            }
            _resultIndexAndConsumedFlag |= CONSUMED_FLAG;
            return ResultIndex;
        }

        protected void OnAfterGrid(int index)
        {
            if (index == ResultIndex && reader != null)
            {
                if (reader.NextResult())
                {
                    _resultIndexAndConsumedFlag = index + 1;
                    return;
                }
                reader.Dispose();
                reader = null;
                onCompleted?.Invoke(state);
                Dispose();
            }
        }

        protected async Task OnAfterGridAsync(int index)
        {
            if (index == ResultIndex && reader != null)
            {
                if (await reader.NextResultAsync(cancel).ConfigureAwait(false))
                {
                    _resultIndexAndConsumedFlag = index + 1;
                    return;
                }
                await reader.DisposeAsync().ConfigureAwait(false);
                reader = null;
                onCompleted?.Invoke(state);
                Dispose();
            }
        }

        public void Dispose()
        {
            if (reader != null)
            {
                if (!reader.IsClosed)
                {
                    Command?.Cancel();
                }
                reader.Dispose();
                reader = null;
            }
            if (Command != null)
            {
                Command.Dispose();
                Command = null;
            }
            GC.SuppressFinalize(this);
        }

        public async ValueTask DisposeAsync()
        {
            if (reader != null)
            {
                if (!reader.IsClosed)
                {
                    Command?.Cancel();
                }
                await reader.DisposeAsync().ConfigureAwait(false);
                reader = null;
            }
            if (Command != null)
            {
                Command.Dispose();
                Command = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
