using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystemApi
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options):base(options) 
        {

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
