using System;
using System.Collections.Generic;
using CareerOpportunity.DAL;
using CareerOpportunity.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerOpportunity.BLL
{
    public class RecruiterNoticeService
    {
        private readonly RecruiterNoticeRepository _repo;

        public RecruiterNoticeService()
        {
            _repo = new RecruiterNoticeRepository();
        }

        // CREATE krchi notun notice add korar jonno
        public void AddNotice(Notice notice)
        {
            _repo.Insert(notice);
        }

        // READ krchi database theke sob gulo notice niye asbe
        public List<Notice> GetAllNotices()
        {
            return _repo.GetAll();
        }

        // UPDATE krchi notice update korar jonno
        public void UpdateNotice(Notice notice)
        {
            _repo.Update(notice);
        }

        // DELETE korchi id diye
        public void DeleteNotice(int id)
        {
            _repo.Delete(id);
        }

        // SEARCH korchi id diye
        public List<Notice> SearchNoticeById(int id)
        {
            return _repo.SearchById(id);
        }
    }
}