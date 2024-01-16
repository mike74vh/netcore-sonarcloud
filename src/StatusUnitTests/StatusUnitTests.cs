using Example.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace StatusUnitTests;

[TestClass]
public class StatusUnitTests
{
    private StatusController? _controller;

    [TestInitialize()]
    public void Initialize()
    {
        ILogger<StatusController> logger = Mock.Of<ILogger<StatusController>>();
        _controller = new StatusController(logger);
    }

    [TestMethod]
    public void StatusController_ShouldBeNotNull()
    {
        Assert.IsNotNull(_controller);
    }

    [TestMethod]
    public void StatusController_GetResult_ShouldBeNotNull()
    {
        if (_controller != null)
        {
            var result = _controller.Get();
            Assert.IsNotNull(result);
        }
    }
}