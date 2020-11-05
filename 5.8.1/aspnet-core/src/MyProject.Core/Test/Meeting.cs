using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
   public class Meeting:Entity<int>
    {

       
        public int Number { set; get; }

       
        public string MeetingName { set; get; }

       
        public DateTime StartTime { set; get; }

        
        public DateTime EndTime { set; get; }

       
        public string Address { set; get; }

        
        public string Describe { set; get; }

       
        public string CreateUserName { set; get; }


    }
}
