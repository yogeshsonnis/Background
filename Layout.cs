using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.Model
{
  public  class Layout :BaseHandlerClass
    {
        private string elements;

        public string Elements
        {
            get { return elements; }
            set { elements = value; NotifyPropertyChanged("Elements");}
        }
       
        
        private string openviewwith;

        public string Openviewwith
        {
            get { return openviewwith; }
            set { openviewwith = value; NotifyPropertyChanged("Openviewwith");}
        }



    }
}
