using CustomiseProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.ViewModel
{
    public class ColorVM : BaseHandlerClass
    {
        ObservableCollection<Color> colorSelectView;

        public ObservableCollection<Color> ColorSelectView

        {
            get { return colorSelectView; }

            set { colorSelectView = value; NotifyPropertyChanged("ColorSelectView"); }
        }

        ObservableCollection<Color> colorSelectAttributes;

        public ObservableCollection<Color> ColorSelectAtrributes

        {
            get { return colorSelectAttributes; }
            set { colorSelectAttributes = value; NotifyPropertyChanged("ColorSelectAttributes"); }
        }

        private ObservableCollection<string> selectColorFor;
        public ObservableCollection<string> SelectColorFor
        {
            get { return selectColorFor; }
            set { selectColorFor = value; NotifyPropertyChanged("SelectColorFor"); }
        }

        private ObservableCollection<string> colorlist;
        public ObservableCollection<string> Colorlist
        {
            get { return colorlist; }
            set { colorlist = value; NotifyPropertyChanged("Colorlist"); }
        }

        public RelayCommand ResetallAttributestoDefault { get; set; }

        public ColorVM()
        {
            LoadColorSelectView();
            LoadColorSelectAttributes();
            ResetallAttributestoDefault = new RelayCommand(OnResetallAttributestoDefault);
            LoadColorlist();
            LoadSelectColorFor();
        }

        private void LoadColorSelectView()
        {
            ColorSelectView = new ObservableCollection<Color>();
            ColorSelectView.Add(new Color { ItemName = "5 Day Report" });
            ColorSelectView.Add(new Color { ItemName = "Active Passive User List" });
            ColorSelectView.Add(new Color { ItemName = "Admin Message Log" });
            ColorSelectView.Add(new Color { ItemName = "Adv Filter Watch" });
            ColorSelectView.Add(new Color { ItemName = "Adv Tick Watch" });
            ColorSelectView.Add(new Color { ItemName = "Alerts Log Watch" });
            ColorSelectView.Add(new Color { ItemName = "Arbitrage Order Entry" });
            ColorSelectView.Add(new Color { ItemName = "Auction Market Status" });
            ColorSelectView.Add(new Color { ItemName = "Basket Trading" });
            ColorSelectView.Add(new Color { ItemName = "BestFive" });
            ColorSelectView.Add(new Color { ItemName = "BestFiveAndMktSeapShot" });
            ColorSelectView.Add(new Color { ItemName = "BracketOrderEntry" });
        }


        private void LoadColorSelectAttributes()
        {
            ColorSelectAtrributes = new ObservableCollection<Color>();

        }

        private void LoadSelectColorFor()
        {
            SelectColorFor = new ObservableCollection<string>();
            SelectColorFor.Add("Background");

        }

        private void LoadColorlist()
        {
            Colorlist = new ObservableCollection<string>();

        }

        private void OnResetallAttributestoDefault()
        {
           

        }

       
       
        private Color selecteddata;

        public Color Selecteddata
        {
            get { return selecteddata; }
            set
            {
                selecteddata = value;
                {  VItemName = Selecteddata.ItemName;}
                NotifyPropertyChanged("Selecteddata");
            }

        }


        private Color selectedinfo;

        public Color Selectedinfo
        {
            get { return selectedinfo; }
            set
            {
                selectedinfo = value;
                NotifyPropertyChanged("Selectedinfo");


            }
        }

        private string vItemName;

        public string VItemName
        {
            get { return vItemName; }
            set { vItemName = value; NotifyPropertyChanged("VItemName"); }
        }
      
    }

}
