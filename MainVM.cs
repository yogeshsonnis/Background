using CustomiseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.ViewModel
{
   public class MainVM :BaseHandlerClass
    {
        public RelayCommand OkCommand {get; set; }
        public RelayCommand ApplyCommand {get; set; }
        public RelayCommand CancelCommand {get; set; }
        public RelayCommand CloseCommand {get; set; }

        public MainVM()
        {
            OkCommand = new RelayCommand(OnOkButtonClick);
            ApplyCommand = new RelayCommand(OnApplyButtonClick);
            CancelCommand = new RelayCommand(OnCancelButtonClick);
            CloseCommand = new RelayCommand(OnCloseButtonClick);
        }

        private void OnCloseButtonClick()
        {
            
        }

        private void OnCancelButtonClick()
        {
          
        }

        private void OnApplyButtonClick()
        {
          
        }

        private void OnOkButtonClick()
        {
           
        }
    }
}
