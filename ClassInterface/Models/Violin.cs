using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterface.Models
{
    public class Violin : Instrument
    {
        private string _maestro;
        public Violin() { }
        public Violin(string name, string model,
                          string brand, double cost,
                          string category, string history, string maestro) : base(name, model, brand, cost,
                                                                                     category, history)
        {
            Maestro = maestro;
        }

        public string Maestro
        {
            get { return _maestro; }
            set { _maestro = value; }
        }

        public override string Sound()
        {
            return @"The violin quivers like a tormented heart.";
        }

    }
}
