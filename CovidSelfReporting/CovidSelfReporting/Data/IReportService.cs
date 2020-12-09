using CovidSelfReporting.Models;

namespace CovidSelfReporting.Data
{
    interface IReportService
    {
        void AddReport(Report report);
    }
}
