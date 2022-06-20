using System;
using System.Collections.Generic;
using System.IO;

namespace SelectionCandidat
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Get data from input file */
            var data = new List<String>();
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                data.Add(line);
            }
            //déclaration de mes variables, récupération des paramètres de ma liste
            //.Split = méthode qui permet de créer un tableau de sous-chaînes en fractionnant la chaîne d'entrée
            //en fonction d'un ou plusieurs délimiteurs

            int grille = Int32.Parse(data[0]);
            string[] xy = data[1].Split(",");
            int coordX = int.Parse(xy[0]);
            int coordY = int.Parse(xy[1]);

            //boucle ou on va pouvoir préciser le nombre d'instructions pour le joueur
            //le but est de faire déplacer le joueur en respectant les conditions, pour le faire arriver à une position finale
            //s'il sort de la grille, alors on affiche 0
            //3 est enfaite l'index 3 qui est la première instruction du joueur, tant que la première instruction + i est inférieur au nombre d'instructions
            //le joueur continue d'avancer jusqu'à la position finale ou jusqu'à sortir de la grille

            for (int i = 0; i < int.Parse(data[2]); i++)
            {
                if (data[3 + i] == "u")
                {
                    coordY++;
                }
                if (data[3 + i] == "d")
                {
                    coordY--;
                }
                if (data[3 + i] == "r")
                {
                    coordX++;
                }
                if (data[3 + i] == "l")
                {
                    coordX--;
                }
            }
            if (coordX >= grille || coordX < 0 || coordY >= grille || coordY < 0)
            {
                Console.WriteLine(0);
                //return; signifie l'arrêt de la boucle
                return;
            }

            //on place Console.WriteLine ici car si dans la boucle avant return, on affichera la position avant d'afficher 0, hors ce n'est pas ce qu'on veut
            //de même qu'il n'est pas placé dans le if après return; puisque la boucle sera terminé

            Console.WriteLine("{0},{1}", coordX, coordY);

        }
    }
}