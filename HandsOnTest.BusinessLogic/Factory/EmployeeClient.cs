using HandsOnTest.BusinessLogic.Factory.Contracts;
using System.Collections.Generic;

namespace HandsOnTest.BusinessLogic.Factory
{
    public class EmployeeClient: IEmployeeClient
    {
        private Dictionary<string, ISalaryEmployee> _operations = new Dictionary<string, ISalaryEmployee>()
        {
            { "HourlySalaryEmployee", new HourlySalaryEmployee()},
            { "MonthlySalaryEmployee", new MonthlySalaryEmployee()}
        };

        public ISalaryEmployee GetOperation(string contractType)
        {
            return _operations[contractType];
        }
    }
}
