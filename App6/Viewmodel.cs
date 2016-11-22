using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using App6.Model;
namespace App6.Viewmodel
{
   public class Viewmodel : INotifyPropertyChanged
    {
        
        public AddskaermCommand Addskaermcommand { get; set; }
        public Model.skaermliste skaermliste { get; set; }

        /* public Viewmodel()
         {
             skaermliste = new Model.skaermliste();

         }
           */


        private skaerme selectedSkaerm;

        public skaerme SelectedSkaerm
        {
            get { return selectedSkaerm; }
            set { selectedSkaerm = value;
                OnPropertyChanged(nameof( SelectedSkaerm));
               
            }
            
        }

        public void Addskaerm()
        {
            skaermliste.Add(NewSkaerm);
        }

        public skaerme NewSkaerm { get; set; }
        public Viewmodel()
        {
            skaermliste = new skaermliste();
            selectedSkaerm = new skaerme();
            Addskaermcommand = new AddskaermCommand(Addskaerm);
            NewSkaerm = new skaerme();
          

        }





        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }

        }
    }
}
