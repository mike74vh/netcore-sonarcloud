using Example.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace WeatherForecastUnitTests;

[TestClass]
public class WeatherForecastUnitTests
{
    private WeatherForecastController? _controller;

    [TestInitialize()]
    public void Initialize()
    {
        ILogger<WeatherForecastController> logger = Mock.Of<ILogger<WeatherForecastController>>();
        _controller = new WeatherForecastController(logger);
    }

    [TestMethod]
    public void WeatherForecastController_ShouldBeNotNull()
    {
        Assert.IsNotNull(_controller);
    }

    [TestMethod]
    public void WeatherForecastController_GetResult_ShouldBeNotNull()
    {
        if (_controller != null)
        {
            var result = _controller.Get();
            Assert.IsNotNull(result);
        }
    }
}