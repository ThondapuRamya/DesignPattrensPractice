using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
    [TestClass]
   public class GOFFactoryPattrenTest
    {
        [TestMethod]
        public void CreateNormalFactoryChromeDriver()
        {
            FactoryInterface f = new FactoryForNormalDriverInstance();
            BaseClass b = new BaseClass(f);
            b.CreateRequiredFactoryInstance("Chrome");
        }

        [TestMethod]
        public void CreateNormalFactoryIEDriver()
        {
            FactoryInterface f = new FactoryForNormalDriverInstance();
            BaseClass b = new BaseClass(f);
            b.CreateRequiredFactoryInstance("IE");

        }

        [TestMethod]
        public void CreateSecureFactoryChromeDriver()
        {
            FactoryInterface f = new FactoryForSecureDriverInstance();
            BaseClass b = new BaseClass(f);
            b.CreateRequiredFactoryInstance("Chrome");
        }

        [TestMethod]
        public void CreateSecureFactoryIEDriver()
        {
            FactoryInterface f = new FactoryForSecureDriverInstance();
            BaseClass b = new BaseClass(f);
            b.CreateRequiredFactoryInstance("IE");

        }
    }
}
