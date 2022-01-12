using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
   public interface FactoryInterface
    {
        public NormalInterface CraeteInstance(string requiredDriverType);
    }
}
