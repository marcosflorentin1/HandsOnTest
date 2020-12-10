using HandsOnTest.BusinessLogic.Factory.Contracts;

namespace HandsOnTest.BusinessLogic.Factory
{
    public class HourlySalaryEmployee : ISalaryEmployee
    {
        public double Calculate(double contractSalary)
        {
            return 120 * contractSalary * 12;
        }
    }
}
