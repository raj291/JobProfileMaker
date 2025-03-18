using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JobProfileMaker.core.Entities;

namespace JobProfileMaker.core.Models.Request;

public class SkillRequestModel
{
    [Required]
    [StringLength(50)]
    public string SkillName { get; set; }
    public decimal? YearsOfExperience { get; set; }
    
    [Required]
    public int CandidateId { get; set; }
    
    public Candidate Candidate { get; set;}
}