using CustomiseProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.ViewModel
{
    public class FontVM : BaseHandlerClass
    {
        ObservableCollection<Font> fontList;

        public ObservableCollection<Font> FontList

        {
            get { return fontList; }

            set { fontList = value; NotifyPropertyChanged("FontList"); }
        }

        public RelayCommand SelectFont { get; set; }
        public RelayCommand RestoreDefault { get; set; }
        public RelayCommand ApplytoAllViews { get; set; }

        public FontVM()
        {
            LoadFontList();
            SelectFont = new RelayCommand(OnSelectFontButtonClick);
            RestoreDefault = new RelayCommand(OnRestoreDefaultButtonClick);
            ApplytoAllViews = new RelayCommand(OnApplytoAllViews);
        }

        private void LoadFontList()
        {
            FontList = new ObservableCollection<Font>();
            FontList.Add(new Font { Items = "Manual Position" });
            FontList.Add(new Font { Items = "Manual Position View" });
        }

        private void OnApplytoAllViews()
        {

        }

        private void OnRestoreDefaultButtonClick()
        {

        }

        private void OnSelectFontButtonClick()
        {

        }
        private Font selecteditems;

        public Font Selecteditems
        {
            get { return selecteditems; }
            set
            {
                selecteditems = value;

                { VItems = Selecteditems.Items; }
                NotifyPropertyChanged("Selecteditems");
            }
        }

        private string vitems;

        public string VItems
        {
            get { return vitems; }
            set { vitems = value; NotifyPropertyChanged("VItems"); }
        }

    }
}
