using CustomiseProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseProject.ViewModel
{
   public class LayoutVM:BaseHandlerClass
    {
        ObservableCollection<Layout> layoutSelectView;

        public ObservableCollection<Layout> LayoutSelectView

        {
            get { return layoutSelectView; }

            set { layoutSelectView = value; NotifyPropertyChanged("LayoutSelectView"); }

        }

        public RelayCommand DefaultCommand { get; set; }
        public RelayCommand LastSavedCommand { get; set; }

        public LayoutVM()
        {
            LoadLayoutSelectView();
            DefaultCommand = new RelayCommand(OnDefaultButtonClick);
            LastSavedCommand = new RelayCommand(OnLastSavedButtonClick);
        }

        private void LoadLayoutSelectView()
        {
            LayoutSelectView = new ObservableCollection<Layout>();
            LayoutSelectView.Add(new Layout {Elements="Market Movement"});
            LayoutSelectView.Add(new Layout {Elements="Market SnapShot"});

        }

        private void OnLastSavedButtonClick()
        {
        
        }

        private void OnDefaultButtonClick()
        {
          
        }

        private Color selectedelements;

        public Color Selectedelements
        {
            get { return selectedelements; }
            set
            {
                selectedelements = value;


                NotifyPropertyChanged("Selectedelements");
            }
        }

        private string openviewwith;

        public string Openviewwith
        {
            get { return openviewwith; }
            set
            {
                openviewwith = value;


                NotifyPropertyChanged("Openviewwith");
            }

        }
    }
}
