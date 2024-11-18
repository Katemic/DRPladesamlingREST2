using Microsoft.EntityFrameworkCore;

namespace DRPladesamlingREST2.Collections
{
    public class RecordDBContext : DbContext
    {
        public DbSet<Record> Records { get; set; }

        public RecordDBContext(DbContextOptions<RecordDBContext> options) : base(options) 
        {

        }
    }
}
