using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }  
        public bool HasScalySkin { get; set; }
        public string Habitat { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasLungs { get; set; }
    }
    
}
