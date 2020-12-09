using System;
using System.ComponentModel.DataAnnotations;

namespace CovidSelfReporting.Models
{
    public class Report
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(9)]
        public string StudentNumber { get; set; }

        [MaxLength(20)]
        public string Contact_Number { get; set; }

        [Required]
        public DateTime ReportDate { get; set; }

        [Required]
        public DateTime DiagnosisDate { get; set; }

    }
}
