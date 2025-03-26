using AutoMapper;
using JobProfileMaker.core.Contracts.EntityServices;
using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.core.Entities;
using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;
using JobProfileMaker.Infrastructure.Data;

namespace JobProfileMaker.Infrastructure.Services;

public class CandidateServiceAsync : ICandidateService
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;
    public CandidateServiceAsync(ICandidateRepository candidateRepository, IMapper mapper)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;

    }
    public async Task<int> InsertCandidateAsync(CandidateRequestModel model)
    {
        Candidate entity = _mapper.Map<Candidate>(model);
         return await _candidateRepository.InsertAsync(entity);
    }

    public async Task<int> UpdateCandidateAsync(CandidateRequestModel model)
    {
        Candidate entity = _mapper.Map<Candidate>(model);
        if (entity != null)
        {
            return await _candidateRepository.UpdateAsync(entity);
        }

        return 0;
    }

    public async Task<int> DeleteCandidateAsync(int id)
    {
        return await _candidateRepository.DeleteAsync(id);
    }

    public async Task<CandidateResponseModel> GetCandidateByIdAsync(int id)
    {
        var result = _candidateRepository.GetByIdAsync(id);
        return _mapper.Map<CandidateResponseModel>(result);

    }

    public async Task<IEnumerable<CandidateResponseModel>> GetAllCandidateAsync()
    {
        return _mapper.Map<IEnumerable<CandidateResponseModel>>(await _candidateRepository.GetAllAsync());
    }
}