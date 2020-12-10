using HandsOnTest.BusinessLogic.Factory.Contracts;

namespace HandsOnTest.BusinessLogic.Factory
{
    public class MonthlySalaryEmployeeCreator : EmployeeCreator
    {
        public override ISalaryEmployee FactoryMethod()
        {
            return new MonthlySalaryEmployee();
        }
    }
}
