using System;
using System.Collections.Generic;
using System.Text;

namespace EhsDayoffManage
{
    public enum Row
    {
        Staff,
        Pm,
        Admin,        
    }

    public enum Opinion 
    {
        Approved,
        Rejection,
        UnReview
    }

    public class ReviewInfo
    {
        public int Reviewer { get; set; }
        public DateTime Time { get; set; }
        public int Row { get; set; }
        public Opinion OpinionInst { get; set; }
    }
}
