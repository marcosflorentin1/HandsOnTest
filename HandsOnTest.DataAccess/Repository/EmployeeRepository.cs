using HandsOnTest.DataAccess.Model;
using HandsOnTest.DataAccess.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnTest.DataAccess.Repository
{
    public class EmployeeRepository: BaseRepository, IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await GetAsync<IEnumerable<Employee>>("employees");
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return Task.Run(() => GetAsync<IEnumerable<Employee>>("employees"))
                .Result
                .Where(e => e.Id == employeeId)
                .SingleOrDefault();
        }
    }
}