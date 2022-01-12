using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
   public class IEDriver : NormalInterface
    {
        public void CreateInstance()
        {
            Console.WriteLine("Normal IE driver instance will be created");
        }
    }
}
