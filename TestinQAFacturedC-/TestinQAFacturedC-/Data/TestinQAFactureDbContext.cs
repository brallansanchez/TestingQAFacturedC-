using Microsoft.EntityFrameworkCore;

namespace TestinQAFacturedC_.Data
{
    public class TestinQAFactureDbContext:DbContext
    {
        public TestinQAFactureDbContext(DbContextOptions options):base(options)
        {

        }
       
    }
}
