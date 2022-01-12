using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
   public class SecureChromeDriver : NormalInterface
    {
        public void CreateInstance()
        {
            Console.WriteLine("craeting Secure Chrome driver instance");

        }
    }
}
