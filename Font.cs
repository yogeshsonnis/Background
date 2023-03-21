using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.Model
{
   public class Font:BaseHandlerClass
    {
        private string items;

        public string Items
        {
            get { return items; }
            set { items = value; NotifyPropertyChanged("Items"); }
        }

        
    }
}
