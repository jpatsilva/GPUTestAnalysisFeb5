using GPUTestAnalysisFeb5.Shared.Entity;

namespace GPUTestAnalysisFeb5.Shared.Services
{
    public interface IGPUService
    {
        Task<List<GPU>> GetAllGPUs();
        Task<GPU> AddGPU(GPU gpu);
        Task<GPU> GetGPUById(int id);
        Task<GPU> EditGPU(int id, GPU gpu);
        Task<bool> DeleteGPU(int id);
    }
}
