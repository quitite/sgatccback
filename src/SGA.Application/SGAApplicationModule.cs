using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SGA.Authorization;

namespace SGA
{
    [DependsOn(
        typeof(SGACoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SGAApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SGAAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SGAApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
