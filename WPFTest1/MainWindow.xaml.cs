using System;
using System.Collections.Generic;
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

namespace WPFTest1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Group _group;

        public Group group
        {
            get { return _group; }
            set
            {
                _group = value;
                OnPropertyChanged("groupchange");
            }
        }


        public MainWindow()
        {
            InitializeComponent();

            group = new Group();

            //group = group;
            //this.PropertyChanged += new PropertyChangedEventHandler(VM_propertychanged);
            group.PropertyChanged += new PropertyChangedEventHandler(VM_propertychanged);
            this.DataContext = this;
        }

        private void VM_propertychanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("ViewModelChanged");
            this.DataContext = this;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }

    public class Group : INotifyPropertyChanged
    {
        public int id { get; set; }
        //public List<Element> elements { get; set; }
        private string _val;

        public string Val
        {
            get { return _val; }
            set
            {
                _val = value;
                OnPropertyChanged("Val");

            }
        }
        private bool _sb;

        public bool somebool
        {
            get { return _sb; }
            set
            {
                _sb = value;
                if (value)
                {
                    Rad1 = true;
                    Rad2 = false;
                    Rad3 = false;
                }
                else
                {
                    Rad1 = false;
                    Rad2 = true;
                    Rad3 = false;
                }
                OnPropertyChanged("somebool");
            }
        }

        private bool _rad1;

        public bool Rad1
        {
            get { return _rad1; }
            set { _rad1 = value; OnPropertyChanged("Rad1"); }
        }

        private bool _rad2;

        public bool Rad2
        {
            get { return _rad2; }
            set { _rad2 = value; OnPropertyChanged("Rad2"); }
        }

        private bool _rad3;

        public bool Rad3
        {
            get { return _rad3; }
            set { _rad3 = value; OnPropertyChanged("Rad3"); }
        }



        private List<Element> _elements;

        public List<Element> elements
        {
            get { return _elements; }
            set
            {
                _elements = value;
                OnPropertyChanged("elements");

                foreach (Element elm in this.elements)
                {
                    elm.PropertyChanged += new PropertyChangedEventHandler(Elem_PropertyChanged);
                }
            }
        }

        private void Elem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("Element");
        }

        public Group()
        {
            id = Randomizer.Nombre();
            Val = Randomizer.Chaine(3);
            somebool = true;
            if (elements == null)
            {
                elements = new List<Element>();
            }
            for (int i = 1; i < Randomizer.Nombre(5) + 2; i++)
            {
                elements.Add(new Element(true));
                elements[i - 1].PropertyChanged += new PropertyChangedEventHandler(Elem_PropertyChanged);
            }


        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

    }

    public class Element : INotifyPropertyChanged
    {
        public int id { get; set; }
        public int Val1 { get; set; }
        public string Val2 { get; set; }
        public string Val3 { get; set; }

        private bool _Bool1;

        public bool Bool1
        {
            get { return _Bool1; }
            set
            {
                _Bool1 = value;

                SubElements.ForEach(x => x.Bool1 = value);
                SubElementsX.ForEach(x => x.Bool1 = value);

                OnPropertyChanged("Bool1");
            }
        }


        private List<SubElement> _subElements;

        public List<SubElement> SubElements
        {
            get { return _subElements; }
            set
            {
                _subElements = value;
                OnPropertyChanged("SubElements");
                foreach (SubElement se in this.SubElements)
                {

                    //se.PropertyChanged += new PropertyChangedEventHandler(SubElem_PropertyChanged);

                }
            }
        }

        private List<SubElementX> _subElementsX;

        public List<SubElementX> SubElementsX
        {
            get { return _subElementsX; }
            set
            {
                _subElementsX = value;
                OnPropertyChanged("SubElementsX");
                foreach (SubElementX se in this.SubElementsX)
                {

                    //se.PropertyChanged += new PropertyChangedEventHandler(SubElemX_PropertyChanged);

                }
            }
        }

        private List<SubElementY> _subY;

        public List<SubElementY> CACs
        {
            get { return _subY; }
            set
            {
                _subY = value;
                OnPropertyChanged("CACs");
                foreach (SubElementY se in this.CACs)
                {
                    se.PropertyChanged += new PropertyChangedEventHandler(CAC_PropertyChanged);
                }
            }
        }



        private List<SubElementZ> _subZ;

        public List<SubElementZ> EtatsLecture
        {
            get { return _subZ; }
            set
            {
                _subZ = value;
                OnPropertyChanged("EtatsLecture");
                foreach (SubElementZ se in this.EtatsLecture)
                {
                    se.PropertyChanged += new PropertyChangedEventHandler(EtatLecture_PropertyChanged);
                }
            }
        }

        private void SubElem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SubElements.ForEach(x => x.SuspendPropertyChange = true);

            SubElementsX.ForEach(x => x.Bool1 = ((SubElement)sender).Bool1);


            //SubElementsX.ForEach(x => x.Bool1 = !x.Bool1);
            //SubElementsX.ForEach(x => x.Val2 = x.Val2 + ".");
            //SubElementsX.ForEach(x => x.SuspendPropertyChange = false);
            //SubElementsX.First().SuspendPropertyChange = false;
            SubElements.ForEach(x => x.SuspendPropertyChange = false);


            OnPropertyChanged("SubElements");
        }
        private void SubElemX_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            SubElementsX.ForEach(x => x.SuspendPropertyChange = true);


            SubElements.ForEach(x => x.Bool1 = ((SubElementX)sender).Bool1);

            //SubElements.ForEach(x => x.Bool1 = !x.Bool1);
            //SubElements.ForEach(x => x.NeutralBool = !x.NeutralBool);
            //SubElements.ForEach(x => x.Val2 = x.Val2 + ".");

            //SubElements.ForEach(x => x.Rad1 = true);
            //SubElements.ForEach(x => x.Rad2 = false);
            //SubElements.ForEach(x => x.Rad3 = false);


            SubElementsX.ForEach(x => x.SuspendPropertyChange = false);
            //SubElements.First().Val2 = "ooo";
            //SubElements.First().OnPropertyChanged("SubElement");

            //Permet de remonter le propertychanged
            //OnPropertyChanged("SubElementsX");
            //OnPropertyChanged("SubElementsX");
            //OnPropertyChanged("Element");
            //OnPropertyChanged("SubElement");
            //OnPropertyChanged("SubElementsX");
        }

        /// <summary>
        /// CAC = 1
        /// Etat lecture = 2
        /// </summary>
        private int caller = 0;
        private int num = 0;

        //private bool exit = false;
        //cb - CAC
        private void CAC_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            if (EtatsLecture[0].SuspendPing == false)
            {
                CACs.ForEach(x => x.SuspendPropertyChange = true);
                EtatsLecture.ForEach(x => x.SuspendPropertyChange = true);

                List<SubElementZ> subElementZs = EtatsLecture.Where(x => x.EstSelectionne == true).ToList();
                EtatsLecture.ForEach(x => x.EstSelectionne = false);
                EtatsLecture.First(x => x.num == ((SubElementY)sender).num).EstSelectionne = true;

                CACs.ForEach(x => x.SuspendPropertyChange = false);
                EtatsLecture.ForEach(x => x.SuspendPropertyChange = false);

                triggerStuff();

            }

        }

        private void triggerStuff()
        {
            EtatsLecture.ForEach(x => x.SuspendPing = true);
            CACs.ForEach(x => x.SuspendPing = true);

            EtatsLecture.ForEach(x => x.EstSelectionne = x.EstSelectionne);
            CACs.ForEach(x => x.EstSelectionne = x.EstSelectionne);

            EtatsLecture.ForEach(x => x.SuspendPing = false);
            CACs.ForEach(x => x.SuspendPing = false);
        }

        //radio - EtatLecture
        private void EtatLecture_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //pcc
            if (CACs[0].SuspendPing == false && ((SubElementZ)sender).EstSelectionne == true)
            {
                CACs.ForEach(x => x.SuspendPropertyChange = true);

                CACs.ForEach(x => x.EstSelectionne = false);
                CACs.First(x => x.num == ((SubElementZ)sender).num).EstSelectionne = true;

                CACs.ForEach(x => x.SuspendPropertyChange = false);

                triggerStuff();
            }
        }

        public Element()
        {

        }

        public Element(bool a)
        {
            id = Randomizer.Nombre();
            Val1 = Randomizer.Nombre();
            Val2 = "Elem " + Randomizer.Chaine(2);
            Val3 = "Elem " + Randomizer.Chaine(2);
            if (SubElements == null)
            {
                SubElements = new List<SubElement>();
            }
            if (SubElementsX == null)
            {
                SubElementsX = new List<SubElementX>();
            }

            for (int i = 1; i < Randomizer.Nombre(4) + 2; i++)
            {
                SubElements.Add(new SubElement(true));
                SubElements[i - 1].PropertyChanged += new PropertyChangedEventHandler(SubElem_PropertyChanged);

                SubElementsX.Add(new SubElementX(true));
                SubElementsX[i - 1].PropertyChanged += new PropertyChangedEventHandler(SubElemX_PropertyChanged);

            }

            CACs = new List<SubElementY>();
            CACs.Add(new SubElementY(1));
            CACs.Add(new SubElementY(2));
            CACs.Add(new SubElementY(3));

            CACs = CACs;

            EtatsLecture = new List<SubElementZ>();
            EtatsLecture.Add(new SubElementZ(1));
            EtatsLecture.Add(new SubElementZ(2));
            EtatsLecture.Add(new SubElementZ(3));
            EtatsLecture = EtatsLecture;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }

    public class SubElement : INotifyPropertyChanged
    {
        public int id { get; set; }
        public int Val1 { get; set; }
        private string _val2;

        public string Val2
        {
            get { return _val2; }
            set
            {
                _val2 = value;
                OnPropertyChanged("Val2");
            }
        }

        public string Val3 { get; set; }

        public bool SuspendPropertyChange { get; set; }

        private bool _Bool1;

        public bool Bool1
        {
            get { return _Bool1; }
            set
            {
                _Bool1 = value;
                OnPropertyChanged("Bool1");
            }
        }

        private bool _rad1;

        public bool Rad1
        {
            get { return _rad1; }
            set { _rad1 = value; OnPropertyChanged("Rad1"); }
        }

        private bool _rad2;

        public bool Rad2
        {
            get { return _rad2; }
            set { _rad2 = value; OnPropertyChanged("Rad2"); }
        }

        private bool _rad3;

        public bool Rad3
        {
            get { return _rad3; }
            set { _rad3 = value; OnPropertyChanged("Rad3"); }
        }

        private bool _NeutralBool;

        public bool NeutralBool
        {
            get { return _NeutralBool; }
            set
            {
                _NeutralBool = value;
                OnPropertyChanged("NeutralBool");
            }
        }


        public SubElement(bool a)
        {
            id = Randomizer.Nombre();
            NeutralBool = false;
            Bool1 = false;
            Val1 = Randomizer.Nombre();
            Val2 = "SubElem " + Randomizer.Chaine(2);
            Val3 = "SubElem " + Randomizer.Chaine(2);
        }

        public virtual void OnPropertyChanged(string propertyName)
        {
            if (!SuspendPropertyChange)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }


    public class SubElementX : INotifyPropertyChanged
    {
        public int id { get; set; }
        public int Val1 { get; set; }
        private string _val2;

        public string Val2
        {
            get { return _val2; }
            set
            {
                _val2 = value;
                OnPropertyChanged("Val2");
            }
        }
        public bool SuspendPropertyChange { get; set; }

        private bool _Bool1;

        public bool Bool1
        {
            get { return _Bool1; }
            set
            {
                _Bool1 = value;
                OnPropertyChanged("Bool1");
            }
        }

        private bool _rad1;

        public bool Rad1
        {
            get { return _rad1; }
            set { _rad1 = value; OnPropertyChanged("Rad1"); }
        }

        private bool _rad2;

        public bool Rad2
        {
            get { return _rad2; }
            set { _rad2 = value; OnPropertyChanged("Rad2"); }
        }

        private bool _rad3;

        public bool Rad3
        {
            get { return _rad3; }
            set { _rad3 = value; OnPropertyChanged("Rad3"); }
        }
        public SubElementX(bool a)
        {
            id = Randomizer.Nombre();
            Bool1 = false;
            Val1 = Randomizer.Nombre();
            Val2 = "SubElemX " + Randomizer.Chaine(2);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (!SuspendPropertyChange)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }

    public class SubElementY : INotifyPropertyChanged
    {
        private string _val2;

        public string Name
        {
            get { return _val2; }
            set
            {
                _val2 = value;
                OnPropertyChanged("Name");
            }
        }
        public bool SuspendPropertyChange { get; set; }
        public bool SuspendPing { get; set; }

        private bool _EstSelectionne;

        public bool EstSelectionne
        {
            get { return _EstSelectionne; }
            set
            {
                _EstSelectionne = value;
                OnPropertyChanged("EstSelectionne");
            }
        }
        public bool UpOnce { get; set; }
        public int num { get; set; }
        public SubElementY(int a)
        {
            EstSelectionne = false;
            Name = "SubElementY " + Randomizer.Chaine(2);
            num = a;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {

            if (!SuspendPropertyChange)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }

        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }

    public class SubElementZ : INotifyPropertyChanged
    {
        private string _val2;

        public string Name
        {
            get { return _val2; }
            set
            {
                _val2 = value;
                OnPropertyChanged("Name");
            }
        }
        public bool SuspendPropertyChange { get; set; }
        public bool SuspendPing { get; set; }

        private bool _EstSelectionne;

        public bool EstSelectionne
        {
            get { return _EstSelectionne; }
            set
            {
                _EstSelectionne = value;
                OnPropertyChanged("EstSelectionne");
            }
        }

        public bool UpOnce { get; set; }
        public int num { get; set; }


        public SubElementZ(int a)
        {
            EstSelectionne = false;
            num = a;
            Name = "SubElementZ " + Randomizer.Chaine(2);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (!SuspendPropertyChange)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }


    public class Randomizer
    {
        private static Random rand { get; set; }
        private static List<string> ls;

        static Randomizer()
        {
            rand = new Random();
            ls = new List<string>
                {
                    "a","ac","accumsan","adipiscing","Aenean","aliquam","aliquet","amet","ante","arcu","at",
                    "auctor","augue","bibendum","blandit","commodo","condimentum","congue","consectetur",
                    "consequat","convallis","Cras","Cum","Curabitur","cursus","dapibus","diam","dictum",
                    "dignissim","dis","dolor","Donec","dui","Duis","egestas","eget","eleifend","elementum",
                    "elit","enim","erat","eros","est","et","Etiam","eu","euismod","facilisis","fames","faucibus",
                    "felis","fermentum","feugiat","fringilla","Fusce","gravida","habitant","hendrerit","iaculis",
                    "id","imperdiet","in","Integer","interdum","ipsum","justo","lacinia","lacus","laoreet",
                    "lectus","leo","libero","ligula","lobortis","lorem","luctus","Maecenas","magna","magnis",
                    "malesuada","massa","mattis","Mauris","metus","mi","molestie","mollis","montes","morbi",
                    "mus","Nam","nascetur","natoque","nec","neque","netus","nibh","nisi","nisl","non","nulla",
                    "Nullam","nunc","odio","orci","ornare","parturient","pellentesque","penatibus","pharetra",
                    "Phasellus","placerat","porta","porttitor","posuere","Praesent","pretium","Proin","pulvinar",
                    "purus","quam","quis","Quisque","rhoncus","ridiculus","risus","rutrum","sagittis","sapien",
                    "scelerisque","sed","sem","semper","senectus","sit","sociis","sodales","sollicitudin",
                    "suscipit","Suspendisse","tellus","tempor","tempus","tincidunt","tortor","tristique",
                    "turpis","ullamcorper","ultrices","ultricies","urna","ut","varius","vehicula","vel","velit",
                    "venenatis","vestibulum","vitae","Vivamus","viverra","volutpat","vulputate"
                };



        }

        public static string Chaine(int i)
        {
            string output = "";
            for (int j = i - 1; j >= 0; j--)
            {
                output += " " + ls[rand.Next(ls.Count)];
            }
            return output;
        }

        public static int Nombre()
        { return rand.Next(1000); }

        public static int Nombre(int i)
        { return rand.Next(i); }

        public static int Nombre(int i, int j)
        { return rand.Next(Math.Abs(j - i)) + Math.Min(i, j); }


        public static bool Booleen()
        {
            return (rand.Next(10) >= 5);
        }

        public static DateTime DateFuture()
        {
            return DateTime.Now.AddDays(rand.Next(100));
        }
        public static DateTime DatePassee()
        {
            return DateTime.Now.AddDays(rand.Next(100) - 100);
        }



    }
}
