using HandsOnTest.BusinessLogic.Factory.Contracts;

namespace HandsOnTest.BusinessLogic.Factory
{
    public class MonthlySalaryEmployee : ISalaryEmployee
    {
        public double Calculate(double contractSalary)
        {
            return contractSalary * 12;
        }
    }
}
