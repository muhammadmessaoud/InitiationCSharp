using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethodes
    {
        //Une classe peut contenir 2 types de méthodes
        //méthodes de classe - méthode static accessible via la classe directement
        //Méthodes d'instance : pas de mot clé static - accessible via une instance de classe(via un objet de la classe)


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns></returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }

        //surcharge(overoad): le fait de pouvoir définir la mêle méthode dans la même classe uniquement avec la liste des parametres qui change
        public static double Somme( double x, double y)
        {
            return x + y;
        }

        public static void Afficher()
        {
            Console.WriteLine("Méthode void sans type de retour." );
        }

        //méthode pour lister le contenu d'un tableau

        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        //méthode qui renvoie la somme des éléments d'un tableau d'entiers
        public static int SommeTab(int[] tab)
        {
            int result = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                result += tab[i];
            }

            return result;
        }


        //méthode qui renvoie la moyenne des éléments d'un tableau d'entiers

        public static double AverageTab(int[] tab)
        {
            double result = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                result += tab[i];
            }

            return result / tab.Length;
        }


        //méthode qui renvoie l'éléments le plus petit d'un tableau d'entiers
        public static int LittlestElemTab(int[] tab)
        {
            int min = tab[0];

            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }

            return min;
        }


        //parametre optionnel d'une méthode
        //ce sont des param qui possèdent des valeurs par défaut et doivent être définie à la fin de la liste des params
        public static int SumOpt(int x , int y, int z = 10)
        {
            return x + y + z;
        }

        //methodes qui permutent 2 entier
        //ref concerne que les types simples (types valeur)
        //Passage de parametres par réference
        public static void Permutation(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
        //parametre en sortie
        public static double Calculer(double x , double y, out double somme, out double moyenne) 
        {
            moyenne = (x + y) / 2;
            somme = x + y;
            return x * y;
        }

        //Nombre variable de parametres d'une méthode 

       /* public static int Produit(int x, int y)
        {
            return x * y;
        }

        public static int Produit(int x, int y, int z)
        {
            return x * y * z;
        }

        public static int Produit(int x, int y, int z, int a)
        {
            return x * y * z * a;
        }*/

        //string[] ... args (varargs)
        public static int Produit(params int[] tab)
        {
            int prod = 1;
            foreach (var item in tab)
            {
                prod *= item;
            }
            return prod;
        }


    }
}
