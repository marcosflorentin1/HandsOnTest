using HandsOnTest.BusinessLogic.DTOs;
using HandsOnTest.BusinessLogic.Providers;
using HandsOnTest.BusinessLogic.Providers.Cotracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HandsOnTest.WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        private IEmployeeProvider _employeeProvider;

        public EmployeeController()
        {
            _employeeProvider = new EmployeeProvider();
        }

        [EnableCorsAttribute("*", "*", "*")]
        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            return await _employeeProvider.GetEmployees();
        }

        [EnableCorsAttribute("*", "*", "*")]
        public EmployeeDto Get(int id)
        {
            return _employeeProvider.GetEmployeeById(id);
        }
    }
}
