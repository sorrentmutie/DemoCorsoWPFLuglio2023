namespace DemoCorsoWPF.Data
{
    public class MockDataAccess: IDataAccess
    {
        public string GetData()
        {
            return "Hello from MockDataAccess";
        }
    }
}
