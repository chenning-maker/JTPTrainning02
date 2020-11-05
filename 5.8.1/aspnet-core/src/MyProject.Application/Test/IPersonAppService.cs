using Abp.Application.Services;
using MyProject.Test.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
    public interface IPersonAppService : IAsyncCrudAppService<PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>
    {
    }
}
