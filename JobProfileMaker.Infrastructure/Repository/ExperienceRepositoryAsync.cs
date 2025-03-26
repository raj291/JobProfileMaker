using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.core.Entities;
using JobProfileMaker.Infrastructure.Data;

namespace JobProfileMaker.Infrastructure.Repository;

public class ExperienceRepositoryAsync : BaseRepositoryAsync<Experience> , IExperienceRepository
{
    public ExperienceRepositoryAsync(JobProfileMakerDbContext dbContext) : base(dbContext)
    {
        
    }
}