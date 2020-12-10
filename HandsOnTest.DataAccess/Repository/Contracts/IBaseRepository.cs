using System.Threading.Tasks;

namespace HandsOnTest.DataAccess.Repository.Contracts
{
    public interface IBaseRepository
    {
        Task<T> GetAsync<T>(string target);
    }
}