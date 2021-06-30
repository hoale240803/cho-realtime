using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ChoRealtime.Configuration;
using ChoRealtime.EntityFrameworkCore;
using ChoRealtime.Migrator.DependencyInjection;

namespace ChoRealtime.Migrator
{
    [DependsOn(typeof(ChoRealtimeEntityFrameworkModule))]
    public class ChoRealtimeMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ChoRealtimeMigratorModule(ChoRealtimeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ChoRealtimeMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ChoRealtimeConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ChoRealtimeMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
