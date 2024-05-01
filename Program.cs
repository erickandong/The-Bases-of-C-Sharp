using System.Diagnostics;
using System.Collections.Generic;

namespace Les_Bases_du_C_Sharp
{
    internal class Program
    {
        //CONSTANTES 
        const float pi = 3.1416f;

        //ENUMERATIONS 

        enum month
        {
            janvier, fevrier, mars, avril, mai, juin,
            juillet, aut, septembre, octobre, novembre, decembre
        }


        static void Main(string[] args)
        {

            month m = month.janvier;
            m = month.fevrier;

            //CONCATENATION
            string prenom = "Jean-philippe";
            int age = 49;
            string str = "Je suis " + prenom + ",et j'ai " + age + "ans";
            Console.WriteLine(str);

            Console.WriteLine("Je suis {0} et j'ai {1} ans.", prenom, age);

            Console.WriteLine($"Je suis {prenom} et j'ai {age} ans.");

            //CALCULS ARITHMETIQUES
            int nombre = 22;
            int resultat;

            resultat = nombre * 2;
            Console.WriteLine(resultat);

            nombre += 10;
            Console.WriteLine(nombre);

            // nombre = nombre % 4;
            // Console.WriteLine(nombre);

            //INSTRUCTIONS CONDITIONNELLES If

            bool homme = true;
            if (!homme) Console.WriteLine("Vous etes une femme");

            //INSTRUCTIONS SWITCH
            //exemple1
            string nom = "Jean";

            switch (nom)
            {
                case "Jean-philippe":
                    Console.WriteLine("bonjour " + nom);
                    break;

                case "Luc":
                    Console.WriteLine("bonjour " + nom);
                    break;

                case "Zoe":
                    Console.WriteLine("bonjour " + nom);
                    break;

                default:
                    Console.WriteLine("Bonjour Vous.");
                    break;
            }

            //exemple2
            int moyenne = 10;

            switch (moyenne)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mediocre");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Non-Admis");
                    break;

                default:
                    Console.WriteLine("Admis");
                    break;
            }

            //SAISIE DU CLAVIER ReadLine: renvoi toujours une variable de type string

            /*Console.WriteLine("Entrez votre prenom");
            string surnom;
            surnom = Console.ReadLine();
            Console.WriteLine("Bonjour, " + surnom);
            Console.WriteLine(surnom.GetType());*/ //affiche le type de la variable 

            //TABLEAUX UNIDIMENSIONNELLES EN C#

            //Exemple1
            string[] tabMois =
            {
                "Janvier",
                "fevrier",
                "mars",
                "Avril"
            };
            Console.WriteLine(tabMois[1]);
            Console.WriteLine("Longueur du tableau " + tabMois.Length);

            tabMois[3] = "Mai"; // change la valeur de Avril par Mai

            //Exemple2
            int[] tabNb = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine(tabNb[0]);

            tabNb[0] = 11;
            Console.WriteLine(tabNb[0]);

            /*  Exemple 3
            string[] tabAnnée = new string[2];
            tabAnnée[0] = "Janvier";

            string str = Console.ReadLine();
            tabAnnée[1] = str;

            Console.WriteLine("Votre saisie");*/


            //STRUCTURES CONDITIONNELLES EN C#


            //BOUCLE FOR

            /*  //Exemple1
              for(int i = 0;  i < 10; i+=2)
              {
                  Console.WriteLine("Valeur de i: " + i );
              }

              //Exemple2
              string[] tPrenom = { "luc", "Zoe", "marc", "alex", "pierre" };

              for (int i = 0; i < tPrenom.Length; i ++)
              {
                  Console.WriteLine("Indice : " + i + " Valeur : " + tPrenom[i]);
              }  */

            //BOUCLE FOREACH

            //Exemple3: permet de parcourir une liste sans indiquer sa longueur 
            /*  string[] tPrenom = { "luc", "Zoe", "marc", "alex", "pierre" };
            
                foreach (string str  in tPrenom)
                {
                    Console.WriteLine(str);
                } */

            //BOUCLE WHILE: respecte la condition avant d'exécuter l'action

