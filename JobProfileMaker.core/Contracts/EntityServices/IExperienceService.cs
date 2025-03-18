using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;

namespace JobProfileMaker.core.Contracts.EntityServices;

public interface IExperienceService
{
    Task<int> InsertExperienceAsync(ExperienceRequestModel model);
    Task<int> UpdateExperienceAsync(ExperienceRequestModel model);
    Task<int> DeleteExperienceAsync(int id);

    Task<ExperienceResponseModel> GetExperienceByIdAsync(int id);
    Task<IEnumerable<ExperienceResponseModel>> GetAllExperienceAsync();

}