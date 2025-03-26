using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.core.Entities;
using JobProfileMaker.Infrastructure.Data;

namespace JobProfileMaker.Infrastructure.Repository;

public class EducationRepositoryAsync : BaseRepositoryAsync<Education> , IEducationRepository
{
    public EducationRepositoryAsync(JobProfileMakerDbContext dbContext) : base(dbContext)
    {
    }
}