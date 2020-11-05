using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test.Dto
{
     public  class PersonDto: EntityDto<int>
    {
        public int Number { set; get; }


        public string Name { get; set; }


        public string Sex { get; set; }


        public int Age { get; set; }


        public string Address { get; set; }

    }
}
