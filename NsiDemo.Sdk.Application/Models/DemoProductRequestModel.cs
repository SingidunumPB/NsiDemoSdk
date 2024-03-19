using NsiDemo.Sdk.Dto;

namespace NsiDemo.Sdk.Application.Models;

public record DemoProductRequestModel(Guid CompanyId, string Name, string BaseUrl)
{
    public DemoProductRequestDto ToDto()
    {
        return new DemoProductRequestDto(new DemoProductCreateDto(CompanyId,
            Name,
            Name + " - " + CompanyId));
    }
}
