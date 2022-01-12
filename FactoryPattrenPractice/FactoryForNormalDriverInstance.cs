using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
  public class FactoryForNormalDriverInstance : FactoryInterface
    {
        public NormalInterface CraeteInstance(string requiredDriverType)
        {
            switch (requiredDriverType)
            {
                case "Chrome":
                    return new ChromeDriver();

                case "IE":
                    return new IEDriver();
                default:
                    throw new Exception("The required driver type is not implemented, please implement the driver first");
            }
        }
    }
}
