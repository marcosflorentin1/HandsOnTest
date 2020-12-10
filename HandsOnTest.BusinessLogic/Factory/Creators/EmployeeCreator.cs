using HandsOnTest.BusinessLogic.Factory.Contracts;

namespace HandsOnTest.BusinessLogic.Factory
{
    public abstract class EmployeeCreator
    {
        public abstract ISalaryEmployee FactoryMethod();

        public double GetAnnualSalary(double contractSalary)
        {
            var employee = FactoryMethod();

            return employee.Calculate(contractSalary);
        }
    }
}
