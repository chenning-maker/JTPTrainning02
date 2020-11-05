using Abp.Application.Services;
using MyProject.Test.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
    public interface IMeetingAppService : IAsyncCrudAppService<MeetingDto, int, PagedMeetingResultRequestDto, CreateMeetingDto, MeetingDto>
    {
    }
}
