using NsiDemo.Sdk.Application.Models;

namespace NsiDemo.Sdk.Application.Client;

public interface INsiDemoSdkClient
{
    public Task<DemoProductCreateResponseModel> CreateProductAsync(DemoProductRequestModel request);
}
