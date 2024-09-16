using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// saisie avec contrôle des valeurs à traiter 
        /// </summary>
        /// <param name="message">message de saisie à afficher</param>
        /// <returns>valeurs à traiter</returns>
        static int Saisie(string message)
        {
            int reponse = 0;
            bool correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write(message);
                    reponse = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("erreur de saisie ! Saisissez un nombre entier svp");
                    Console.WriteLine();
                }
            }
            return reponse;
        }
        /// <summary>
        /// calcul de différentes factorielles en fonction des saisies
        /// </summary>
        /// <param name="nbSaisi1">ensemble saisi</param>
        /// <param name="nbSaisi2">sous-ensemble saisi</param>
        /// <param name="choix">calcul à effectuer</param>
        /// <returns>factorielles</returns>
        static long Factorielle(int nbSaisi1, int nbSaisi2, int choix)
        {
            long factorielle = 1;
            switch (choix)
            {
                case 0:
                    for (int k = 1; k <= nbSaisi1; k++)
                    {
                        factorielle *= k;
                    }
                    return factorielle;
                    break;
                case 1:
                    for (int k = (nbSaisi1 - nbSaisi2 + 1); k <= nbSaisi1; k++)
                    {
                        factorielle *= k;
                    }
                    return factorielle;
                    break;
                case 2:
                    for (int k = 1; k <= nbSaisi2; k++)
                    {
                        factorielle *= k;
                    }
                    return factorielle;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        /// <summary>
        /// programme de calculs
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char choixMenu;
            do
            {
                //Menu
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix : ");
                choixMenu = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                switch (choixMenu)
                {
                    case '0':
                        Environment.Exit(0);
                        break;
                    //Permutation
                    case '1':
                        // saisie
                        int nbTotal = Saisie("nombre d'éléments à gérer = ");
                        //résultat
                        int sousEnsemble = 0;
                        int choix = 0;
                        long result = Factorielle(nbTotal, sousEnsemble, choix);
                        Console.WriteLine("Permutation " + nbTotal + "! = " + result);
                        Console.WriteLine();
                        break;
                    //Arrangement
                    case '2':
                        // saisies
                        nbTotal = Saisie("nombre total d'éléments à gérer = ");
                        sousEnsemble = Saisie("nombre d'éléments dans le sous ensemble = ");
                        // résultat
                        choix = 1;
                        result = Factorielle(nbTotal, sousEnsemble, choix);
                        Console.WriteLine("Arrangement (" + nbTotal + "/" + sousEnsemble + ") = " + result);
                        Console.WriteLine();
                        break;
                    //Combinaison
                    case '3':
                        // saisies
                        nbTotal = Saisie("nombre total d'éléments à gérer = ");
                        sousEnsemble = Saisie("nombre d'éléments dans le sous ensemble = ");
                        // résultat
                        choix = 1;
                        long r1 = Factorielle(nbTotal, sousEnsemble, choix);
                        choix = 2;
                        long r2 = Factorielle(nbTotal, sousEnsemble, choix);
                        long resultat = (r1 / r2);
                        Console.WriteLine("Combinaison (" + nbTotal + "/" + sousEnsemble + ") = " + (r1 / r2));
                        Console.WriteLine();
                        break;
                    // Message d'erreur
                    default:
                        Console.WriteLine("erreur de saisie ! Saisissez un nombre entier svp");
                        Console.WriteLine();
                        break;
                }
            } while (choixMenu != '0');
            Console.ReadLine();
        }
    }
}
