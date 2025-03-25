using Microsoft.AspNetCore.Http;
namespace JobProfileMaker.core.Contracts.DomainService;

public interface IFileToTextConverterService
{
    Task<string> ConvertFileToTextAsync(IFormFile file);
}