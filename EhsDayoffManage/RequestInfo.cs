using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EhsDayoffManage
{
    public class RequestInfo
    {
        public StaffEhsDayoffInfo StaffInfo{ get; set; }
        public int Submitter { get; set; }
        public DateTime SubmiteTime { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Days { get; set; }
        public List<ReviewInfo> ReviewInfos { get; set; }

        public State StateInst { get; set; } = State.Unfinished;

        public RequestInfo()
        {
            ReviewInfos = new List<ReviewInfo>();
        }

        public void AddReviewer() 
        {
            
        }

        public ReviewInfo GetCurrentReviewInfo()
        {
            var x = ReviewInfos.Where(t => t.OpinionInst == Opinion.UnReview).FirstOrDefault();
            if (x == null) 
            {
                x = ReviewInfos.Last();
            }
            return x;
        }

        public bool IsApproved() 
        {
            if (ReviewInfos.Last().OpinionInst == Opinion.Approved)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }

    public enum State 
    {
        Unfinished,
        Approved,
        Rejection
    }

}
