using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryPattrenPractice
{
    [TestClass]
    public class FactoryPattrenTest
    {
        [TestMethod]
        public void CreateNormalChromeDriver()
        {
            FactoryForNormalDriverInstance f = new FactoryForNormalDriverInstance();
            NormalInterface n = f.CraeteInstance("Chrome");
            n.CreateInstance();

        }

        [TestMethod]
        public void CreateNormalIEDriver()
        {
            FactoryForNormalDriverInstance f = new FactoryForNormalDriverInstance();
            NormalInterface n = f.CraeteInstance("IE");
            n.CreateInstance();

        }
    }
}
