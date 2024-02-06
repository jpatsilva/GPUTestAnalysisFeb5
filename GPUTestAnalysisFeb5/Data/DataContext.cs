using GPUTestAnalysisFeb5.Entity;
using Microsoft.EntityFrameworkCore;

namespace GPUTestAnalysisFeb5.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<GPU> GPUs { get; set; }
    }
}
