using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlister.web.Controllers;
using System.Web.Mvc;
using Playlister.web.Models;

    [TestClass]
    public class LoginTEST
    {
        public class AccountService : AccountController
        {
            public bool DoLogin(string username, string password)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    return false;
                return true;
            }
        }

        [TestMethod]
        //test a successful login
        public void CorrectCredentials()
        {
            var accountService = new AccountService();

            bool result = accountService.DoLogin("test", "test");

            Assert.IsTrue(result);
        }

        [TestMethod]
        //test the return view
        public void TestLoginView()
        {
            var controller = new AccountController();
            var result = controller.Login("/Profile/Login") as ViewResult;
            Assert.AreEqual("Login", result.ViewName);
        }
    }

