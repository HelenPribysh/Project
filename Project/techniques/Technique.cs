using Project.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.techniques
{
    class Technique
    {
        protected TechniqueType type;
        protected string serialNumber;
        protected string _model;
        protected int _quantity;

        public Technique(string model, int quantity)
        {
            _model = model;
            _quantity = quantity;
        }

        public Technique(string model)
        {
            _model = model;
            _quantity = 1;
        }

        internal int Quantity { get => _quantity; set => _quantity = value; }
        internal string SerialNumber { get => serialNumber; set => serialNumber = value; }
        internal string Model { get => _model; set => _model = value; }
        internal TechniqueType Type { get => type; set => type = value; }
    }
}
