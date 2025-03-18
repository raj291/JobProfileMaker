using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JobProfileMaker.core.Entities;

namespace JobProfileMaker.core.Models.Response;

public class SkillResponseModel
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public string SkillName { get; set; }
    public decimal? YearsOfExperience { get; set; }
    
    [Required]
    public int CandidateId { get; set; }
    public Candidate Candidate { get; set;}
}