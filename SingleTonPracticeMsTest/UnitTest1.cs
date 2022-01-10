using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingleTonPracticeMsTest
{
    [TestClass]
    public class UnitTest1
    {
        SingleTonDemo singleTonDemo = new SingleTonDemo();
        [TestMethod]
        public void ValidateBothInstancesSame()
        {
            Assert.IsTrue(singleTonDemo.CreateReferenceAndValidateBothArePointingToSame());
        }

        [TestMethod]

        public void AfterFillValidation()
        {
            Assert.IsTrue(singleTonDemo.AfterFillValidateBothInstanceHasSameVariables());

        }


        [TestMethod]

        public void AfterBoilValidation()
        {
            Assert.IsTrue(singleTonDemo.AfterBoilValidateBothInstanceHasSameVariables());

        }


        [TestMethod]

        public void AfterDrainValidation()
        {
            Assert.IsTrue(singleTonDemo.AfterDrainValidateBothInstanceHasSameVariables());

        }


    }
}
