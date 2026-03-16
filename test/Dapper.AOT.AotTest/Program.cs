using System;
using System.Data.Common;
using Dapper;

Console.WriteLine(Queries.Warmup());

[DapperAot]
static class Queries
{
    public static int Warmup() => GetProduct(null!, 42).Id;

    public static Product GetProduct(DbConnection connection, int id)
        => connection.QueryFirst<Product>("select @id as Id, 'native-aot' as Name", new { id });
}

sealed class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}