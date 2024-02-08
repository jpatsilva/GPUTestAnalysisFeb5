using GPUTestAnalysisFeb5.Shared.Data;
using GPUTestAnalysisFeb5.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace GPUTestAnalysisFeb5.Shared.Services
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

        public async Task<bool> DeleteGPU(int id)
        {
            var dbGPU = await _context.GPUs.FindAsync(id);
            if (dbGPU != null) 
            {
                _context.Remove(dbGPU);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<GPU> EditGPU(int id, GPU gpu)
        {
            var dbGPU = await _context.GPUs.FindAsync(id);
            if (dbGPU != null) 
            {
                dbGPU.Type = gpu.Type;
                //dbuGPU.Parameter = gpu.Parameter;
                //dbuGPU.Expression = gpu.Expression;
                //dbuGPU.Description = gpu.Destription;

                await _context.SaveChangesAsync();
                return dbGPU;
            }
            throw new Exception("GPU not found.");
        }

        public async Task<List<GPU>> GetAllGPUs()
        {
            var gpus = await _context.GPUs.ToListAsync();
            return gpus;
        }

        public async Task<GPU> GetGPUById(int id)
        {
            var dbGPU = await _context.GPUs.FindAsync(id);

            if (dbGPU != null)
            {
                return dbGPU;
            }
            throw new Exception("No GPU found.");
        }
    }
}
