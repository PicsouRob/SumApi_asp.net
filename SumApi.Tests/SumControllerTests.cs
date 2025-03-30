using SumApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SumApi.Tests
{
    public class SumControllerTests
    {
        [Fact]
        public void Add_ReturnCorrectSum()
        {
            var controller = new SumController();

            var result = controller.Add(12, 33) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(45, result.Value);
        }
    }
}

