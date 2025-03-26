using AutoMapper;
using JobProfileMaker.core.Entities;
using JobProfileMaker.core.Models.Request;
using JobProfileMaker.core.Models.Response;

namespace JobProfileMaker.WebAPI.Utiltity;

public class JobProfileMapper : Profile
{
    public JobProfileMapper()
    {
        CreateMap<CandidateRequestModel, Candidate>().ReverseMap();
        CreateMap<CandidateResponseModel, Candidate>().ReverseMap();
        CreateMap<EducationRequestModel, Education>().ReverseMap();
        CreateMap<EducationResponseModel, Education>().ReverseMap();
        CreateMap<ExperienceRequestModel, Experience>().ReverseMap();
        CreateMap<ExperienceResponseModel, Experience>().ReverseMap();
        CreateMap<SkillRequestModel, Skills>().ReverseMap();
        CreateMap<SkillResponseModel, Skills>().ReverseMap();
    }
    
}