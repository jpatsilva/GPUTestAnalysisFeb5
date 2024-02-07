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

        [HttpGet("{id}")]
        public async Task<ActionResult<GPU>> GetGPUById(int id)
        {
            var gpu = await _gpuService.GetGPUById(id);
            return Ok(gpu);
        }

        [HttpPost]
        public async Task<ActionResult<GPU>> AddGPUs(GPU gpu)
        {
            var addedGPU = await _gpuService.AddGPU(gpu);
            return Ok(addedGPU);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GPU>> EditGPU(int id, GPU gpu)
        {
            var updatedGPU = await _gpuService.EditGPU(id, gpu);
            return Ok(updatedGPU);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<GPU>> DeleteGPU(int id)
        {
            var result = await _gpuService.DeleteGPU(id);
            return Ok(result);
        }
    }
}
