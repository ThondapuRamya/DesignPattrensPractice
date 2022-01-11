using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTonPracticeMsTest
{
    public class CandyMaker
    {
        public static CandyMaker candyMakerInstance = null;
        private Boolean empty;
        private Boolean boiled;
        private static object syncRoot = new Object();

        //Get Instance for CandyMaker 
        public static CandyMaker GetInstanceOfCandyMaker()
        {
            if (candyMakerInstance == null)
            {
                lock (syncRoot)
                {
                    if (candyMakerInstance == null)
                    {
                        candyMakerInstance = new CandyMaker();
                    }
                }
            }
            return candyMakerInstance;
        }


        //This code is only started when the boiler is empty
        private CandyMaker()
        {
            empty = true;
            boiled = false;
        }

        //to fill the boiler it must be empty, and once its full, 
        //we set the empty and boiled flags 
        public void fill()
        {
            if (isEmpty())
            {
                Console.WriteLine("fill the candyMaker with milk and choclate mix");
                empty = false;
                boiled = false;

                // fill the candyMaker with milk and choclate mix
            }
        }

        //To drain the boiler, it must be full(non-empty) and also boiled.
        //once it is drained, we set the empty back to true 
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                Console.WriteLine("drain the boiled milk and chocolate");
                // drain the boiled milk and chocolate
                empty = true;
            }
        }

        //to boil the mixture the boiler has to be full and not already boiled.  
        //once its boiled we set the boiled flag to true
        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                Console.WriteLine("bring the content to boil");
                // bring the content to boil
                boiled = true;
            }
        }

        public Boolean isEmpty()
        {
            return empty;
        }

        public Boolean isBoiled()
        {
            return boiled;
        }
    }
}
