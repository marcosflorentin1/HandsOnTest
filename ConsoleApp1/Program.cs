using HandsOnTest.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new EmployeeRepository();
            var res = repo.GetEmployees().Result;
        }
    }
}
