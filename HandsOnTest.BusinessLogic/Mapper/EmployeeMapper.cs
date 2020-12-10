using HandsOnTest.BusinessLogic.DTOs;
using HandsOnTest.BusinessLogic.Enums;
using HandsOnTest.BusinessLogic.Factory;
using HandsOnTest.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using static HandsOnTest.BusinessLogic.Enums.EmployeeEnum;

namespace HandsOnTest.BusinessLogic.Mapper
{
    public class EmployeeMapper : IMapper
    {
        EmployeeClient _employeeClient;

        public EmployeeMapper()
        {
            _employeeClient = new EmployeeClient();
        }

        public EmployeeDto Map(Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                ContractTypeName = employee.ContractTypeName,
                Name = employee.Name,
                RoleDescription = employee.RoleDescription,
                RoleId = employee.RoleId,
                RoleName = employee.RoleName,
                AnnualSalary = GetAnnualSalary(employee)
            };
        }

        public double GetAnnualSalary(Employee employee)
        {
            if (employee.ContractTypeName == Contracts.HourlySalaryEmployee.ToString())
            {
                return _employeeClient.GetOperation(employee.ContractTypeName).Calculate(employee.HourlySalary);
            }
            else
            {
                return _employeeClient.GetOperation(employee.ContractTypeName).Calculate(employee.MonthlySalary);
            }
        }
    }
}
