using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test.Dto
{
  public  class MeetingProfile: Profile
    {
        public MeetingProfile() {

            CreateMap<Meeting, MeetingDto>();
            CreateMap<MeetingDto, Meeting>();
            CreateMap<CreateMeetingDto, Meeting>();
        
        
        }
    }
}
