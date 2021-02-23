using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SGA.Configuration;
using SGA.Web;

namespace SGA.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SGADbContextFactory : IDesignTimeDbContextFactory<SGADbContext>
    {
        public SGADbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SGADbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SGADbContextConfigurer.Configure(builder, configuration.GetConnectionString(SGAConsts.ConnectionStringName));

            return new SGADbContext(builder.Options);
        }
    }
}
