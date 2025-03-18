using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;

namespace JobProfileMaker.core.Contracts.EntityServices;

public interface IEducationService
{
    Task<int> InsertEducationAsync(EducationRequestModel model);
    Task<int> UpdateEducationAsync(EducationRequestModel model);
    Task<int> DeleteEducationAsync(int id);
    Task<EducationResponseModel> GetEducationByIdAsync(int id);
    Task<IEnumerable<EducationResponseModel>> GetAllEducationAsync();
}