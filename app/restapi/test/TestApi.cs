using api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class TestApi
    {
        [TestMethod]
        public void TestApiMethod()
        {
            var controller = new WelcomeController();
            var result = (Microsoft.AspNetCore.Mvc.OkObjectResult)controller.Hello();
            
            Assert.AreEqual(result.Value, "Hola mundo");
        }
    }
}
