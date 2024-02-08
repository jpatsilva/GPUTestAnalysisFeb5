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

            HttpContent content = result.Content;

            return await result.Content.ReadFromJsonAsync<GPU>();

        }

        public async Task<bool> DeleteGPU(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/gpu/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<GPU> EditGPU(int id, GPU gpu)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/gpu{id}", gpu);

            HttpContent content = result.Content;

            return await content.ReadFromJsonAsync<GPU>();
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
