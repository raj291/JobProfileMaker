using System.ComponentModel.DataAnnotations;
using JobProfileMaker.core.Entities;
using JobProfileMaker.core.ValueObject;

namespace JobProfileMaker.core.Models.Response;

public class CandidateResponseModel
{
    public int Id { get; set; }
    [Required][StringLength(50)]
    public string FirstName { get; set; }
    [Required][StringLength(50)]
    public string LastName { get; set; }
    [Required][EmailAddress]
    public string Email { get; set; }
    [Required][Phone]
    public string PhoneNumber { get; set; }
    [Required]
    public Address Address { get; set; }
    [Url]
    public string? LinkedinUrl { get; set; }

    public long? Resume { get; set; }
    
    [DataType(DataType.DateTime)]
    public DateTime CreatedDate { get; set; }
    
    [DataType(DataType.DateTime)]
    public DateTime UpdatedDate { get; set; }

    public List<Education> Educations { get; set; }
    public List<Experience> Experiences { get; set; }
    public Resume ResumeFile { get; set; }
    public List<Skills> SkillsList { get; set; }
}