using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattrensPractice.SingleTonPattrenPractice
{
    public class SingleTonPracticeDemo
    {
		public CandyMaker c1;
		public CandyMaker c2;

        public SingleTonPracticeDemo()
        {
			c1 = CandyMaker.GetInstanceOfCandyMaker();
			c2 = CandyMaker.GetInstanceOfCandyMaker();
		}
		public bool CreateReferenceAndValidateBothArePointingToSame()
        {
			return c1.Equals(c2);
		}

		public bool AfterFillWithFirstInstanceValidatingIsFillVariableWithOtherInstance()
        {
			c1.fill();
			return c1.isEmpty().Equals(c2.isEmpty());
        }

        public static void main(string[] args)
        {
            SingleTonPracticeDemo singleTonPracticeDemo = new SingleTonPracticeDemo();
            if (singleTonPracticeDemo.CreateReferenceAndValidateBothArePointingToSame())
            {
                Console.WriteLine("Both references are pointing to same object instances where first instance is " + singleTonPracticeDemo.c1 + " and second is " + singleTonPracticeDemo.c2);
            }

            if (singleTonPracticeDemo.AfterFillWithFirstInstanceValidatingIsFillVariableWithOtherInstance())
            {

            }
        }
    }

}
