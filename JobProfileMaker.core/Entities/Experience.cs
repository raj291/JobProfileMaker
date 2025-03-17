using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobProfileMaker.core.Entities;

public class Experience
{
    public int Id { get; set; }
    [Required]
    public int CandidateId { get; set; }
    [ForeignKey("CandidateId")]
    public Candidate Candidate { get; set; }
    [Required]
    [StringLength(100)]
    public string Company { get; set; }
    [Required]
    [StringLength(100)]
    public string JobTitle { get; set; }
    [StringLength(100)]
    public string Location { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    [DataType(DataType.Date)]
    public DateTime? EndDate { get; set; }

    
    [Column(TypeName = "nvarchar(max)")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }

 
    [StringLength(50)]
    public string Industry { get; set; }
}