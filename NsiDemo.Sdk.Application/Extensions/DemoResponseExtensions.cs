using NsiDemo.Sdk.Application.Models;
using NsiDemo.Sdk.Dto;

namespace NsiDemo.Sdk.Application.Extensions;

public static class DemoResponseExtensions
{
    public static DemoProductCreateResponseModel ToModel(this DemoProductCreateResponseDto dto)
    {
        return new DemoProductCreateResponseModel(dto.Name, dto.Description, dto.CompanyName, dto.CompanyDescription);
    }
}
