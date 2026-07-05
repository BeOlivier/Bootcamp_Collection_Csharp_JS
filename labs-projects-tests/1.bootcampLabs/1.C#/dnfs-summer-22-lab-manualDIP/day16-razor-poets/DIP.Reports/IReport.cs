namespace DIP.Reports
{
    public interface IReport
    {
        string GenerateReport(string[] data);
    }
}