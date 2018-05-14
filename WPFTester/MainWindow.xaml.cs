using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WPFTester.ViewModel;

namespace WPFTester
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //CollectionViewSource listingDataView;
        //ObservableCollection<BacItem> items = new ObservableCollection<BacItem>();

        public MainWindow()
        {
            //DataContext = this;//new MainViewModel();
            DataContext = new MainViewModel();
            InitializeComponent();
            //listingDataView = (CollectionViewSource)(this.Resources["listingDataView"]);
            //loadData();

            //Master.DataContext = BacItems;
            //int oo = lbCC.Items.Count;
            //items.Add(new BacItem(0,"a","x"));
            //items.Add(new BacItem(1,"b","y"));
            //items.Add(new BacItem(2,"c","z"));
            //int ooa = lbDD.Items.Count;

        }

        //public int ResourceData
        //{
        //    get;set;
        //}

        /*public ObservableCollection<BacItem> BacItems{get;set;}

        private void loadData()
        {
            BacItems = new ObservableCollection<BacItem>();
            BacItems.Add(new BacItem(1,"a","descA"));
            BacItems.Add(new BacItem(2,"b","descB"));
            BacItems.Add(new BacItem(3,"c","descC"));
        }*/
    }

 
}
