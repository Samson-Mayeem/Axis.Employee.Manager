
namespace DataAccessLibrary
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sql, U paramenters, string connectionString);
        Task SaveData<T>(string sql, T paramenters, string connectionString);
    }
}