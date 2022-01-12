using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattrenPractice
{
   public class ChromeDriver : NormalInterface
    {
        public void CreateInstance()
        {
            Console.WriteLine("Normal chrome driver instance will be created");
        }
    }
}
