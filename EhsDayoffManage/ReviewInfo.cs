using System;
using System.Collections.Generic;
using System.Text;

namespace EhsDayoffManage
{
    public class ReviewInfo
    {
        public int Reviewer { get; set; }
        public DateTime Time { get; set; }
        public int Row { get; set; }
        public Opinion OpinionInst { get; set; }
    }
}
