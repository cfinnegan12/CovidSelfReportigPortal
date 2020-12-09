using CovidSelfReporting.Data;
using CovidSelfReporting.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace CovidSelfReporting.Controllers
{
    public class SubmitController : Controller
    {

        private IReportService _reportService;
        public SubmitController(IReportService reportService)
        {
            _reportService = reportService;
        }

        public IActionResult Index([FromQuery]string student_number, [FromQuery] string contact_number, [FromQuery] DateTime diagnosis_date)
        {
            Report report = new Report
            {
                StudentNumber = student_number,
                Contact_Number = contact_number,
                DiagnosisDate = diagnosis_date,
                ReportDate = DateTime.Today
            };

            _reportService.AddReport(report);
            return View();
        }
    }
}
