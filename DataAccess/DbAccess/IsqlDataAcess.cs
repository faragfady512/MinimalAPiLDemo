using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public interface IsqlDataAcess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedprocedure, U parameters, string connectionId = "Default");
        Task<IEnumerable<T>> SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
        
    }
}
