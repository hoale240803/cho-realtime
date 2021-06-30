using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ChoRealtime.EntityFrameworkCore;
using ChoRealtime.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ChoRealtime.Web.Tests
{
    [DependsOn(
        typeof(ChoRealtimeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ChoRealtimeWebTestModule : AbpModule
    {
        public ChoRealtimeWebTestModule(ChoRealtimeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ChoRealtimeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ChoRealtimeWebMvcModule).Assembly);
        }
    }
}