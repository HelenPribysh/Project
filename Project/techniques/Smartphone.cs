using System;
using System.Collections.Generic;
using System.Text;
using Project.enums;

namespace Project.techniques
{
    class Smartphone : Technique
    {
        public Smartphone(string model, int quantity) : base(model, quantity)
        {
            type = TechniqueType.SMARTPHONE;
        }

        public Smartphone(string model) : base(model)
        {
            type = TechniqueType.SMARTPHONE;
        }
    }
}
