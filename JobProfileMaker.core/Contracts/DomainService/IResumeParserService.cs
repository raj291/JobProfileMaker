namespace JobProfileMaker.core.Contracts.DomainService;

public interface IResumeParserService
{
    Task<ParsedResumeDTO> ParseResumeAsync(string rawResumeText);
}