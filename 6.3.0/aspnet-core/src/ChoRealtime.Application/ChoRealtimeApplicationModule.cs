using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ChoRealtime.Authorization;

namespace ChoRealtime
{
    [DependsOn(
        typeof(ChoRealtimeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ChoRealtimeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ChoRealtimeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ChoRealtimeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
