using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void View_is_returned()
        {
            var controller = new ExampleController();
            var result = controller.Index();

            Assert.AreEqual("Homepage", result.ViewName);
        }

        [TestMethod]
        public void ViewSelection2()
        {
            var controller = new ExampleController();
            var result = controller.Index2();

            Assert.AreEqual("Hello", result.ViewData.Model);
        }

        [TestMethod]
        public void ViewSelection3()
        {
            var controller = new ExampleController();
            var result = controller.Index3();

            Assert.AreEqual("hello", result.ViewBag.Message);
            Assert.AreEqual(DateTime.Now.Day, result.ViewBag.Date.Day);
        }

        [TestMethod]
        public void Redirect2()
        {
            var controller = new ExampleController();

            var result = controller.Redirect2();

            Assert.AreEqual("Example", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("MyID", result.RouteValues["ID"]);
        }
    }
}
