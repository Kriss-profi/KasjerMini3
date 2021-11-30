using Microsoft.VisualStudio.TestTools.UnitTesting;
using KasjerMini3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasjerMini3.ViewModel.Tests
{
    [TestClass()]
    public class WalletTests
    {
        [TestMethod()]
        public void WalletTest()
        {
            var w = new Wallet();
            w.QuantityNom1 = 10;
            w.ZerujCommand.Execute(null);
            
            Assert.AreEqual(0, w.WalletValue);
        }
    }
}