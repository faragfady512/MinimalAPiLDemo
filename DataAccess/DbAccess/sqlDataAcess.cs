using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Collections.Generic;

namespace DataAccess.DbAccess
{
    public class sqlDataAcess : IsqlDataAcess
    {
        private readonly IConfiguration _config;


        public sqlDataAcess(IConfiguration config)
        {

            this._config = config;

        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string storedprocedure, U parameters, string connectionId = "Default")
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(storedprocedure, parameters, commandType: CommandType.StoredProcedure);

        }


        public async Task<IEnumerable<T>> SaveData<T>(
           string storedProcedure, T parameters, string connectionId = "Default")
        {

            IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
