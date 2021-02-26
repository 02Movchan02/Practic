using ControllersAndAction.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ControllersAndAction.Tests
{
    public class ActionTests
    {
        [Fact]
        public void NotFoundActionMethod()
        {
            ExampleController controller = new ExampleController();
            StatusCodeResult result = controller.Index();
            Assert.Equal(404, result.StatusCode);
        }
    }
}
