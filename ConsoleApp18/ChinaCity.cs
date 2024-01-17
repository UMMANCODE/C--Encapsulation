using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18 {
    internal class ChinaCity: City {
        public override int Population { 
            set {
                if (value >= 100000) _population = value;
            } 
        }
    }
}
