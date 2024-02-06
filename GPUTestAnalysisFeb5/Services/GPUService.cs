using GPUTestAnalysisFeb5.Data;
using GPUTestAnalysisFeb5.Entity;
using Microsoft.EntityFrameworkCore;

namespace GPUTestAnalysisFeb5.Services
{
    public class GPUService : IGPUService
    {
        private readonly DataContext _context;

        public GPUService(DataContext context) 
        {
            _context = context;
        }

        public async Task<GPU> AddGPU(GPU gpu) 
        {
            _context.GPUs.Add(gpu);
            await _context.SaveChangesAsync();

            return gpu;
        }
        public async Task<List<GPU>> GetAllGPUs()
        {
            var gpus = await _context.GPUs.ToListAsync();
            return gpus;
        }
    }
}
