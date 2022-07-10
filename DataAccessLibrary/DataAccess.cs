
using MySql;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class DataAccess : IDataAccess
    {
        public List<T> LoadData<T, U>(string sql, U paramenters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sql, paramenters).ToList();
                return rows;
            }
        }

        public Task SaveData<T>(string sql, T paramenters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, paramenters);
            }
        }
    }
}