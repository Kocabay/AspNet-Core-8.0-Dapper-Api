using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocaitonDtos;

namespace RealEstate_Dapper_Api.Models.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository 
    {
        Task<List<ResultPopularLocationDtos>> GetAllPopularLocationAsync();
      
    }
}
