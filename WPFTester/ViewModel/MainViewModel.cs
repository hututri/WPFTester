using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTester.Model;

namespace WPFTester.ViewModel
{
    public class MainViewModel
    {
        public List<object> Elements { get; set; }
        public ObservableCollection<BacItem> BacItems { get; set; }

        public MainViewModel()
        {
            Elements = new List<object>();
            Elements.Add(new Square());
            Elements.Add(new Square());
            Elements.Add(new Square());


            BacItems = new ObservableCollection<BacItem>();
            BacItems.Add(new BacItem(1, "a", "descA"));
            BacItems.Add(new BacItem(2, "b", "descB"));
            BacItems.Add(new BacItem(3, "c", "descC"));
        }
    }

    public class BacItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //private int num;
        //private string nom;
        //private string desc;

        private int _num;

        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }

        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }



        public BacItem()
        {
            this.Num = 0;
            this.Nom = "a";
            this.Desc = "lorem ipsum";
        }

        public BacItem(int i, string nom, string desc)
        {
            this.Num = i;
            this.Nom = nom;
            this.Desc = desc;
        }

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
