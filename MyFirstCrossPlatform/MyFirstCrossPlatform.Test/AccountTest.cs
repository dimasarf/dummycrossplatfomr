using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstCrossPlatform.UserAccount;

namespace MyFirstCrossPlatform.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void CreateAccount()
        {
            Account account = new Account()
            {
                Username = "dimas_arf",
                Password = "muhaimin"
            };

          
        }
    }
}
