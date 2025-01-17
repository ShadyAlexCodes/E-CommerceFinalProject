
using System.Data;
using Microsoft.Data.SqlClient;

public class DapperContext
{
    private readonly IConfiguration _configuration;
    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public IDbConnection CreateConnection() => new SqlConnection(_configuration.GetConnectionString("conn_FinalOrdersServiceDB_sqlserver"));    
}