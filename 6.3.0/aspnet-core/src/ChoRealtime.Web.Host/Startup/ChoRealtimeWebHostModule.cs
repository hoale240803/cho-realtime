using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ChoRealtime.Configuration;

namespace ChoRealtime.Web.Host.Startup
{
    [DependsOn(
       typeof(ChoRealtimeWebCoreModule))]
    public class ChoRealtimeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ChoRealtimeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ChoRealtimeWebHostModule).GetAssembly());
        }
    }
}
