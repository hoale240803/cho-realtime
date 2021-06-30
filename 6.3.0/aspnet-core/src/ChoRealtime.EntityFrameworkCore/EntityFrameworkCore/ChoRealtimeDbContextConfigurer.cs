using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ChoRealtime.EntityFrameworkCore
{
    public static class ChoRealtimeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ChoRealtimeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ChoRealtimeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
