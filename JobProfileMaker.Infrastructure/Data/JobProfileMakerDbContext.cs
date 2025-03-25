


using JobProfileMaker.core.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobProfileMaker.Infrastructure.Data;

public class JobProfileMakerDbContext : DbContext
{

    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Skills> Skills { get; set; }
    public JobProfileMakerDbContext(DbContextOptions<JobProfileMakerDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Candidate>()
            .HasMany(e => e.Educations)
            .WithOne(e => e.Candidate)
            .HasForeignKey(e => e.CandidateId);

        modelBuilder.Entity<Candidate>()
            .HasMany(e => e.Experiences)
            .WithOne(e => e.Candidate)
            .HasForeignKey(e => e.CandidateId);

        modelBuilder.Entity<Education>()
            .HasOne(e => e.Candidate)
            .WithMany(e => e.Educations);

        modelBuilder.Entity<Experience>()
            .HasOne(e => e.Candidate)
            .WithMany(e => e.Experiences);

        modelBuilder.Entity<Candidate>()
            .HasOne(e => e.ResumeFile)
            .WithOne(e => e.Candidate);

        modelBuilder.Entity<Candidate>()
            .HasMany(e => e.SkillsList)
            .WithOne(e => e.Candidate)
            .HasForeignKey(e => e.CandidateId);
        
        

    }
}