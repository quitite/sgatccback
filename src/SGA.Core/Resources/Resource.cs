using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;

namespace SGA.Resources
{

    [AutoMapFrom(typeof(Resource))]
    public class ResourceDto :EntityDto<int>
    {
        public string nomeAtivo { get; set; }
        public string areaResponsavel { get; set; }
        public DateTime dataEntrada { get; set; }
        public bool bLiquidado { get; set; }
    }

    public class Resource : Entity<int>
    {
        public string nomeAtivo { get; set; }
        public string areaResponsavel { get; set; }
        public DateTime dataEntrada { get; set; }
        public bool bLiquidado { get; set; }
    }
}
