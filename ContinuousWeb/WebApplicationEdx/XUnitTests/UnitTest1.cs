using Xunit;
using WebApplicationEdx.Controllers;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void AboutPageTest()
            {
                var homeController = new HomeController();
                var result = homeController.About();
            }
        
    }
}