            string[] t1Prenom = { "luc", "Zoe", "marc", "alex", "pierre" };

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Valeur de i " + i);
                i++;
            }

            //BOUCLE DO-WHILE: fait laction avant de respecter la condition

            do
            {
                Console.WriteLine("Valeur de i " + i);
                i++;
            } while (i < 10);


            // CONVERSIONS ENTRE LES TYPES ou CAST ou TRANSCRIPAGE

            //CONVERSION IMPLICITE POUR LES NOMBRES
            int nb1 = 15;
            float nb2 = nb1;

            //CONVERSION EXPLICITE POUR LES NOMBRES

            float nb3 = 15.6f;
            int nb4 = (int)nb3;
            Console.WriteLine(nb4);

            //CONVERSION LES CHAINES DE CARACTERES EN NOMBRE

            string p = Console.ReadLine();
            int resultat1;

            if (Int32.TryParse(p, out resultat1))
            {
                resultat1 = Int32.Parse(p) * 2;
                Console.WriteLine(p + " que multiplie 2 est égal à " + resultat1);
            }

            //CONVERSION NOMBRE EN CHAINE DE CARACTERES

            int p1 = 33;
            string m = p1.ToString();
            Console.WriteLine(m);





            //LES LISTES

            List<string> lstPrenom = new List<string>();
            lstPrenom.Add("Jean");
            lstPrenom.Add("Luc");
            lstPrenom.Add("Alex");
            lstPrenom.Add("Zoe");

            List<string> lst2Prenom = new List<string>
            {
                "Zoé",
                "Martin",
                "Luc"
            };


            lstPrenom[2] = "Franck"; //modifier le contenu 

            Console.WriteLine(lstPrenom[2]);
            Console.WriteLine(lstPrenom.Count);//nombre d'éléments dans la liste

            foreach (string item in lstPrenom)
            {
                Console.WriteLine(item);
            }

            //lstPrenom.Remove("Luc"); //supprimer un élément de la liste

            //lstPrenom.RemoveAt(0); //supprime un élément de la liste en utilisant un index

            lstPrenom.RemoveRange(0, 2); //supprime 2 éléments
            lstPrenom.Clear(); //pour vider une liste




            //LES DICTIONNAIRES: collection de paire clé-valeur

            Dictionary<string, string> dicoExt2 = new Dictionary<string, string>()
            {
                {"bmp", "paint.exe"},
                {"txt", "notepad.exe"},
                {"docx", "winword.exe" }
            };


            Dictionary<string, string> dicoExt = new Dictionary<string, string>();
            dicoExt.Add("bmp", "paint.exe");
            dicoExt.Add("txt", "notepad.exe");
            dicoExt.Add("docx", "winword.exe");


            Console.WriteLine(dicoExt["bmp"]); //afficher le contenu de la clé bmp

            Console.WriteLine(dicoExt.Count); //nombre d'élément dans le dictionnaire

            dicoExt.Remove("txt"); //supprimer une clé

            //verifions si une clé existe
            if (dicoExt.ContainsKey("exe"))
            {
                Console.WriteLine(dicoExt["bmp"]);
            }
            else
            {
                Console.WriteLine("clé absente...");
            }

            //Chercher la valeur d'une clé ou d'une valeur autrement
            string result;
            if (dicoExt.TryGetValue("bmp"), out result)
            {
                Console.WriteLine(dicoExt["bmp"]);
            }
            else
            {
                Console.WriteLine("clé absente...");
            }



            //Chercher une valeur
            foreach (KeyValuePair<string, string> kvp in dicoExt)
            {
                Console.WriteLine(kvp);
                Console.WriteLine("clé :" + kvp.Key + " valeur : " + kvp.Value);
            }



            //CONSTANTES ET ENUMERATIONS: ce sont des champs dont la valeur est définie au moment de la compilation et ne sont pas modifiable  



            // GERER LES EXCEPTIONS OU GERER LES ERREURS (permet de faire en sorte que le programme ne plante plus)

            Console.WriteLine("Entrez un nombre ?");

            try
            {
                int nb3 = int.Parse(Console.ReadLine());
                Console.WriteLine($"1024/{nb3}={1024 / nb3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // ou ex.StackTrace
            }
            catch (OverflowException)
            {
                Console.WriteLine("Le type n'est pas correct.")
            }
            catch (Exception ex)
            {
                Console.WriteLine("erreur");
                Console.WriteLine(ex);
            }

            finally //permet de fermer un fichier, permet également d'exécuter un code que cela réussisse ou pas
            {
                Console.WriteLine("A bientot");
            }



            //OPERATEUR TERNAIRE OU OPERATEUR CONDITIONNEL: le signe "?" permet de réduire la condition "if...else"
            //Syntaxe: (Condition)  ?  Bloc1 : Bloc2
            // si condition vraie = Bloc1 exécuté
            // si condition fausse = Bloc2 exécuté

            //Exemple1
            bool homme = true;

            string message = homme ? "Bonjour Mr" : "Bonjour Mme";
            Console.WriteLine(message);

            //Exemple2
            int moyenne1 = 11;

            string message1 = moyenne1 <= 10 ? "non-admis" : "admis";
            Console.WriteLine(message1);



            //PERSONALISER L'APPARENCE DE LA CONSOLE

            Console.BackgroundColor = ConsoleColor.Green; //Changer la couleur d'arrière plan
            Console.WriteLine("Hello World");

            Console.ForegroundColor = ConsoleColor.Blue;  //Changer la couleur du texte
            Console.WriteLine("Bonjour le monde");

            Console.CursorSize = 50; //Changer la taille du curseur

            Console.CursorVisible = true; //Choisir si le curseur apparait ou non

            Console.Title = "Mon Deuxieme programme";  //permet de mettre un titre dans la console

            Console.WindowWidth = 50; // 50 caractères de large
            Console.WindowHeight = 15; // hauteur de 15 lignes


            //GENERER UN NOMBRE DE FACON ALEATOIRE QUI NE DEPASSE PAS 100 PAR EXEMPLE

            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                int nb5 = rand.Next(100); // Pour les nombres à virgule c'est: double nb5 = rand.NextDouble(10,20);
                Console.WriteLine(nb5);
            }


            //EXERCICE DE CODAGE: Déviner un nombre entre 1 et 100


            Console.ReadKey();

        }
    }
}
