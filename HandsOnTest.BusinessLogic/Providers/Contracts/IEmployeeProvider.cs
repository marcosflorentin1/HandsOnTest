using HandsOnTest.BusinessLogic.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOnTest.BusinessLogic.Providers.Cotracts
{
    public interface IEmployeeProvider
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees();

        EmployeeDto GetEmployeeById(int employeeId);
    }
}