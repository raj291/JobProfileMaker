using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.core.Entities;
using JobProfileMaker.Infrastructure.Data;

namespace JobProfileMaker.Infrastructure.Repository;

public class CandidateRepositoryAsync : BaseRepositoryAsync<Candidate> , ICandidateRepository
{
    public CandidateRepositoryAsync(JobProfileMakerDbContext dbContext) : base(dbContext)
    {
    }
}