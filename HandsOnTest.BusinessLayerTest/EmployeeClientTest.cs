using HandsOnTest.BusinessLogic.Factory;
using HandsOnTest.BusinessLogic.Factory.Contracts;
using NUnit.Framework;
using static HandsOnTest.BusinessLogic.Enums.EmployeeEnum;

namespace HandsOnTest.BusinessLayerTest
{
    [TestFixture]
    public class EmployeeClientTest
    {
        private IEmployeeClient _employeeClient;

        [SetUp]
        public void SetUp()
        {
            _employeeClient = new EmployeeClient();
        }

        [Test]
        public void Should_Calculate_By_Hourly_Salary()
        {
            // Arrange
            var operation = _employeeClient.GetOperation(Contracts.HourlySalaryEmployee.ToString());

            // Act
            var result = operation.Calculate(1000);

            // Assert
            Assert.AreEqual(result, 1440000);
            Assert.AreEqual(operation.GetType().Name, typeof(HourlySalaryEmployee).Name);
        }

        [Test]
        public void Should_Calculate_By_Monthly_Salary()
        {
            // Arrange
            var operation = _employeeClient.GetOperation(Contracts.MonthlySalaryEmployee.ToString());

            // Act
            var result = operation.Calculate(1000);

            // Assert
            Assert.AreEqual(result, 12000);
            Assert.AreEqual(operation.GetType().Name, typeof(MonthlySalaryEmployee).Name);
        }
    }
}
