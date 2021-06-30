using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ChoRealtime.Authorization.Roles;
using ChoRealtime.Authorization.Users;
using ChoRealtime.MultiTenancy;

namespace ChoRealtime.EntityFrameworkCore
{
    public class ChoRealtimeDbContext : AbpZeroDbContext<Tenant, Role, User, ChoRealtimeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ChoRealtimeDbContext(DbContextOptions<ChoRealtimeDbContext> options)
            : base(options)
        {
        }
    }
}
