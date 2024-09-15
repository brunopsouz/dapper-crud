using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace OrderManagement.Infrastructure.Factory;

public class SqlFactory(IConfiguration configuration)
{

    public IDbConnection CreateConnection()
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        return new SqlConnection(connectionString);
    
    }

    //public async Task<IEnumerable<T>> LoadData<T, U>(string sql, string parameters, string connectionName = "DefaultConnection") 
    //{
    //    using IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName));
    //    return await connection.QueryAsync<T>(sql, parameters, commandType: CommandType.Text);

    //}
}
