using HandsOnTest.DataAccess.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOnTest.DataAccess.Repository.Contracts
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();

        Employee GetEmployeeById(int employeeId);
    }
}