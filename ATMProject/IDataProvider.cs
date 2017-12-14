namespace SimpleATM
{
    public interface IDataProvider
    {
        Account QueryAccount(string accountNumber);
    }
}