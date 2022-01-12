using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
   public class BaseClass
    {
       public  FactoryInterface myDriverFactory;
      public BaseClass(FactoryInterface f)
        {
            this.myDriverFactory = f;
        }
        public void CreateRequiredFactoryInstance(string requiredDriverType)
        {
            switch (requiredDriverType)
            {
                case "Chrome":
                    myDriverFactory.CraeteInstance("Chrome");
                    break;
                case "IE":
                    myDriverFactory.CraeteInstance("IE");
                    break;
            }
        }
    }
}
