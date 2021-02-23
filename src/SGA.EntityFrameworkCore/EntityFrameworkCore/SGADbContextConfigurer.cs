using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SGA.EntityFrameworkCore
{
    public static class SGADbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SGADbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SGADbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
