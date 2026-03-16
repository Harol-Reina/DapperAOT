using System;
using System.Data;

namespace Dapper;

public interface IWrappedDataReader : IDataReader, IDataRecord, IDisposable
{
    IDataReader Reader { get; }
    IDbCommand Command { get; }
}
