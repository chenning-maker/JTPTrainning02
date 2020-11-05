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
    public class PersonAppService : AsyncCrudAppService<Person, PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>, IPersonAppService
    {
        public PersonAppService(IRepository<Person,int> repository) : base(repository){

            
        
        }



        protected override IQueryable<Person> CreateFilteredQuery(PagedPersonResultRequestDto input)
        {
            return (IQueryable<Person>)Repository.GetAll()
                .WhereIf(!input.KeyWord.IsNullOrWhiteSpace(),a =>a.Name.Contains(input.KeyWord));
        }
    }
}
