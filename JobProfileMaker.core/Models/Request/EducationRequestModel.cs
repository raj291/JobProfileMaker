using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JobProfileMaker.core.Entities;

namespace JobProfileMaker.core.Models.Request;

public class EducationRequestModel
{
    [Required][StringLength(100)]
    public string Degree { get; set; }
    [Required][StringLength(100)]
    public string FieldOfStudy { get; set; }
    [Required][StringLength(100)]
    public string University { get; set; }
    [Required][DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    [DataType(DataType.Date)]
    public DateTime? EndDate { get; set; }
    [Column(TypeName = "decimal(3,2)")]
    public decimal? Grade { get; set; }
    [Column(TypeName = "nvarchar(max)")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }
    public int CandidateId { get; set; }
    public Candidate Candidate { get; set; }
}