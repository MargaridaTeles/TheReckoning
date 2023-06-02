using System;
using System.Collections.Generic;

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

        public void ShowCards(IEnumerable<Carta> cartas)
        {
            Console.WriteLine();
            foreach (Carta c in cartas)
            {
                Console.WriteLine($"-> {c}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        private int round_number = 1;
        public void Start(List<Player> players)
        {
            
            Console.WriteLine("Inicia Jogo");
            //Nos turnos 1 a 4 cada jogador tem MP igual a 1 até 4;
            //A partir do turno 5 e os seguintes o MP = 5;
            //Se o jogador tiver - de 6 cartas na mão vai tirar do topo do baralho.
            foreach(Player p in players)
            {
                p.HandPlayer = controller.Draw(p.Deck_cartas);

                if(round_number <= 4)
                {
                    p.MP = round_number;
                    Console.WriteLine("MP igual a ronda");
                    Console.WriteLine(p.MP);
                }
                else
                {
                    p.MP = 5;
                    Console.WriteLine("MP diferente da ronda");
                    Console.WriteLine(p.MP);
                }
            }
            round_number++;
            Feiticos();
        }

        public void Tutorial()
        {
            Console.WriteLine("\n Welcome to The Reckoning! ");
            Console.WriteLine("\n In this game you will have a deck of cards containing powerful creatures that will battle against each other! ");
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
                Console.WriteLine(" Would you like to know the other tutorial? (yes/no)" );
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

        public void Feiticos()
        {
            //string userInput;
            Console.WriteLine("--- Fase de Feitiços ---");
            Console.WriteLine("Quantas cartas quer jogar? (DICA: tenha em atenção o seu MP)");
            /*  COLOCAR NO CONTROLLER
            do
            {
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("1 Carta");
                        Ataque();
                        break;
                    case "2":
                        Console.WriteLine("2 Carta");
                        Ataque();
                        break;
                    default:
                        Console.WriteLine("Insira um valor possivel");
                        break;
                }
            }
            while (userInput != "0");*/
        }
        public void Ataque()
        {
            Console.WriteLine("\n--- Fase de Ataque ---");
            
        }

        public int MainMenu(Carta carta)
        {
            throw new NotImplementedException();
        }
    }
}
