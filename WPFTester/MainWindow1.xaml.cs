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
using System.Windows.Shapes;
using WPFTester.ViewModel;

namespace WPFTester
{
    /// <summary>
    /// Logique d'interaction pour MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            DataContext = new MainViewModel();
            InitializeComponent();
        }
    }
}
