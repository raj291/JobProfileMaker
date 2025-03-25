namespace JobProfileMaker.core.Contracts.DomainService;

public class ParsedResumeDTO
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<string> Skills { get; set; } = new List<string>();
    public List<ParsedEducationDto> Educations { get; set; } = new List<ParsedEducationDto>();
    public List<ParsedExperienceDto> Experiences { get; set; } = new List<ParsedExperienceDto>();
}
public class ParsedEducationDto
{
    public string Degree { get; set; }
    public string FieldOfStudy { get; set; }
    public string Institution { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Grade { get; set; }
}

public class ParsedExperienceDto
{
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; }
}