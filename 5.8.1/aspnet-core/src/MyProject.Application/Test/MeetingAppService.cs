using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using MyProject.Test.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test
{
    public class MeetingAppService : AsyncCrudAppService<Meeting, MeetingDto, int, PagedMeetingResultRequestDto, CreateMeetingDto, MeetingDto>, IMeetingAppService
    {
        public MeetingAppService(IRepository<Meeting,int> repository) : base(repository){

            
        
        }

        protected override IQueryable<Meeting> CreateFilteredQuery(PagedMeetingResultRequestDto input)
        {
            return (IQueryable<Meeting>)Repository.GetAll()
                .WhereIf(!input.KeyWord.IsNullOrWhiteSpace(), a => a.MeetingName.Contains(input.KeyWord)); 
        }
    }
}
