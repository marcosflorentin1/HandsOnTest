namespace HandsOnTest.BusinessLogic.Factory.Contracts
{
    public interface IEmployeeClient
    {
        ISalaryEmployee GetOperation(string contractType);
    }
}