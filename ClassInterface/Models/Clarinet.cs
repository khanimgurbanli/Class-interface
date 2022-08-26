using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterface.Models
{
    public class Clarinet : Instrument
    {
        private double _theLengthOfThePipe;

        private string _color;

        public Clarinet() { }
        public Clarinet( string name, string model,
                          string brand, double cost,
                          string category, string history, string color, double theLengthOfThePipe) : base(name, model, brand, cost,
                                                                                     category, history)
        {
            TheLengthOfThePipe = theLengthOfThePipe;
            Color = color;
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double TheLengthOfThePipe
        {
            get { return _theLengthOfThePipe; }
            set { _theLengthOfThePipe = value; }
        }
        public override string Sound()
        {
            return @"The voice of the clarinet sounds like that one of a laughing or crying person. 
                      The dominant articulation is hu - du - hu - hu - hu - dju - dju.
                In general the style is described as with soul, that is very emotional, by the artist and the audience.";
        }

    }
}
