using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace SGA.Resources
{
    public class ResourcesAppService : CrudAppService<Resource, ResourceDto>
    {
        public ResourcesAppService(IRepository<Resource, int> repository) : base(repository)
        {

        }
    }
}
