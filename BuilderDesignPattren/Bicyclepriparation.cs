using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattren
{
    class Bicyclepriparation
    {
        private string gears;

        private string stands;

        private string doubleSeats;

        private Bicyclepriparation(Builder builder)
        {
            this.gears = builder.gears;
            this.stands = builder.stands;
            this.doubleSeats = builder.doubleSeats;
        }

        public  class Builder
        {
            public string gears;

            public string stands;

            public string doubleSeats;

            public Builder SetGears(string gears)
            {
                this.gears = gears;
                return this;
            }

            public Builder SetStands(string stands)
            {
                this.stands = stands;
                return this;
            }

            public Builder SetDoubleSeats(string doubleSeats)
            {
                this.doubleSeats = doubleSeats;
                return this;
            }

            public Bicyclepriparation build()
            {
                return new Bicyclepriparation(this);
            }


        }

    }
}
