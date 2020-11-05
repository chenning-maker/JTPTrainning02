using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test.Dto
{
  public  class PersonProfile: Profile
    {
        public PersonProfile() {

            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
            CreateMap<CreatePersonDto, Person>();
        
        
        }
    }
}
