using ProjetDLL;
using System;
using System.IO;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ceci est un commentaire sur une ligne

            /*
             * ceci est un commentaire sur plusieurs lignes
             */

            Console.WriteLine("Test de c#");
            Tools.MaMethod();

            #region Variables
            Console.WriteLine("***************************Variables*****************************");



            //Variable; zone mémoire qui contient une valeur typé;
            //Type simples (types valeur): entier, réels, boolean, char
            //Type complexes (type références): tableau, string, dates, Classes (Objects)

            //entiers: byte(1 o), short (2 o), int (4 o), long (8 o)
            //réels: float(4 o), double (8 o), decimal (16 o)

            //declaration d'une varibale: type, nom_variable = valeur;

            int myInt = 10;

            int myInt2 = myInt;

            myInt = 20;

            Console.WriteLine("Contenu de myInt: " + myInt);// le + est une concatenation

            double myDouble = 10.5;
            char myChar = 'b';
            bool myBool = true;
            string myString = "M";

            // mot clef var: inférence de type - c'est le compilateur qui détermine le type de la varibale selon sa valeur;

            var maVariable = 10;

            //type nullablrd: .net propose une synthaxe qui permet de définir des types mples null
            int? x = null;

            //Avant utilisation de x , on doit vérifier qu'elle contient une valeur

            if (x.HasValue)
            {
                Console.WriteLine("x n'est pas null");

            }
            else
            {
                Console.WriteLine("x est null");
            }

            string str = null;

            int age = 0;
            Console.WriteLine("quel est votre age?");
            age = Convert.ToInt32(Console.ReadLine()); // si le user oublie de fournir l'age on aura une erreur 

            Console.WriteLine("Votre age est de :" + age);

            //Constante : varaible contenant une valeu non modifiable

            const double MA_CONSTANTE = 10.5;


            #endregion

            #region Operateurs
            Console.WriteLine("***************************Operateur*****************************");


            //opérateur mathématiques: +, -, *, /, %(Modulo: reste de la division entière
            Console.WriteLine("Reste de la division de 10 par 3" + (10 % 3));

            //opératuers combinés: +=, -=, *=, /=

            myInt += 5; // myInt = myInt +5

            //opératuers d'incrémentation et de décrementation
            int val = 0;

            Console.WriteLine(val++);

            Console.WriteLine(6 + "5" + 2); // sortie 652;

            Console.WriteLine(6 + 2 + "5"); // sortie 85

            Console.WriteLine("6" + 5 + 2); //sortie 652

            //operateur de comparaison : ==, <, >, <=, >=, !=

            //operateur logique: &&(et logique), || (ou logique), ! (non logique), ^ (ou exclusif)

            int v1 = 10, v2 = 15;
            Console.WriteLine((v1 > v2 && (v1 < v2)));
            //Table logique
            //A     B       A&&B        A||B        A^B
            //v     v       v             v         f
            //v     f       f             v         v
            //f     v       f             v         v
            //f     f       f             f         f


            #endregion

            #region Conversion de type
            Console.WriteLine("***************************Conversion de type*****************************");


            //conversion implicite: concerne le passsage d'un type inferieur a un type supérieur
            byte myByte = 10;
            int myInt3 = myByte;

            //Conversion explicite: passage d'un type sup à un type inf - risque de perte de données
            //Pour les conversions explicites on peut utiliser:
            //CAST: (int), (byte), (double) ...
            //La classe Convert
            int myInt4 = 20;
            byte myByte2 = (byte)myInt4;
            byte myByte3 = Convert.ToByte(myInt4);

            string chaine = "25";
            int myInt5 = Convert.ToInt32(chaine);
            int myInt6 = int.Parse(chaine);


            #endregion

            #region Conditions
            Console.WriteLine("***************************Conditions*****************************");


            //Exprimer un test conditionnel: if(condition = vrai ) {instruction} else {instructions;}

            int nb = 5;

            if (nb > 0)
            {
                Console.WriteLine("nb positif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("nb est null");
            }
            else
            {
                Console.WriteLine("nb est negatif");
            }

            //Switch: est une variant de la condition if 

            int note = 10;

            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Les 10 , 11 et 12");
                    break;

                default:
                    Console.WriteLine("Autres notes");
                    break;
            }



            #endregion

            #region Boucles
            Console.WriteLine("***************************Boucles*****************************");


            //Boucles conditionnelles: While , do while
            //Boucles Itératives: For, for each - répéter un traitement un certain nombre de fois

            //for 

            for (int i = 0; i < 10; i++)
            {

                //Passer à l'itération suivante : si i == 3

                if (i ==3)
                {
                    continue;
                }

                Console.WriteLine("Passage numéro:" + i);

                
                //Quitter la boucle for si i = 6 
                if (i == 6)
                {
                    break; // permet de sortir de la boucle for
                }
            }

            //for each - permet de faire un parcours complet d'une collection
            int[] tab = {1, 2, 3, 4};
            foreach (int item  in tab)
            {
                Console.WriteLine(item);
            }



            //while
            int valeur = 1;
            while (valeur < 5) // Tant que valeur est inférieur a 5
            {
                Console.WriteLine("Passage numéro : " + valeur);
                valeur++;
            }


            // do while : s'execute au moins une fois
            do
            {
                Console.WriteLine("Passage numéro :" + valeur);
                valeur++;
            } while (valeur < 10);

            

            // si l'age est compris entre 18 et 60 afficher Valide - sinon age non - saisir un nouveau age 

            do
            {
                Console.WriteLine("Quel est votre age :");
                int ageUser = Convert.ToInt32(Console.ReadLine());
                if (ageUser >= 18 && ageUser <=60)
                {
                    break;
                }
            } while (true);


            #endregion

            #region Tableaux
            Console.WriteLine("***************************Tableaux*****************************");


            //Tableau: un ensemble d'éléments typés

            // 1 dimension 

            //déclaration d'un tableau

            int[] tableau = new int[3]; // tableau de 3 cases

            tableau[0] = 10;
            tableau[1] = 20;
            tableau[2] = 30;

            Console.WriteLine("taille du tableau : " + tableau.Length); //3

            //Parcours du tableau avec la boucle foreach

            foreach (int item in tableau)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < tableau.Length ; i++)
            {
                Console.WriteLine(tableau[i]);
            }

            //Deuxieme facon de déclarer un tableau

            int[] tableau2 = {10 , 20 , 30 };

            //tableau à deux dimensions

            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 20;
            matrice[0, 2] = 30;
            matrice[1, 0] = 40;
            matrice[1, 1] = 50;
            matrice[1, 2] = 60;

            Console.WriteLine(matrice[0,2]);

            int[,] matrice2 = { {10,15,58 }, {12,25,32 } }; //autre facon de déclarer un tableau à deux dimensions

            Console.WriteLine("nombre de ligne de la matrice2 :" + matrice2.GetLength(0)); //2
            Console.WriteLine("nombre de colonnes" + matrice2.GetLength(1)); //3
            Console.WriteLine("nombre total d'éléments de matrice2:" + matrice2.Length); //6
            Console.WriteLine("nombre de dimensions de matrice2:" + matrice2.Rank); //2


            #endregion

            #region Methodes

            Console.WriteLine("***************************Methodes*****************************");

            //méthodes: un ensemble d'instruction réutilisable
            //dans la programmation objet on a 2 types de méthodes:
            //Procédures: méthode qui ne renvoie aucune valeur (void)
            //fonctions: méthode qui renvoie une valeur ou un résultats - on doit préciser le type du résultat renvoyé
            //déclaration d'une méthode: Visibilité (mot clé static), type de retour, nom méthode(paramètres){instructions;} 

            /*MesMethodes mm = new MesMethodes();
            mm.Somme(10, 20);*/

            int resultat = MesMethodes.Somme(10, 20);
            Console.WriteLine(resultat);

            MesMethodes.Afficher();

            int[] monTableau = { 10, 1, 20, 15 };

            MesMethodes.Afficher(monTableau);

            Console.WriteLine("somme tab : " + MesMethodes.SommeTab(monTableau)); 
            Console.WriteLine("average tab : " + MesMethodes.AverageTab(monTableau)); 
            Console.WriteLine("littlest element tab : " + MesMethodes.LittlestElemTab(monTableau));


            //appelle de la méthode SumOpt
            MesMethodes.SumOpt(10,20); //Valeur par défaut de z qui est pris en compte
            MesMethodes.SumOpt(10, 20, 50);

            int val1 = 10, val2 = 20;

            //Concaténation +
            Console.WriteLine("concaténation" + MesMethodes.Somme(val1, val2));

            //interpolation
            Console.WriteLine($"Avant permutation : val1 = {val1} - val2 = {val2}");

            MesMethodes.Permutation( ref val1, ref val2);

            Console.WriteLine($"Après permutation : val1 = {val1} - val2 = {val2}");

            // appelle de méthode avec des parametres de sortie

            double sum = 0, moyenne = 0;
            double produit = MesMethodes.Calculer(10, 20, out sum, out moyenne );
            Console.WriteLine($"Produit = {produit}");
            Console.WriteLine($"Somme = {sum}");
            Console.WriteLine($"Moyenne = {moyenne}");

            //appelle de la méthode avec un nombre variable d'arguments
            MesMethodes.Produit(10, 20);
            MesMethodes.Produit(10, 20, 30);
            MesMethodes.Produit(10, 20, 30, 40);


            #endregion


            // Maintenir la console active
            Console.ReadLine();
        }
    }
}
 