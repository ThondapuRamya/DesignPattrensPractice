using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuilderDesignPattren
{
    [TestClass]
    public class BuilderPattrenDemoTest
    {
        [TestMethod]
        public void PripareBicycleWithAllFeatures()
        {

            Bicyclepriparation.Builder builder = new Bicyclepriparation.Builder().SetGears("Yes").SetStands("Yes").SetDoubleSeats("Yes");

            builder.build();
        }

        [TestMethod]
        public void PripareBicycleWithGears()
        {

            Bicyclepriparation.Builder builder = new Bicyclepriparation.Builder().SetGears("Yes").SetStands("No").SetDoubleSeats("No");

            builder.build();
        }
    }
}
