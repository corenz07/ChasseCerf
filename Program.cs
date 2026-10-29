using System.Diagnostics.CodeAnalysis;

namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        string answer2 = "y";
        while (answer2 == "y")
        {
           int arrows = 5;
           int succesfulShots = 0;
           int missedShots = 0;
            Console.WriteLine("\nVous errez dans une forêt à la végétation dense mais vous parvenez tout de même à apercevoir un cerf adulte.\n\nVous savez ce que sa signifie, la chasse est ouverte.");
            while (arrows > 0)
            {
                Console.WriteLine("\nvous possédez actuellement " + arrows + " flèches");
                Console.WriteLine("\nQuel est le résultat du tir? (touché/raté)");
                string answer = Console.ReadLine();
                if (answer == "touché")
                {
                    Console.WriteLine("\nTir impeccable. Le cerf est blessé");
                    ++succesfulShots;
                    if (succesfulShots == 2)
                    {
                        Console.WriteLine("\nLe cerf est bien amoché, une dernière flèche devrais suffire");
                    }
                }
                else if (answer == "raté")
                {
                    Console.WriteLine("\nle cerf ressort indemne du tir.\nÇa laisse à désirer...");
                    ++missedShots;
                }
                while (answer != "raté" && answer != "touché")
                {
                    Console.WriteLine("\nproposition invalide");
                    Console.WriteLine("\nQuel est le résultat du tir? (touché/raté)");
                    answer = Console.ReadLine();
                    if (answer == "touché")
                    {
                        Console.WriteLine("\nTir impeccable. Le cerf est blessé");
                        ++succesfulShots;
                    }
                    else if (answer == "raté")
                    {
                        Console.WriteLine("\nle cerf ressort indemne.Le tir laisse à désirer...");
                    }
                }
                --arrows;
                if(arrows == 0 || succesfulShots == 3)
                {
                    break;
                }
               
            }
            if(missedShots >= 3)
            {
                Console.WriteLine("\nLe cerf vous a échappé ...\nFaites mieux la prochaine fois :(");
            }
            else
            {
                Console.WriteLine("cerf abattue");
            }
            Console.WriteLine("\n ~~Bilan de la chasse~~\nTirs réussis : "+succesfulShots+"\nFlèches restantes : "+arrows);
            if (succesfulShots == 3)
            {
                Console.WriteLine("Résultat : Chasse réussie");
            }
            else
            {
                Console.WriteLine("Résultat : Chasse échouée");
            }
            Console.WriteLine("\nsouhaitez-vous recommencer ? (y/n)");
            answer2 = Console.ReadLine();
        }
    }
}