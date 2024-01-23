using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_Api.Models.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetServiceList()
        {
            var values = await _serviceRepository.GetallServiceAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
              _serviceRepository.CreateService(createServiceDto);
            return Ok("Hakkımızda Başarılı Bir Şekilde Eklendi...");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok("Hakkımızda Başarılı bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateService(updateServiceDto);
            return Ok("Hakkımızda Başarıyla Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _serviceRepository.GetByIDService(id);
            return Ok(value);
        }
    }
}
