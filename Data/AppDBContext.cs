using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class AppDBContext : DbContext
    {
        // Initiallly this is normal class to make this DBContext class then make it child class for DBContext class.

        // DBContext requires options (connection string)

        // Using DependencyInjection can Inject object of AppDBContext to DbContext using constructor.

        public AppDBContext( DbContextOptions<AppDBContext> options) : base(options) // passing options to base class to build connection with database server.
        {
            // constructor

        }
    }
}
