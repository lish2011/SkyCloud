using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace EhsDayoffManage
{
    public class UserInterface
    {
        public DataTable QueryMyEhsDayoffInfo(int staffId) 
        {
            var dt = new DataTable();       // 
            return dt; 
        }

        public Opinion ReviewRequest() 
        {
            return Opinion.Approved;
        }

        public void SponsorsRequest(int staffId, DateTime start, DateTime end) 
        {
            var requestInfo = new RequestInfo();
        }

        private int GetMyStaffId() 
        {
            return 0;
        }


            
    }
}
