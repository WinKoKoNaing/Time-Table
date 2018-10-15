using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSELFSTUDYPG
{
    class Schedule
    {
        public string sdate, subject, startTime, endTime;
        public Schedule(string sdate, string subject, string startTime, string endTime)
        {
            this.sdate = sdate;
            this.subject = subject;
            this.startTime = startTime;
            this.endTime = endTime;
        }
        
    }
}
