using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackathonApp.Controllers;
namespace HackathonApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index1Test()
        {
            HomeController home = new HomeController();
            var ret = home.Index1();
           Assert.AreEqual("Hello",ret);
        }
    }
}
