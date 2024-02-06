using GPUTestAnalysisFeb5.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GPUTestAnalysisFeb5.Shared.Services
{
    public class ClientGPUService : IGPUService
    {
        private readonly HttpClient _httpClient;

        public ClientGPUService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GPU> AddGPU(GPU gpu)
        {
            var result = await _httpClient
                .PostAsJsonAsync("/api/gpu", gpu);

            return await result.Content.ReadFromJsonAsync<GPU>();

        }

        public Task<List<GPU>> GetAllGPUs()
        {
            throw new NotImplementedException();
        }

        public async Task<GPU> GetGPUById(int id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<GPU>($"/api/gpu/{id}");

            return result;
        }
    }
}
