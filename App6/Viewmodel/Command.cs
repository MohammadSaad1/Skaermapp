using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App6.Viewmodel
{
  public  class Command : ICommand
    {
        private Action methodToExecute = null;
        private Func<bool>
            methodToDetectCanExecute = null;

        public Command(Action execute)
        {
            this.methodToExecute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ; methodToExecute();
        }
    }


}
