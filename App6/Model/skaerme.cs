using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6.Model
{
    public class skaerme
    {
        public string mærke { get; set; }
        public string model { get; set; }
        public string farve { get; set; }
        public double pris { get; set; }
        public bool original { get; set; }

        public override string ToString()
        {
            return "Mærke: " + mærke + " " + "Model: " + model + " " +  "Farve: " + farve + " " + "Pris: " + pris + " " + "Er varen orginal? " + original;
        }

    }
}
