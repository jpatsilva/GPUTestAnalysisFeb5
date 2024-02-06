using GPUTestAnalysisFeb5.Data;
using GPUTestAnalysisFeb5.Entity;
using Microsoft.EntityFrameworkCore;

namespace GPUTestAnalysisFeb5.Services
{
    public class GPUService : IGPUService
    {
        private readonly DataContext _context;
        List<GPU> _gpuList = new();

        public GPUService(DataContext context) 
        {
            _context = context;
        }
        public async Task<List<GPU>> GetAllGPUs()
        {
            _gpuList = await _context.GPUs.ToListAsync();
            return _gpuList;
        }
    }
}
