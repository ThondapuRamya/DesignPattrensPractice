using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DecoratorDesignPractice
{
    [TestClass]
    public class WidgetDemo
    {
        [TestMethod]
        public void TestMethod1()
        {
            WidgetInterface w = new Widget2Decorator(new Widget1Decorator(new WidgetConcrete()));
            Console.WriteLine(w.MakeWidget());
        }
    }
}
