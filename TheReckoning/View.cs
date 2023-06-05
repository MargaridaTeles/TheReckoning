using System;
using System.Collections.Generic;
using System.Linq;

namespace TheReckoning
{
    public class View : IView
    {
        // This view doesn't actually need a reference to the controller,
        // but generally views will need it
        private readonly Controller controller;

        public View(Controller controller)
        {
            this.controller = controller;
        }

        public int MainMenu()
        {
            Console.WriteLine("Welcome to the Reckoning!\nPlease press any key to enter the Menu!");
            Console.ReadLine();
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Show Cards");
            Console.WriteLine("3. Start");
            Console.WriteLine("9. How To Play ");
            Console.WriteLine("0. Exit");
            Console.WriteLine("");
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        public void InvalidOption()
        {
            /*Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();*/
        }

        private int round_number = 1;
        private string winner;
        public void Start(List<Player> players)
        {
            Console.WriteLine("Inicia Jogo");
            do
            {
                foreach(Player p in players)
                {
                    if(round_number <= 4)
                    {
                        p.MP = round_number;
                    }
                    else
                    {
                        p.MP = 5;
                    }
                }
                round_number++;
                Feiticos(players);
            }while(winner == null);
        }

        public void Tutorial()
        {
            Console.WriteLine("\nWelcome to The Reckoning! ");
            Console.WriteLine("\nIn this game you will have a deck of cards containing powerful creatures that will battle against each other! ");
            Console.ReadLine();
            Console.WriteLine("What would you like to learn first? \n: 1 - Battle \n: 2 - How to win ");
            
            int option = GetOptionChoice();

            if (option == 1)
            {
                Console.WriteLine("You choose 1. Here is the introduction to Battle: ");
                Console.WriteLine("You hit like pew pew and hit hard like pow pow ");
                // Display the message for choosing 1
                Console.ReadLine();
                
                Console.WriteLine("Would you like to know the other tutorial? (yes/no)" );
                string answer = Console.ReadLine();
                      
                
                if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Here is Option One: ...");
                }  

            }
            else if (option == 2)
            {
                Console.WriteLine("You choose 2. This is the second option.");
                Console.WriteLine("Would you like to know the other tutorial? (yes/no)" );
                string answer2 = Console.ReadLine();
                // Display the message for choosing 1
                // Display the message for choosing 2

                if (answer2.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Here is Option One: ...");
                }
            }
        
            static int GetOptionChoice()
            {
                int option;
                while (true)
                {
                    Console.Write("Enter your choice (1 or 2): ");
                    if (int.TryParse(Console.ReadLine(), out option) && (option == 1 || option == 2))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
                return option;
            }

        }
        private bool cartaValida = false;
        public void Feiticos(List<Player> players)
        {
            //Mostrar mão do jogador à vez e perguntar que carta quer jogar
            foreach(Player p in players)
            {
                int contador = 0;
                Console.WriteLine($"\nO {p.Name} tem {p.MP} de MP.");
                Console.WriteLine($"\n--- Mão do {p.Name}: ---");
                Console.WriteLine();
                // QUERO GUARDAR ATRAVÉS DE NUMEROS
                foreach(Carta c in p.HandPlayer)
                {
                    //controller.Draw(null);
                    contador++;
                    Console.WriteLine($"[{contador}] {c}");
                }
                bool valid = false;
                string answer = String.Empty;
                int index = 0;
                Carta choosenCard = null;
                // Validation Loop
                while(!valid)
                {
                    Console.WriteLine("\n--- Fase de Feitiços ---");
                    bool haveMana = false;
                    foreach(Carta c in p.HandPlayer)
                    {
                        if(c.MP <= p.MP)
                        {
                            haveMana = true;
                        }
                    }
                    if(!haveMana)
                    {
                        Console.WriteLine("Não consegue jogar mais nenhuma carta");
                        break;
                    }
                    Console.WriteLine("Que cartas quer jogar? (DICA: tenha em atenção o seu MP)");
                    answer = Console.ReadLine();

                    // Is number validation
                    valid = int.TryParse(answer, out index);
                    if(!valid)
                    {
                        Console.WriteLine("Input inválido");
                        continue;
                    }

                    // Index validation
                    try
                    {
                        index--;
                        choosenCard = p.HandPlayer[index];
                    }
                    catch (System.Exception)
                    {
                        valid = false;
                        Console.WriteLine("Index inválido");
                        continue;
                    }

                    // Mana validation
                    if(!(choosenCard.MP <= p.MP))
                    {
                        valid = false;
                        Console.WriteLine("Mana Insuficiente");
                        continue;
                    }
                    p.MP = p.MP - choosenCard.MP;
                    p.ChoosenCards.Enqueue(choosenCard);
                }
                //Console.WriteLine($"{choosenCard.Name} foi escolhida.");
            }
            Ataque(players);
        }
        private bool destruiu = false;
        public void Ataque(List<Player> players)
        {
            Console.WriteLine("\n--- Fase de Ataque ---");
            foreach(Player p in players)
            {
                foreach(Carta c in p.ChoosenCards)
                {
                    Console.WriteLine($"O {p.Name} escolheu a carta {c.Name}");
                }
            }
            
            do
            {
                Carta player1Card = players[0].ChoosenCards.Peek();
                Carta player2Card = players[1].ChoosenCards.Peek();

                Console.WriteLine("Antes");
                Console.WriteLine(player1Card.DP);
                Console.WriteLine(player2Card.DP);
                Console.WriteLine();

                player1Card.DP -= player2Card.AP;
                player2Card.DP -= player1Card.AP;
                
                Console.WriteLine("Depois");
                Console.WriteLine(player1Card.DP);
                Console.WriteLine(player2Card.DP);
                Console.WriteLine();

                if(player1Card.DP <= 0)
                {
                    destruiu = true;
                    Console.WriteLine($"A carta {player1Card.Name} foi destruida");
                    players[0].ChoosenCards.Dequeue();
                }
                if(player2Card.DP <= 0)
                {
                    destruiu = true;
                    Console.WriteLine($"A carta {player2Card.Name} foi destruida");
                    players[1].ChoosenCards.Dequeue();
                }

            }while(destruiu = false);
            Console.WriteLine();

        }

        public int MainMenu(Carta carta)
        {
            throw new NotImplementedException();
        }
        
        
    }
}
