using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;

namespace JobProfileMaker.core.Contracts.EntityServices;

public interface ICandidateService
{
    Task<int> InsertCandidateAsync(CandidateRequestModel model);
    Task<int> UpdateCandidateAsync(CandidateRequestModel model);
    Task<int> DeleteCandidateAsync(int id);
    Task<CandidateResponseModel> GetCandidateByIdAsync(int id);
    Task<IEnumerable<CandidateResponseModel>> GetAllCandidateAsync();
}