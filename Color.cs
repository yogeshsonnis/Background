using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.Model
{
  public  class Color : BaseHandlerClass
    {
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; NotifyPropertyChanged("ItemName"); }
        }

         private string selectcolor;

        public string Selectcolor
        {
            get { return selectcolor; }
            set { selectcolor = value; NotifyPropertyChanged("Selectcolor"); }
        }

        private string colorbox;

        public string Colorbox
        {
            get { return colorbox; }
            set { colorbox = value; NotifyPropertyChanged("Colorbox"); }
        }

        private string preview;

        public string Preview
        {
            get { return preview; }
            set { preview = value; NotifyPropertyChanged("Preview"); }
        }

        private string vItemName;

        public string VItemName
        {
            get { return vItemName; }
            set { vItemName = value; NotifyPropertyChanged("VItemName"); }
        }
    }
}
