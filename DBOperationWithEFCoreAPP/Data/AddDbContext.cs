using Microsoft.EntityFrameworkCore;

namespace DBOperationWithEFCoreAPP.Data
{
	public class AddDbContext : DbContext
	{
        public AddDbContext(DbContextOptions<AddDbContext> options):base(options) 
        {
                
        }
    }
}
