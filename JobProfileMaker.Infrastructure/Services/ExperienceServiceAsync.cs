using AutoMapper;
using JobProfileMaker.core.Contracts.EntityServices;
using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.core.Entities;
using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;

namespace JobProfileMaker.Infrastructure.Services;

public class ExperienceServiceAsync : IExperienceService
{
    private readonly IExperienceRepository _experienceRepository;
    private readonly IMapper _mapper;
    public ExperienceServiceAsync(IExperienceRepository experienceRepository , IMapper mapper)
    {
        _experienceRepository = experienceRepository;
        _mapper = mapper;

    }
    public async Task<int> InsertExperienceAsync(ExperienceRequestModel model)
    {
        Experience entity = _mapper.Map<Experience>(model);
        return await _experienceRepository.InsertAsync(entity);
    }

    public async Task<int> UpdateExperienceAsync(ExperienceRequestModel model)
    {
        Experience entity = _mapper.Map<Experience>(model);
        if (entity != null)
        {
            return await _experienceRepository.UpdateAsync(entity);
        }

        return 0;
    }

    public async Task<int> DeleteExperienceAsync(int id)
    {
        return await _experienceRepository.DeleteAsync(id);
    }

    public async Task<ExperienceResponseModel> GetExperienceByIdAsync(int id)
    {
        var entity = _experienceRepository.GetByIdAsync(id); 
        return _mapper.Map<ExperienceResponseModel>(entity);
    }

    public async Task<IEnumerable<ExperienceResponseModel>> GetAllExperienceAsync()
    {
        return _mapper.Map<IEnumerable<ExperienceResponseModel>>(await _experienceRepository.GetAllAsync());
    }
}