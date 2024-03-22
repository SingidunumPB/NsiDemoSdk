using NsiDemo.Sdk.Dto;
using Refit;

namespace NsiDemo.Sdk;

public interface IDemoApi
{
    [Post("/webhook/ProductWebhook/Create/create")]
    public Task<DemoProductCreateResponseDto> CreateProductAsync(DemoProductRequestDto request, [HeaderCollection] IDictionary<string, string> headers);
}
