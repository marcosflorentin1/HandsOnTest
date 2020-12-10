using HandsOnTest.BusinessLogic.DTOs;
using HandsOnTest.DataAccess.Model;
using System.Collections.Generic;

namespace HandsOnTest.BusinessLogic.Mapper
{
    public interface IMapper
    {
        EmployeeDto Map(Employee employee);
    }
}