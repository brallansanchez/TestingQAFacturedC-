using Microsoft.EntityFrameworkCore;

namespace TestinQAFacturedC_.Data
{
    public class TestinQAFacturedC_Context:DbContext
    {
        public TestinQAFacturedC_Context(DbContextOptions options):base(options)
        {

        }
       
    }
}
