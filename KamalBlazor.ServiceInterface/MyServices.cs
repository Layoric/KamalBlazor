using ServiceStack;
using KamalBlazor.ServiceModel;

namespace KamalBlazor.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
    
    public object Get(KamalUp request)
    {
        return new KamalUpResponse();
    }
}