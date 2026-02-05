using CareerOpportunity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CareerOpportunity.BLL
{
    public class JobService
    {
        private readonly JobRepository repository = new JobRepository();
        public string ApproveJob(int jobId)
        {
            return repository.ApproveJob(jobId);
        }
        public string RejectJob(int jobId)
        {
            return repository.RejectJob(jobId);
        }
        public DataTable GetPendingJobs()
        {
            return repository.GetPendingJobs();
        }
        public int GetPendingJobsCount()
        {
            return repository.GetPendingJobCount();
        }
    }
}
