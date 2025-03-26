using AutoMapper;
using JobProfileMaker.core.Contracts.EntityServices;
using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.core.Entities;
using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;

namespace JobProfileMaker.Infrastructure.Services;

public class EducationServiceAsync : IEducationService
{
    private readonly IEducationRepository _educationRepository;
    private readonly IMapper _mapper;
    public EducationServiceAsync(IEducationRepository educationRepository, IMapper mapper)
    {
        _educationRepository = educationRepository;
        _mapper = mapper;
    }
    public async Task<int> InsertEducationAsync(EducationRequestModel model)
    {
        Education entity = _mapper.Map<Education>(model);
        return await _educationRepository.InsertAsync(entity);
    }

    public async Task<int> UpdateEducationAsync(EducationRequestModel model)
    {
        Education entity = _mapper.Map<Education>(model);
        if (entity != null)
        {
            return await _educationRepository.UpdateAsync(entity);
        }

        return 0;
    }

    public async Task<int> DeleteEducationAsync(int id)
    {
        return await _educationRepository.DeleteAsync(id);
    }

    public async Task<EducationResponseModel> GetEducationByIdAsync(int id)
    {
        var entity =  await _educationRepository.GetByIdAsync(id);
        return _mapper.Map<EducationResponseModel>(entity);
    }

    public async Task<IEnumerable<EducationResponseModel>> GetAllEducationAsync()
    {
        return _mapper.Map<IEnumerable<EducationResponseModel>>(await _educationRepository.GetAllAsync());
    }
}