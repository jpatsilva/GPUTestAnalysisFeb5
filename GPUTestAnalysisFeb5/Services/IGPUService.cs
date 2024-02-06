using GPUTestAnalysisFeb5.Entity;

namespace GPUTestAnalysisFeb5.Services
{
    public interface IGPUService
    {
        Task<List<GPU>> GetAllGPUs();
    }
}
