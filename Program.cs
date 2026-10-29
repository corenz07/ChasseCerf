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
        Console.WriteLine("Vous errez dans une forêt à la végétation dense mais vous parvenez tout de même à apercevoir un cerf adulte.\n\nVous savez ce que sa signifie, la chasse est ouverte.");
        int arrows = 5;
        int succesfulShots = 0;
        int missedShots = 0;
        while(arrows>0)
        {
            Console.WriteLine("\nvous possédez actuellement " + arrows + " flèches");
            Console.WriteLine("\nQuel est le résultat du tir? (touché/raté)");
            string answer = Console.ReadLine();
            --arrows;
            
        }

    }
}