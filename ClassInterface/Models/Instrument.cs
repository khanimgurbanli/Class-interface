using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterface.Models
{
    public abstract class Instrument
    {
        private string _name;
        private string _model;
        private string _brand;
        private double _cost;
        private string _category;
        private string _history;

        public Instrument() { }
        public Instrument(string name, string model, 
                          string brand, double cost, 
                          string category,string history) 
        {
            Name = name;
            Model = model;
            Brand = brand;
            Cost = cost;
            Category = category;
            History = history;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string History
        {
            get { return _history; }
            set { _history = value; }
        }
        public abstract string Sound();
    }
}
