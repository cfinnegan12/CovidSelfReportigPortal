using CovidSelfReporting.Models;
using Microsoft.EntityFrameworkCore;

namespace CovidSelfReporting.Data
{
    public class ReportDbContext : DbContext
    {

        public ReportDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Report> Reports { get; set; }
    }
}
