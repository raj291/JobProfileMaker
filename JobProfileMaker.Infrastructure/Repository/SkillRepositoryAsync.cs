using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.core.Entities;
using JobProfileMaker.Infrastructure.Data;

namespace JobProfileMaker.Infrastructure.Repository;

public class SkillRepositoryAsync : BaseRepositoryAsync<Skills> , ISkillRepository
{
    public SkillRepositoryAsync(JobProfileMakerDbContext dbContext) : base(dbContext)
    {
        
    }
    
}