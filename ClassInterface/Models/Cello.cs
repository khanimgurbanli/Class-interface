using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterface.Models
{
    public class Cello : Instrument
    {
        private double _hight;
        private double _pinHight;

        public Cello() { }
        public Cello(string name, string model,
                          string brand, double cost,
                          string category,  string history, double hight, double pinHight) : base(name, model, brand, cost,
                                                                                     category, history)
        {
            Hight = hight;
            PinHight = pinHight;
        }


        public double Hight
        {
            get { return _hight; }
            set { _hight = value; }
        }
        public double PinHight
        {
            get { return _pinHight; }
            set { _pinHight = value; }
        }

        public override string Sound()
        {
            return @" The cello produces a deep, rich, and vibrant sound";
        }

    }
}
