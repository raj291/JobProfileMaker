using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobProfileMaker.core.Entities;

public class Resume
{
    public int Id { get; set; }
    
    [Required]
    public int CandidateId { get; set; }
    
    [ForeignKey("CandidateId")]
    public Candidate Candidate { get; set; }
    [Required]
    [StringLength(255)]
    public string FilePath { get; set; }
    [Required]
    [StringLength(50)]
    public string FileType { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime UploadedDate { get; set; }

    // Indicates whether the resume has been parsed successfully
    public bool IsParsed { get; set; }
    [Column(TypeName = "nvarchar(max)")]
    [DataType(DataType.MultilineText)]
    public string ParsedText { get; set; }
    
    [StringLength(255)]
    public string OriginalFileName { get; set; }
   
}