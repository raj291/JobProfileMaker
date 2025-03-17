using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobProfileMaker.core.Entities;

public class Skills
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public string SkillName { get; set; }
    public decimal? YearsOfExperience { get; set; }
    
    [Required]
    public int CandidateId { get; set; }
    
    [ForeignKey("CandidateId")]
    public Candidate Candidate { get; set;}
}