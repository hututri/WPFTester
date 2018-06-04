using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    //Utiliser dotnet run dans la console
    public class Program
    {
        public static void Main(string[] args)
        {
            Randomizer rnd = new Randomizer();
            FunctionsClass fc = new FunctionsClass();

            fc.Func06();
        }


        private class FunctionsClass
        {



            public void Func02()
            {
                /*List<Tuple<bool, Animal>> animalDic = new List<Tuple<bool, Animal>>();

                for (int i = 0; i < 10; i++)
                {
                    animalDic.Add(new Tuple<bool, Animal>(Randomizer.Booleen(), new Animal()));
                }

                foreach (Tuple<bool, Animal> item in animalDic)
                {
                    Console.WriteLine("bool:" + item.Item1 + " Animal:" + item.Item2.Id);
                }
                */

                List<SelectableAnimal> lAnimal = new List<SelectableAnimal>();

                for (int i = 0; i < 10; i++)
                {
                    lAnimal.Add(new SelectableAnimal(Randomizer.Booleen(), new Animal()));
                }

                foreach (SelectableAnimal sa in lAnimal)
                {
                    Console.WriteLine("-bool:" + sa.EstSelectionne.ToString() + " Animal:" + sa.Animal.Value.ToString());
                }
            }


            private class SelectableAnimal
            {
                public bool EstSelectionne { get; set; }
                public Animal Animal { get; set; }
                public SelectableAnimal(bool b, Animal a)
                {
                    EstSelectionne = b;
                    Animal = a;

                }
            }

            public void Func01()
            {
                /*



                 */
                SomeClass sc = new SomeClass();

                if (sc is null)
                {
                    Console.WriteLine("Hello World");
                }
                else
                {
                    Console.WriteLine("Bye World");
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Randomizer.Chaine(2));
                }
            }


            public void Func03()
            {
                List<Animal> lAnimal = new List<Animal>();
                List<Animal> lAnimal2 = new List<Animal>();
                for (int i = 0; i < 10; i++)
                {
                    lAnimal.Add(new Animal());
                }

                foreach (Animal item in lAnimal)
                {
                    Console.WriteLine(item.Id + " --" + item.Description);
                }

                Console.WriteLine("lAnimal possède des lignes: " + lAnimal.Any());
                Console.WriteLine("lAnimal2 possède des lignes: " + lAnimal2.Any());

            }

            public void Func04()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine((i % 2).ToString());
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }

            }

            public void Func05()
            {
                // BaseParent bp;
                // DerivedParent ep;
                for (int i = 0; i < 10; i++)
                {
                    BaseParent bp = new BaseParent();
                    DerivedParent ep = new DerivedParent(bp);
                    //Console.WriteLine(bp.Id + " - " + bp.Name + " - " + ep.Id + " - " + ep.Name);
                    Console.WriteLine(bp.Name);
                }
            }

            public void Func06()
            {
                string str = "xxx";
                //Ship sp = new Ship();
                Console.WriteLine(int.TryParse("55", out int i));
                Console.WriteLine(int.TryParse("q55", out int i0));
                Console.WriteLine(int.TryParse("55", out int i2));

                Console.WriteLine(str);
                str = null;
                Console.WriteLine(str);
                str = "...";
                Console.WriteLine(str);

            }

            private class Animal
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public int Value { get; set; }
                public string Description { get; set; }

                public Animal()
                {
                    Id = Randomizer.Nombre();
                    Name = Randomizer.Chaine(2);
                    Value = Randomizer.Nombre();
                    Description = Randomizer.Chaine(10);
                }
            }


            private class BaseParent
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public BaseParent()
                {
                    Id = Randomizer.Nombre();
                    Name = Randomizer.Nom();
                }
            }

            private class DerivedParent : BaseParent
            {
                public bool IsEnabled { get; set; }
                public DerivedParent()
                {
                    IsEnabled = Randomizer.Booleen();
                    Id = Randomizer.Nombre();
                    Name = Randomizer.Nom() + "...";
                }

                public DerivedParent(BaseParent b)
                {
                    Id = b.Id;
                    Name = b.Name;
                }
            }
        }
    }
    /*
    Ce qui est inquiétant c'est qu'on t'a tellement fourré de l'égalitarisme dans le cerveau que tu défends cette idée en prenant des exemples triés sur le volet. EN MOYENNE, est-ce que le monde est tel que tu le décris? Non.

    https://www.youtube.com/watch?v=FjwtdhpcUzw (fais attention aux arguments, pas à la source)
    Une femme, c'est physiquement plus petit, et ça ne peut pas gagner autant de muscle qu'un homme.
    Au combat, pour des raisons culturelles, les hommes se mettront en danger pour elles. Du coup ça met en danger le groupe.
    Si on te demande des capacités physiques standard (15 tractions, courir x m en x secondes, mesurer xxx cm au minimum), tu auras une répartition 50/50 de ceux qui passent le test?
     */
}