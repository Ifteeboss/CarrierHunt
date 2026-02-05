/*using CareerOpportunity.DAL;
using System;
using System.Data;
using CareerOpportunity.Models;

namespace CareerOpportunity.BLL
{
    public class RecuiterService
    {
        private readonly RecuiterRepository _repo = new RecuiterRepository();

        // Publish job
        public bool PostJob(Job job)
        {
            if (job == null) return false;
            if (job.RecruiterID <= 0) return false;

            // Basic validation
            if (string.IsNullOrWhiteSpace(job.Title)) return false;
            if (string.IsNullOrWhiteSpace(job.Description)) return false;
            if (string.IsNullOrWhiteSpace(job.RequiredSkill)) return false;
            if (string.IsNullOrWhiteSpace(job.Experience)) return false;
            if (string.IsNullOrWhiteSpace(job.JobType)) return false;
            if (string.IsNullOrWhiteSpace(job.SalaryOrBudget)) return false;

            // Date validation
            if (job.Deadline == DateTime.MinValue) return false;
            if (job.Deadline < DateTime.Now.Date) return false;

            if (job.PostedDate == DateTime.MinValue)
                job.PostedDate = DateTime.Now;

            if (string.IsNullOrWhiteSpace(job.Status))
                job.Status = "Pending";

            return _repo.PostJob(job);
        }

        // FIXED: Method name matches your Form (GetJobsRecuiter)
        // Internal call matches the Repository (GetJobsByRecruiter)
        public DataTable GetJobsRecuiter(int recruiterId)
        {
            if (recruiterId <= 0) return null;
            return _repo.GetJobsByRecruiter(recruiterId);
        }

        public DataTable GetJobById(int recruiterId, int jobId)
        {
            if (recruiterId <= 0 || jobId <= 0) return null;
            return _repo.GetJobById(recruiterId, jobId);
        }

        public bool UpdateJob(Job job)
        {
            if (job == null) return false;
            if (job.JobID <= 0) return false;
            if (job.RecruiterID <= 0) return false;
            if (string.IsNullOrWhiteSpace(job.Title)) return false;

            if (string.IsNullOrWhiteSpace(job.Status))
                job.Status = "Active";

            return _repo.UpdateJob(job);
        }

        public bool DeleteJob(int recruiterId, int jobId)
        {
            if (recruiterId <= 0 || jobId <= 0) return false;
            return _repo.DeleteJob(recruiterId, jobId);
        }

        public DataTable GetApplicantsByJob(int recruiterId, int jobId)
        {
            if (recruiterId <= 0 || jobId <= 0) return null;
            return _repo.GetApplicantsByJob(recruiterId, jobId);
        }
    }
}
*/