using GPUTestAnalysisFeb5.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace GPUTestAnalysisFeb5.Shared.Data
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
