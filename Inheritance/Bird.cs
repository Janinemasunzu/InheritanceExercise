using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string WingColor { get; set; }
        public bool HasFeathers { get; set; }
        public int wings { get; set; }
        public bool LayEggs { get; set; }

        
       public Bird() { }
    }
}
