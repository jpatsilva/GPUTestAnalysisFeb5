using GPUTestAnalysisFeb5.Shared.Entity;

namespace GPUTestAnalysisFeb5.Shared.Services
{
    public interface IGPUService
    {
        Task<List<GPU>> GetAllGPUs();
        Task<GPU> AddGPU(GPU gpu);
    }
}
