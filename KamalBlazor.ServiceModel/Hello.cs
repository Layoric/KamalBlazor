using ServiceStack;

namespace KamalBlazor.ServiceModel;

[Route("/hello/{Name}")]
public class Hello : IGet, IReturn<HelloResponse>
{
    public required string Name { get; set; }
}

public class HelloResponse
{
    public required string Result { get; set; }
}

[Route("/up")]
public class KamalUp : IGet, IReturn<KamalUpResponse>
{
}

public class KamalUpResponse
{
    
}