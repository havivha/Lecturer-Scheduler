using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecturer_Scheduler.Controllers;
using System.Web.Mvc;

namespace Lecturer_Scheduler.Tests
{
    [TestClass]
    public class LoginControllerTest
    {
        [TestMethod]
        public void TestMethod100()
        {
            LoginController lg = new LoginController();
            LoginModel model = new LoginModel();
            model.Username = "a";
            model.Password = "a";
            var res = lg.isUserValid(model);
            Assert.AreEqual("User is valid", res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            LoginController lg = new LoginController();
            LoginModel model = new LoginModel();
            model.Username = "b";
            model.Password = "a";
            var res = lg.isUserValid(model);
            Assert.AreEqual("User is invalid", res);     
        }

        [TestMethod]
        public void TestMethod3()
        {
            LoginController lg = new LoginController();
            LoginModel model = new LoginModel();
            model.Username = "a";
            model.Password = "a";
            var res = lg.Index(model) as ActionResult;
            Assert.AreEqual("System.Web.Mvc.RedirectToRouteResult", res.ToString());
        }

        [TestMethod]
        public void TestMethod4()
        {
            LoginController lg = new LoginController();
            LoginModel model = new LoginModel();
            model.Username = "b";
            model.Password = "a";
            var res = lg.Index(model) as ActionResult;
            Assert.AreEqual("System.Web.Mvc.ViewResult", res.ToString());
        }
    }
}
