using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace App6.Model
{
    public class skaermliste : ObservableCollection<skaerme>
    {
        public skaermliste()
            : base()
        {
            this.Add(new skaerme() { mærke = "Iphone", model = "5", farve = "sort", pris = 49.95, original = false});
            this.Add(new skaerme() { mærke = "Samsung", model = "s4", farve = "hvid", pris = 69.95, original = false });
        }


    }
}
