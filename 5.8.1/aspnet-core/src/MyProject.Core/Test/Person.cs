using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
   public class Person:Entity<int>
    {
        
        public int Number { set; get; }

        
        public string Name { get; set; }


        public string Sex { get; set; }


        public int Age { get; set; }


        public string Address { get; set; }


      
    }
}
