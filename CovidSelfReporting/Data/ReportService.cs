using CovidSelfReporting.Models;

namespace CovidSelfReporting.Data
{
    public class ReportService : IReportService
    {

        private ReportDbContext _context;

        public ReportService(ReportDbContext reportDbContext)
        {
            _context = reportDbContext;
        }

        public void AddReport(Report report)
        {
            _context.Reports.Add(report);
            _context.SaveChanges();
        }
    }
}
