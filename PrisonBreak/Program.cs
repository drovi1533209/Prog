using System;

namespace Lab1_Prison_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int charisme = 0;
            int force = 0;
            bool steroid = false;
            Random gameOver = new Random();
            Random infirmiere = new Random();
            int gameOverChance5 = gameOver.Next(5);
            int gameOverChance3 = gameOver.Next(3);
            int gameOverChance2 = gameOver.Next(2);
            int chanceInfirmiere = infirmiere.Next(1);


            Console.WriteLine("Votre objectif est de s'évader de prison. Bonne chance!");
            Console.ReadKey();
            Console.WriteLine("Vous voulez commencer avec de la reconnaissance. Où voulez vous commencer?");
            Console.WriteLine("Appuyer sur 1 pour aller a l'infirmerie ou appuyer sur le 2 pour aller a la cour de la prison");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Après un bagarre, vous vous retrouvez a l'infirmerie. Que faite vous?");
                Console.WriteLine("Appuyer sur 3 pour voler la seringue de stéroide sur le comptoir ou appuyer sur le 4 pour cruiser l'infirmière.");
                if (Console.ReadLine() == "4")
                {
                    Console.WriteLine("L'infirmière est moins alerte avec vous.");
                    charisme = charisme + 5;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Vous volez une seringue de steroides.");
                    Console.WriteLine("Vous avez trouvé un moyen d'être plus fort.");
                    Console.ReadKey();
                    steroid = true;
                    if (steroid == true)
                    {
                        Console.WriteLine("Voulez vous utiliser le steroid (1 usage seulement)?");
                        Console.WriteLine("Appuyer sur y pour oui ou n pour non.");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            Console.WriteLine("Vous vous sentez plus fort.");
                            force = force + 5;
                            steroid = false;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Vous retournez a votre cellule.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vous retournez a votre cellule.");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Une fois a la cour de Prison, que faites-vous?");
                Console.WriteLine("Appuyer sur 5 pour se promener partout pour faire de la reconaissance ou appuyer sur 6 pour s'entraîner avec les équipements appropriés.");
                if (Console.ReadLine() == "5")
                {
                    Console.WriteLine("En vous promenant, vous trouvez une vis qui pourrait peut-être vous sevire plus tard.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Vous vous entraînez avec l'équipement fournis par la prison qui se trouve dans la cour.");
                    force = force + 5;
                    Console.ReadKey();
                }

            }
            Console.WriteLine("Prochaine étape, vous pouvez sois continuer de faire de la reconaissance ou vous pouvez commencer à démancher la toilette de votre cellule");
            Console.WriteLine("Appuyer sur 6 continuer la reconaissance ou appuyer sur 7 pour démancher la toilette");
            if (Console.ReadLine() == "6")
            {
                Console.WriteLine("Après un bagarre, vous vous retrouvez a l'infirmerie. Que faites vous?");
                Console.WriteLine("Appuyer sur 8 pour voler la seringue de stéroide sur le comptoir ou appuyer sur le 9 pour cruiser l'infirmière.");
                if (Console.ReadLine() == "9")
                {
                    Console.WriteLine("L'infirmière est moins alerte avec vous.");
                    charisme = charisme + 5;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Vous volez une seringue de steroides.");
                    Console.WriteLine("Vous avez trouvé un moyen d'être plus fort.");
                    steroid = true;
                    if (steroid == true)
                    {
                        Console.WriteLine("Voulez vous utiliser le steroid?");
                        Console.WriteLine("Appuyer sur y pour oui ou n pour non.");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            Console.WriteLine("Vous vous sentez plus fort.");
                            force = force + 5;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Vous retournez a votre cellule.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vous retournez a votre cellule.");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Vous avez trouver un endroit pour creuser jusqu'a votre liberté.");
                Console.ReadKey();
            }

            Console.WriteLine("Vous devez trouver un objet pour creuser.");
            Console.WriteLine("Appuyer sur 0 pour voler un outil de jardinage ou appuyer sur 1 pour demander de l'aide a l'infirmière.");
            if (Console.ReadLine() == "0")
            {
                if (gameOverChance5 == 2)
                {
                    Console.WriteLine("Vous avez trouvé une petite pèle a jardinage.");
                    Console.ReadKey();
                    Console.WriteLine("Une fois de retour dans votre cellule, vous cachez la pèle en arrière de la toilette.");
                    Console.ReadKey();
                    Console.WriteLine("Vous creusez un trou avec la pèle. Vous pensez finir dans 2 mois si tout ce passe bien.");
                    if (gameOverChance3 == 1)
                    {
                        Console.WriteLine("On vous a attrapper avec la pèle au premier mois. Game Over");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        if (gameOverChance3 == 1)
                        {
                            Console.WriteLine("On vous a attrapper avec la pèle au deuxième mois. Game Over");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if (gameOverChance3 == 1)
                            {
                                Console.WriteLine("On vous a attrapper avec la pèle au troisième mois. Game Over");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Vous avez réussi! Félicitations!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("On vous a attrapper avec la pèle. Game Over.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Vous demandez a l'infirmère de vous aider a trouver un objet qui peut vous aider a creuser.");
                Console.ReadKey();
                if (chanceInfirmiere == 0)
                {
                    if (charisme == 5)
                    {
                        Console.WriteLine("L'infirmière reussi a vous donnner une pèle de jardinage en secret.");
                        Console.ReadKey();
                        Console.WriteLine("Une fois de retour dans votre cellule, vous cachez la pèle en arrière de la toilette.");
                        Console.ReadKey();
                        Console.WriteLine("Vous creusez un trou avec la pèle. Vous pensez finir dans 2 mois si tout ce passe bien.");
                        Console.ReadKey();
                        if (gameOverChance3 == 1)
                        {
                            Console.WriteLine("On vous a attrapper avec la pèle au premier mois. Game Over");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if (gameOverChance3 == 1)
                            {
                                Console.WriteLine("On vous a attrapper avec la pèle deuxième mois. Game Over");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                if (gameOverChance3 == 1)
                                {
                                    Console.WriteLine("On vous a attrapper avec la pèle au troisième mois. Game Over");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Vous avez réussi! Félicitations!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (charisme == 5)
                    {
                        if (chanceInfirmiere == 0)
                        {
                            Console.WriteLine("L'infirmière refuse de vous aider mais elle a acceptée de ne rien dire.");
                            Console.ReadKey();
                            Console.WriteLine("Vous avez décidé de creuser avec vos mains. Vous pensez prendre 5 mois pour reussir.");
                            Console.ReadKey();
                            if (gameOverChance3 == 1)
                            {
                                Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au premier mois. Game Over");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                if (gameOverChance3 == 1)
                                {
                                    Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au deuxième mois. Game Over");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    if (gameOverChance3 == 1)
                                    {
                                        Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au troisième mois. Game Over");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        if (gameOverChance3 == 1)
                                        {
                                            Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au quatrième mois. Game Over");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            if (gameOverChance3 == 1)
                                            {
                                                Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au cinqième mois. Game Over");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Vous avez réussi! Félicitations!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            int gameOverChance = gameOver.Next(2);
                            if (gameOverChance == 2)
                            {
                                Console.WriteLine("L'infirmière à décidée de vous amener aux authorités. Game Over");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("L'inifirmière refuse de vous aider mais elle a accpeter de ne rien dire.");
                                if (gameOverChance3 == 1)
                                {
                                    Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au premier mois. Game Over");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    if (gameOverChance3 == 1)
                                    {
                                        Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au deuxième mois. Game Over");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        if (gameOverChance3 == 1)
                                        {
                                            Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au troisième mois. Game Over");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            if (gameOverChance3 == 1)
                                            {
                                                Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au quatrième mois. Game Over");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                if (gameOverChance3 == 1)
                                                {
                                                    Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au cinqième mois. Game Over");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Vous avez réussi! Félicitations!");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (gameOverChance2 == 2)
                        {
                            Console.WriteLine("L'infirmière à décidée de vous amener aux authorités. Game Over");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("L'inifirmière refuse de vous aider mais elle a accpeter de ne rien dire.");
                            int gameOverChance = gameOver.Next(3);
                            if (gameOverChance3 == 1)
                            {
                                Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au premier mois. Game Over");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                if (gameOverChance3 == 1)
                                {
                                    Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au deuxième mois. Game Over");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    if (gameOverChance3 == 1)
                                    {
                                        Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au troisième mois. Game Over");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        if (gameOverChance3 == 1)
                                        {
                                            Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au quatrième mois. Game Over");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            if (gameOverChance3 == 1)
                                            {
                                                Console.WriteLine("On vous a attrapper avec un trou dans votre cellule au cinqième mois. Game Over");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Vous avez réussi! Félicitations!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
