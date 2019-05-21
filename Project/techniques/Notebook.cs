using Project.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.techniques
{
    class Notebook : Technique
    {        
        public Notebook(string model, int quantity) : base (model, quantity)
        {
            type = TechniqueType.NOTEBOOK;
        }

        public Notebook(string model) : base(model)
        {
            type = TechniqueType.NOTEBOOK;
        }
    }
}
