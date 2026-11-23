using HelloWorld;

namespace HelloWorld.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsHelloWithName()
    {
        string result = Greeter.Greet("Vitaliy");
        Assert.Equal("Hello Vitaliy", result);
    }
}