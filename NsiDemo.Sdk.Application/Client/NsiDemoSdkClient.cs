using NsiDemo.Sdk.Application.Extensions;
using NsiDemo.Sdk.Application.Models;
using Refit;

namespace NsiDemo.Sdk.Application.Client;

public class NsiDemoSdkClient : INsiDemoSdkClient
{
    public async Task<DemoProductCreateResponseModel> CreateProductAsync(DemoProductRequestModel request)
    {
        var api = RestService.For<IDemoApi>(request.BaseUrl);
        var result = await api.CreateProductAsync(request.ToDto());
        return result.ToModel();
    }
}
