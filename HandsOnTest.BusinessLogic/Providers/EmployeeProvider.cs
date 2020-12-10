using HandsOnTest.BusinessLogic.DTOs;
using HandsOnTest.BusinessLogic.Mapper;
using HandsOnTest.BusinessLogic.Providers.Cotracts;
using HandsOnTest.DataAccess.Repository;
using HandsOnTest.DataAccess.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnTest.BusinessLogic.Providers
{
    public class EmployeeProvider: IEmployeeProvider
    {
        private IMapper _employeeMapper;
        private IEmployeeRepository _employeeRepository;

        public EmployeeProvider()
        {
            _employeeMapper = new EmployeeMapper();
            _employeeRepository = new EmployeeRepository();
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            var employees = await _employeeRepository.GetEmployees();

            if (employees != null && employees.Count() > 0)
            {
                return employees.Select(e => _employeeMapper.Map(e));
            }

            return new List<EmployeeDto>();
        }

        public EmployeeDto GetEmployeeById(int employeeId)
        {
            var employee = _employeeRepository.GetEmployeeById(employeeId);

            if (employee != null)
            {
                return _employeeMapper.Map(employee);
            }

            return null;
        }
    }
}
