using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_Api.Models.Repositories.CategoryRepository;
using RealEstate_Dapper_Api.Models.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailsController : ControllerBase
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreDetailRepository;

        public WhoWeAreDetailsController(IWhoWeAreDetailRepository whoWeAreRepository)
        {
            _whoWeAreDetailRepository = whoWeAreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRepository.GetallWhoWeAreDetailAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDto);
            return Ok("Hakkımızda Başarılı Bir Şekilde Eklendi...");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreDetailRepository.DeleteWhoWeAreDetails(id);
            return Ok("Hakkımızda Başarılı bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDto);
            return Ok("Hakkımızda Başarıyla Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _whoWeAreDetailRepository.GetWhoWeAreDetail(id);
            return Ok(value);
        }
    }
}
