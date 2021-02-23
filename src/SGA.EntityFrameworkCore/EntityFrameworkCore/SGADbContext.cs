using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SGA.Authorization.Roles;
using SGA.Authorization.Users;
using SGA.MultiTenancy;
using SGA.Resources;

namespace SGA.EntityFrameworkCore
{
    public class SGADbContext : AbpZeroDbContext<Tenant, Role, User, SGADbContext>
    {
        public DbSet<Resource> Resources { get; set; }
        /* Define a DbSet for each entity of the application */
        
        public SGADbContext(DbContextOptions<SGADbContext> options)
            : base(options)
        {
        }
    }
}
