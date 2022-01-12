using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
   public class SecureIEDriver : NormalInterface
    {
        public void CreateInstance()
        {
            Console.WriteLine("craeting Secure IE driver instance");

        }
    }
}
