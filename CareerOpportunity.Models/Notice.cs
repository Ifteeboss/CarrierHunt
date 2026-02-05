using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerOpportunity.Models
{
    public class Notice
    {
        public int NoticeId { get; set; }
        public string NoticeTitle { get; set; }
        public string NoticeType { get; set; }
        public string DetailsBox { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        //eta add krchi filter er jonno,query diyeo kra jeto but ekhane just property hishebe nilam
        public string Status { get; set; }

    }
}

