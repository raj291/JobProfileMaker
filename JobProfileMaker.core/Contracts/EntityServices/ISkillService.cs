using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;

namespace JobProfileMaker.core.Contracts.EntityServices;

public interface ISkillService
{
    Task<int> InsertSkillAsync(SkillRequestModel model);
    Task<int> UpdateSkillAsync(SkillRequestModel model);
    Task<int> DeleteSkillAsync(int id);
    Task<SkillResponseModel> GetSkillByIdAsync(int id);
    Task<IEnumerable<SkillResponseModel>> GetAllSkillAsync();
    
}