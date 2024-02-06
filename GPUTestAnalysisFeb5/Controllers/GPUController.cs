using GPUTestAnalysisFeb5.Shared.Entity;
using GPUTestAnalysisFeb5.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GPUTestAnalysisFeb5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GPUController : ControllerBase
    {
        private readonly IGPUService _gpuService;

        public GPUController(IGPUService gpuService)
        {
            _gpuService = gpuService;
        }

        [HttpPost]
        public async Task<ActionResult<GPU>> AddGPUs(GPU gpu)
        {
            var addedGPU = await _gpuService.AddGPU(gpu);
            return Ok(addedGPU);
        }
    }
}
