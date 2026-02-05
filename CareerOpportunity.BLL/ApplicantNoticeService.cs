using System.Collections.Generic;
using CareerOpportunity.DAL;
using CareerOpportunity.Models;

namespace CareerOpportunity.BLL
{
    //object baniye just call krabo
    public class ApplicantNoticeService
    {
        private readonly ApplicantNoticeRepository _repo;

        public ApplicantNoticeService()
        {
            _repo = new ApplicantNoticeRepository();
        }

        public List<Notice> GetAll()
        {
            return _repo.GetAll();
        }

        public List<Notice> Filter(string status)
        {
            return _repo.Filter(status);

        }

        public List<Notice> SearchById(int id)
        {
            return _repo.SearchById(id);
        }
    }
}
