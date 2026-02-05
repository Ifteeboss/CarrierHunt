using System;

namespace CareerOpportunity.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public int RecruiterID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RequiredSkill { get; set; } // Fixed: Missing field added
        public string Experience { get; set; }    // Fixed: Missing field added
        public string JobType { get; set; }
        public string SalaryOrBudget { get; set; }
      //  public DateTime PostedDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
    }
}