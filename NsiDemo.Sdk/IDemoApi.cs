using NsiDemo.Sdk.Dto;
using Refit;

namespace NsiDemo.Sdk;

public interface IDemoApi
{
    [Post("/api/Product/Create/create")]
    public Task<DemoProductCreateResponseDto> CreateProductAsync(DemoProductRequestDto request);
}
