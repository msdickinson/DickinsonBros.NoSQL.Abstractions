using System.Threading.Tasks;

namespace DickinsonBros.NoSQLService.Abstractions
{
    public interface INoSQLService
    {
        Task<T> FetchAsync<T>(string id, string key);
        Task InsertAsync<T>(string key, T value);
        Task UpsertAsync<T>(string key, T value);
        Task DeleteAsync(string id, string key);
    }
}
