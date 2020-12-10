using HandsOnTest.BusinessLogic.Factory.Contracts;

namespace HandsOnTest.BusinessLogic.Factory
{
    public class HourlySalaryEmployeeCreator : EmployeeCreator
    {
        public override ISalaryEmployee FactoryMethod()
        {
            return new HourlySalaryEmployee();
        }
    }
}
