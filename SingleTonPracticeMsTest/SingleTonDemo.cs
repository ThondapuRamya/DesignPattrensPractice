using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTonPracticeMsTest
{
    class SingleTonDemo
    {
		public CandyMaker c1;
		public CandyMaker c2;

		public SingleTonDemo()
		{
			c1 = CandyMaker.GetInstanceOfCandyMaker();
			c2 = CandyMaker.GetInstanceOfCandyMaker();
		}
		public bool CreateReferenceAndValidateBothArePointingToSame()
		{
			Console.WriteLine("First instance is "+c1);
			Console.WriteLine("Second Instance is "+c2);
			return c1.Equals(c2);
		}

		public bool AfterFillValidateBothInstanceHasSameVariables()
		{
			c1.fill();
			return c1.isEmpty().Equals(c2.isEmpty());
		}

		public bool AfterBoilValidateBothInstanceHasSameVariables()
		{
			c2.boil();
			return c1.isEmpty().Equals(c2.isEmpty())&& c1.isBoiled().Equals(c2.isBoiled());
		}

		public bool AfterDrainValidateBothInstanceHasSameVariables()
		{
			c2.drain();
			return c1.isEmpty().Equals(c2.isEmpty()) && c1.isBoiled().Equals(c2.isBoiled());
		}

	}
}
