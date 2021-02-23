using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SGA.EntityFrameworkCore;
using SGA.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SGA.Web.Tests
{
    [DependsOn(
        typeof(SGAWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SGAWebTestModule : AbpModule
    {
        public SGAWebTestModule(SGAEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SGAWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SGAWebMvcModule).Assembly);
        }
    }
}