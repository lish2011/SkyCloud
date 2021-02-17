using System;
using System.Collections.Generic;
using System.Text;

namespace EhsDayoffManage
{
    public class StaffInfo
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string Name { get; set; }
        public decimal Total { get; set; }
        public decimal Surplus { get; set; }
        public decimal Used { get; set; }

        public decimal GetTotal() 
        {
            return 0;
        }

        public void AddMonthDayoffToTotal() 
        {

        }

        public decimal GetUsed() 
        {
            return 0;
        }

        public decimal GetSurplus() 
        {
            return Total - Used;
        }
    }
}
