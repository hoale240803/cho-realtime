using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ChoRealtime.Configuration;
using ChoRealtime.Web;

namespace ChoRealtime.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ChoRealtimeDbContextFactory : IDesignTimeDbContextFactory<ChoRealtimeDbContext>
    {
        public ChoRealtimeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ChoRealtimeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ChoRealtimeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ChoRealtimeConsts.ConnectionStringName));

            return new ChoRealtimeDbContext(builder.Options);
        }
    }
}
