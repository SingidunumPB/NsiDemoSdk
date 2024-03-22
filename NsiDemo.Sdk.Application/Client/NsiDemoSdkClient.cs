using NsiDemo.Sdk.Application.Extensions;
using NsiDemo.Sdk.Application.Models;

namespace NsiDemo.Sdk.Application.Client;

public class NsiDemoSdkClient(IDemoApi api) : INsiDemoSdkClient
{
    public async Task<DemoProductCreateResponseModel> CreateProductAsync(DemoProductRequestModel request)
    {
        var result = await api.CreateProductAsync(request.ToDto(), request.Headers);
        return result.ToModel();
    }
}
