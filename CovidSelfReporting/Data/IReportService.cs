using CovidSelfReporting.Models;

namespace CovidSelfReporting.Data
{
    public interface IReportService
    {
        void AddReport(Report report);
    }
}
