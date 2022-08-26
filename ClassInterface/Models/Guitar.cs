using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterface.Models
{
    public class Guitar : Instrument
    {

        private string _plectrum;
        public Guitar() { }

        public Guitar(string name, string model,
                          string brand, double cost,
                          string category, string history,string plectrum) : base(name, model, brand, cost,
                                                                                     category, history)
            
        {
            Plectrum = plectrum;
        }
        public string Plectrum
        {
            get { return _plectrum; }
            set { _plectrum = value; }
        }
        
        public override string Sound()
        {
            return @"With an “open” guitar sound, the player’s choice of strings,
                      pickups and pedals can drastically alter the amplifier’s dynamic range.";
        }
    }
}
