using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {

        PizzaController controller = new PizzaController();
        [Fact]
        public void ThirdPizzaIsHawaii()
        {
            var returnValue = controller.GetPizza(3);
            Assert.Equal("Hawaii", returnValue.Name);
        }

        [Fact]
        public void FourtPizzaIsDiavolo()
        {
            var returnValue = controller.GetPizza(4);
            Assert.Equal("Diavolo", returnValue.Name);
        }
    }
}
