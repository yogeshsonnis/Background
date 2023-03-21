using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.Model
{
  
        public class BaseHandlerClass : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;


            protected void NotifyPropertyChanged(string propertyName)
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }




        

    }
}
