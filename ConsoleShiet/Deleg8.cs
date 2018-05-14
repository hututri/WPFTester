using ConsoleShiet.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShiet
{// Declare delegate -- defines required signature:
    delegate double MathAction(double num);

    class DelegateTest
    {
        // Regular method that matches signature:
        static double Double(double input)
        {
            return input * 2;
        }

        static void Main()
        {
            // Instantiate delegate with named method:
            MathAction ma = Double;

            // Invoke delegate ma:
            double multByTwo = ma(4.5);
            Console.WriteLine("multByTwo: {0}", multByTwo);

            // Instantiate delegate with anonymous method:
            MathAction ma2 = delegate (double input)
            {
                return input * input;
            };

            double square = ma2(5);
            Console.WriteLine("square: {0}", square);

            // Instantiate delegate with lambda expression
            MathAction ma3 = s => s * s * s;
            double cube = ma3(4.375);

            Console.WriteLine("cube: {0}", cube);

            Console.WriteLine((MyEnum)2);
            Console.ReadKey(true);

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("INSERT INTO [dbo].[SESSION_LO]([URL],[NOM]) VALUES('" + Randomizer.Chaine(3) + "','" + Randomizer.Chaine(2) + "')");

            //}
            //Console.ReadKey(true);

            //for (int i = 0; i < 0; i++)
            //{
            //    Console.WriteLine("INSERT [dbo].[DATA_TRAITEMENT] ([LECTEUR_ID], [DATE], [NUM_CYCLE], [IDBLO], [IDEL], [IS_ENDOSSE], [IS_COMPTABILISE], [BAC_ID], [CONFIG_BULLETIN_LO_ID], [SESSION_LO_ID], [TYPE_TRAITEMENT_ID], [ETAT_LECTURE]) VALUES (" +
            //        Randomizer.Nombre(1, 1).ToString() + ", CAST(N'2018-04-20T16:04:29." +
            //        i.ToString("000") + "' AS DateTime), " +
            //        Randomizer.Nombre(20000).ToString() + ", N'" +
            //        Randomizer.Nombre(10000).ToString() + "', " +
            //        Randomizer.Nombre(500).ToString() + ", " +
            //        Randomizer.Nombre(3000).ToString() + ", " +
            //        Randomizer.Nombre(0, 2).ToString() + ", " +
            //        Randomizer.Nombre(1, 7).ToString() + ", " +
            //        Randomizer.Nombre(1, 3).ToString() + ", " +
            //        Randomizer.Nombre(1, 3).ToString() + ", " +
            //        Randomizer.Nombre(1, 3).ToString() + ", " +
            //        Randomizer.Nombre(1, 3).ToString() + ")");

            //}
            //Console.ReadKey(true);

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO[dbo].[RESULTAT_VALEUR]([NB_EXPRESSIONS],[NB_SUFFRAGES]) VALUES(" + Randomizer.Nombre(20000).ToString() + "," + Randomizer.Nombre(20000).ToString() + ")"
            //        );

            //}
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTATS_LO]([ID]) VALUES (" + i.ToString() + ")");
            //}

            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTAT_CONFIG_BULLETIN_LO] ([ID],[RESULTATS_LO_ID]) VALUES (" + i.ToString() + "," + Randomizer.Nombre(200).ToString() + ")");
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTAT_VALEUR_BLANCHE]([ID])VALUES(" + i.ToString() + ")"
            //        );
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTAT_VALEUR_Nulle]([ID])VALUES(" + i.ToString() + ")"
            //        );
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTAT_VALEUR_VALABLEMENT_EXPRIMEE]([ID])VALUES(" + i.ToString() + ")"
            //        );

            //}

            //       for (int i = 6; i < 20; i++)
            //       {
            //           Console.WriteLine(
            //               "INSERT INTO [dbo].[RESULTAT_ZONE_EXPRESSION_VOTE]([ID],[VALEUR_BLANCHE_ID],[VALEUR_NULLE_ID],[VALEUR_VALABLEMENT_EXPRIMEE_ID],[RESULTAT_CONFIG_BULLETIN_LO_ID])" +
            //"VALUES(" + i.ToString() + "," + Randomizer.Nombre(20).ToString() + "," +
            //Randomizer.Nombre(20).ToString() + "," +
            //Randomizer.Nombre(20).ToString() + "," + Randomizer.Nombre(7).ToString() + ")");

            //       }

            //       for (int i = 6; i < 20; i++)
            //       {
            //           Console.WriteLine(
            //               "INSERT INTO [dbo].[RESULTAT_ZONE_EXPRESSION_VOTE]([ID],[VALEUR_BLANCHE_ID],[VALEUR_NULLE_ID],[VALEUR_VALABLEMENT_EXPRIMEE_ID],[RESULTAT_CONFIG_BULLETIN_LO_ID])" +
            //"VALUES(" + i.ToString() + "," + i.ToString() + "," +
            // i.ToString() + "," + i.ToString() + "," + i.ToString() + ")");

            //       }

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTAT_ZONE_EXPRESSION_CAB]([ID])VALUES(" + Randomizer.Nombre(20).ToString() + ")"
            //        );

            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTAT_ZONE_EXPRESSION_CAC]([ID])VALUES(" + Randomizer.Nombre(20).ToString() + ")"
            //        );

            //}



            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTATS_LO]([ID])VALUES(" + Randomizer.Nombre(200).ToString() + ")"
            //        );

            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(
            //        "INSERT INTO [dbo].[RESULTAT_CONFIG_BULLETIN_LO]([ID],[RESULTATS_LO_ID])VALUES("+i.ToString()+","+
            //        Randomizer.Nombre(20).ToString() + ")");
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(
            //       "INSERT INTO [dbo].[CONFIG_BULLETIN_LO]([ID],[LIBELLE],[STATION_LECTURE_CAC_CONTROLE_ID],[REGLE_REMPLISSAGE],[CONFIG_LO_ID]) VALUES("+ i.ToString()+", '"+Randomizer.Chaine(2)+ "', " + Randomizer.Nombre(8) + ", " + Randomizer.Nombre(200) + ", " + Randomizer.Nombre(1,3) + ")"
            //       );
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(
            //       "insert into dbo.RESULTAT_VALEUR_POSSIBLE (ID, ID_COMMUN, RESULTAT_ZONE_EXPRESSION_VOTE_ID) values (" + i.ToString() + "," + Randomizer.Nombre(8) + ", " + Randomizer.Nombre(8) + ")"

            //       /*+ i.ToString() + ", '" + Randomizer.Chaine(2) + "', " + Randomizer.Nombre(8) + ", " + Randomizer.Nombre(200) + ", " + Randomizer.Nombre(1, 3) + ")"*/
            //       );
            //}

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(
                    "insert into dbo.CAC_POSSIBLE(ID, LIBELLE, COORDONNEE_X, COORDONNEE_Y, ZONE_EXPRESSION_CAC_ID) values(" + i.ToString() + ",'" + Randomizer.Chaine(1) + "', 7,7," + Randomizer.Nombre(1, 8) + ")");

            }

            //DoZones();

            Console.ReadKey(true);

        }
        // Output:
        // multByTwo: 9
        // square: 25
        // cube: 83.740234375 
        public enum MyEnum
        {
            a, b, c, d, e, f

        }

        private void DoZones()
        {
            List<Zone> lZone = new List<Zone>();

            for (int i = 0; i < 20; i++)
            {
                lZone.Add(new Zone());
            }



            int k = lZone.Count();

            //k = lZone.Select(x=>new { x = x.sv.A, y = x.sv2.A}).Sum()
        }

        private void TestExpressions()
        {
            Expressions myex = new Expressions("MyEx", false);
            //myex.SousListe.Add(new Expressions(50, true));
            //myex.SousListe.Add(new Expressions(2, false));
            //myex.SousListe.Add(new Expressions(10, true));

            myex.AddNode();
            myex.AddNode();
            myex.AddLeaf(10);
            myex.AddLeaf(10);
            myex.AddLeaf(10);

            Expressions xp1 = new Expressions("XP1", true);
            xp1.AddNode();
            xp1.AddLeaf(10);
            xp1.AddNode();
            xp1.AddLeaf(10);
            xp1.AddNode();
            xp1.AddLeaf(10);

            Expressions xp2 = new Expressions("XP2", false);
            xp2.AddNode();
            xp2.AddLeaf(10);
            xp2.AddNode();
            xp2.AddLeaf(10);
            xp2.AddNode();
            xp2.AddLeaf(10);


            myex.SousListe.Add(xp1);
            myex.SousListe.Add(xp2);

            myex.FillNodes();

            Debug.WriteLine(myex.ExpressionsValables.ToString());

        }




        private void TraiterDecompte()
        {
            //----------------aplatir penemuel
            //List<ResultatZoneExpressionModel> lmo = new List<ResultatZoneExpressionModel>();
            //lmo.Add(new ResultatZoneExpressionModel("cgf1", "zex1"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf1", "zex1"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf1", "zex2"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf1", "zex2"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf1", "zex3"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf1", "zex3"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf1", "zex3"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf2", "zex1"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf2", "zex2"));
            //lmo.Add(new ResultatZoneExpressionModel("cgf2", "zex2"));

            //List<ResultatConfigBulletinLO> lrblo = new List<ResultatConfigBulletinLO>();
            //lrblo = entity.ResultatConfigBulletinLOs.ToList();
            //ResultatConfigBulletinLO aa = new ResultatConfigBulletinLO();


            //foreach (ResultatConfigBulletinLO CBLO in lrblo)
            //{
            //    ResultatZoneExpressionModel rConfig = new ResultatZoneExpressionModel(CBLO);
            //    rConfig.Libelle = "-----" + CBLO.ConfigBulletinLO.Libelle;
            //    lmo.Add(rConfig);

            //    foreach (ResultatZoneExpressionVote RZEV in CBLO.ResultatsZoneExpressionVote)
            //    {
            //        ResultatZoneExpressionModel rZoneExpression = new ResultatZoneExpressionModel(RZEV);
            //        rZoneExpression.Libelle = "---" + RZEV.ZoneExpressionVote.Libelle;
            //        rZoneExpression.SuffragesBlancs = RZEV.ValeurBlanche.NbSuffrages;

            //        lmo.Add(rZoneExpression);
            //    }
            //}

            //lmo.GroupBy(x=>x.LibelleZoneExpression)

            //----------fin aplatir

            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf1", "zex1"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf1", "zex1"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf1", "zex2"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf1", "zex2"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf1", "zex3"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf1", "zex3"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf1", "zex3"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf2", "zex1"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf2", "zex2"));
            //resultatLoModel.ListeResultatZoneExpressionModel.Add(new ResultatZoneExpressionModel("cgf2", "zex2"));
            //resultatLoModel.ListCollectionViewResultatZoneExpressionModel = new ListCollectionView(lmo);

            /*

           resultatConfigBulletinLOModel.ListCollectionResultatsZev = new ListCollectionView(resultatZoneExpressionVoteModelAdapter.ToModels(entity.ResultatsZoneExpressionVote).ToList());

            resultatConfigBulletinLOModel.ListCollectionResultatsZev.GroupDescriptions.Add(new PropertyGroupDescription("LibelleConfiguration"));
            resultatConfigBulletinLOModel.ListCollectionResultatsZev.GroupDescriptions.Add(new PropertyGroupDescription("LibelleZoneExpression"));
            //LibelleZoneExpression
         */
        }

        private void Aplatir()
        {
            //foreach (ResultatConfigBulletinLOModel CBLO in ResultatsLOModel.ListeConfigsBulletins)
            //{
            //    foreach (ResultatZoneExpressionVote RZEV in CBLO.ResultatConfigBulletinLO.ResultatsZoneExpressionVote)
            //    {
            //        //RZEV.
            //    }

            //}
        }
    }

    public class Zone
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public int Valeur1 { get; set; }
        public int Valeur2 { get; set; }
        public SubVal sv { get; set; }
        public SubVal2 sv2 { get; set; }
        public Zone()
        {
            ID = Randomizer.Nombre(50);
            Libelle = Randomizer.Chaine(3);
            Valeur1 = Randomizer.Nombre(50);
            Valeur2 = Randomizer.Nombre(50);
            sv = new SubVal();
            sv2 = new SubVal2();
        }
    }

    public class SubVal
    {
        public int A { get; set; }
        public int B { get; set; }
        public SubVal()
        {
            A = 1;
            B = 10;
        }

    }

    public class SubVal2
    {
        public int A { get; set; }
        public SubVal2()
        {
            A = 1;
        }

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


    /*
    public enum EnumEtatLecture
    {
        // Valables
        [Display(Name = "Valable")]
        Valable,
        [Display(Name = "IDBLO OK")]
        IDBLOK,
        [Display(Name = "IDEL OK")]
        IDELOK,
        // Partiellement Valable
        [Display(Name = "Partiellement Valable")]
        PartiellementValable,
        // Non Valables
        [Display(Name = "Non Valable")]
        NonValable,
        // ID inconnu
        [Display(Name = "IDBLO Inconnu")]
        IDBLOInconnu,
        [Display(Name = "IDEL Inconnu")]
        IDELInconnu,
        // Erreur Lecture Id
        [Display(Name = "Erreur Lecture IDBLO")]
        ErreurLectureIDBLO,
        [Display(Name = "Erreur Lecture IDEL")]
        ErreurLectureIDEL,
        // Deja Traité
        [Display(Name = "Déjà Traité")]
        DejaTraite,
        // Erreur Coche
        [Display(Name = "Erreur Détection Coche de Contrôle")]
        ErreurCocheControle,
        // Coche OK
        CocheControleOK,
        // Erreur Lecture CAB
        [Display(Name = "Erreur Lecture Zone CAB")]
        ErreurLectureCAB,
        // Repoussé
        [Display(Name = "Repoussé")]
        Repousse
    }*/
}
