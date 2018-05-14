using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShiet.Classes
{
    /// <summary>
    /// Struture récursive pour manipuler les résultats de vote
    /// </summary>
    public class Expressions
    {
        #region -------------- Propriétes ---------------
        public string IntituleZoneExpression { get; set; }

        private int _ExpressionsValables;

        public int ExpressionsValables
        {
            get
            {
                if (!Feuille)
                {
                    int output = 0;
                    foreach (Expressions exp in SousListe)
                    {
                        output += exp.ExpressionsValables;
                    };
                    return output;
                }
                else
                {
                    return _ExpressionsValables;
                }
            }
            private set { _ExpressionsValables = value; }
        }

        private int _ExpressionsBlanches;

        public int ExpressionsBlanches
        {
            get
            {
                if (!Feuille)
                {
                    int output = 0;
                    foreach (Expressions exp in SousListe)
                    {
                        output += exp.ExpressionsBlanches;
                    };
                    return output;
                }
                else
                {
                    return _ExpressionsBlanches;
                }
            }
            set { _ExpressionsBlanches = value; }
        }


        private int _ExpressionsNulles;

        public int ExpressionsNulles
        {
            get
            {
                if (!Feuille)
                {
                    int output = 0;
                    foreach (Expressions exp in SousListe)
                    {
                        output += exp.ExpressionsNulles;
                    };
                    return output;
                }
                else
                {
                    return _ExpressionsNulles;
                }
            }
            set { _ExpressionsNulles = value; }
        }

        private int _SuffragesValables;

        public int SuffragesValables
        {
            get
            {
                if (!Feuille)
                {
                    int output = 0;
                    foreach (Expressions exp in SousListe)
                    {
                        output += exp.SuffragesValables;
                    };
                    return output;
                }
                else
                {
                    return _SuffragesValables;
                }
            }
            set { _SuffragesValables = value; }
        }


        private int _SuffragesBlancs;

        public int SuffragesBlancs
        {
            get
            {
                if (!Feuille)
                {
                    int output = 0;
                    foreach (Expressions exp in SousListe)
                    {
                        output += exp.SuffragesBlancs;
                    };
                    return output;
                }
                else
                {
                    return _SuffragesBlancs;
                }
            }
            set { _SuffragesBlancs = value; }
        }

        private int _SuffragesNuls;

        public int SuffragesNuls
        {
            get
            {
                if (!Feuille)
                {
                    int output = 0;
                    foreach (Expressions exp in SousListe)
                    {
                        output += exp.SuffragesNuls;
                    };
                    return output;
                }
                else
                {
                    return _SuffragesNuls;
                }
            }
            set { _SuffragesNuls = value; }
        }


        public List<Expressions> SousListe { get; set; }

        public bool Afficher { get; set; }
        //Définit si c'est un élément final
        public bool Feuille { get; set; }
        #endregion

        #region ------------- Constructeurs -------------
        //public Expressions()
        //{
        //    SousListe = new List<Expressions>();
        //}

        public Expressions(string nom, int eValable, bool isFeuille)
        {
            ExpressionsValables = eValable;
            SetAllValues(eValable);
            Feuille = isFeuille;
            if (isFeuille)
            {
                SousListe = null;
            }
            else
            {
                SousListe = new List<Expressions>();
            }
            IntituleZoneExpression = nom;
        }

        public Expressions(string nom, bool isFeuille)
        {
            ExpressionsValables = 0;
            SetAllValues(0);
            Feuille = isFeuille;
            IntituleZoneExpression = nom;
            if (isFeuille)
            {
                SousListe = null;
            }
            else
            {
                SousListe = new List<Expressions>();
            }
        }

        public Expressions(string nom, int eValable)
        {
            ExpressionsValables = eValable;
            SetAllValues(eValable);
            Feuille = true;
            SousListe = null;
            IntituleZoneExpression = nom;
        }


        #endregion

        #region -------------- Méthodes -----------------

        public void AddNode()
        {
            if (!Feuille)
            {
                Expressions xp = new Expressions("Node", false);
                SousListe.Add(xp);
            }
        }

        public void AddLeaf(int i)
        {
            if (!Feuille)
            {
                Expressions xp = new Expressions("Leaf", i);
                SousListe.Add(xp);
            }

        }

        public void FillNodes()
        {
            foreach (Expressions xpr in SousListe)
            {
                if (!xpr.Feuille)
                {
                    xpr.AddLeaf(10);
                    xpr.FillNodes();
                }
            }
        }


        private void SetAllValues(int i)
        {
            ExpressionsBlanches = i;
            ExpressionsNulles = i;
            ExpressionsValables = i;
            SuffragesBlancs = i;
            SuffragesNuls = i;
            SuffragesValables = i;
        }
        #endregion

    }
}
