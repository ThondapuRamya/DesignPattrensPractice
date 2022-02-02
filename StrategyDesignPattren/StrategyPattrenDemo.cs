using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StrategyDesignPattren
{
    [TestClass]
    public class StrategyPattrenDemo
    {
        [TestMethod]
        public void SendViaEmail()
        {
            StrategyBuilder s = new StrategyBuilder(new ShareViaEmail());
           Console.WriteLine( s.SharePhotos());
        }

        [TestMethod]
        public void SendViaText()
        {
            StrategyBuilder s = new StrategyBuilder(new ShareViaText());
            Console.WriteLine(s.SharePhotos());
        }

        [TestMethod]
        public void SendViaSocialMedia()
        {
            StrategyBuilder s = new StrategyBuilder(new ShareViaSocialMedia());
            Console.WriteLine(s.SharePhotos());
        }

    }
}
