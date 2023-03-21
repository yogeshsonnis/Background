using CustomiseProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomiseProject.UserControls
{
    /// <summary>
    /// Interaction logic for ColorView.xaml
    /// </summary>
    public partial class ColorView : UserControl
    {
        public ColorView()
        {
            InitializeComponent();
            this.DataContext = new ColorVM();
        }
    }
}
