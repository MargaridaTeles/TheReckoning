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

        /// <summary>
        /// Menu onde o jogador vai poder aceder ao Tutorial, 
        /// começar a jogar ou então fechar o jogo
        /// </summary>
        /// <returns></returns>
        public int MainMenu()
        {
            Console.WriteLine("Bem vindo ao The Reckoning\nPor favor clica enter para o menu!");
            Console.ReadLine();
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Jogar");
            Console.WriteLine("2. Como Jogar ");
            Console.WriteLine("0. Sair");
            Console.WriteLine("");
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Caso o jogador não insira nenhuma das opções então mostra esta mensagem
        /// </summary>
        public void InvalidOption()
        {
            Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        private int round_number = 1;
        /// <summary>
        /// Inicializa o jogo, com as rondas e com as fases pedidas
        /// </summary>
        /// <param name="players">Lista de players</param>
        public void Start(List<Player> players)
        {
            bool winner = false;
            controller.FinishGame(players, winner);
            Console.WriteLine("--- Iniciar Jogo ---");
            while(winner == false)
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

                    if(round_number > 1)
                    {   
                        Console.WriteLine($"-----------------\n");

                        Console.WriteLine($"{p.Name} Pretende desistir? [S/N]");
                        string resposta = Console.ReadLine();
                        if(resposta == "S")
                        {
                            Console.WriteLine($"O {p.Name} desistiu.\n");
                            Environment.Exit(0);
                        }
                        else 
                            continue;
                    }
                }
                round_number++;
                Feiticos(players);
                BuyingPhase(players);

            }
        }
        /// <summary>
        /// Mostra o Tutorial
        /// </summary>
        public void Tutorial()
        {
            Console.WriteLine("\nBem vindo ao The Reckoning! ");
            Console.WriteLine("\nNesta partida cada um dos jogadores possui um deck de vinte monstros poderosos! ");
            Console.ReadLine();
            Console.WriteLine("O que gostaria de aprender primeiro \n: 1 - Fase de Feitiços \n: 2 - Fase de Batalha \n ");
            
            int option = GetOptionChoice();

            if (option == 1)
            {
                Console.WriteLine("\nA primeira fase de feitiços começa com o jogador já com 1 de MP, a partir dai pode escolher qual das 6 cartas iniciais pode jogar, se tiver MP suficientes. ");
                Console.ReadLine();
                Console.WriteLine("Depois de escolher é a vez do segundo jogador fazer o mesmo. A partir da primeira fase combate, todos os jogadores vao receber mais 1 de MP até á quinta ronda ");
                // Display the message for choosing 1
                Console.ReadLine();
                
                Console.WriteLine("Gostarias de ler o segundo toturoial? (sim/nao)" );
                string answer = Console.ReadLine();
                      
                
                if (answer.Equals("sim", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nOpção 2 - Fase de batalha:\n ");
                    Console.WriteLine("Na fase de batalha os jogadores combatem com as cartas que escolheram anteriormente na fase de feitiços.");
                    Console.ReadLine();
                    Console.WriteLine("Cada carda tem três parâmetros específicos. MP ou Mana points, DP ou defense points e AP ou attack points. Os mana points são o que cada carta custa para puder ser jogada, logo se um jogador não tiver mana suficiente, não pode jogar a carta");
                    Console.ReadLine();
                    Console.WriteLine("Se uma carta atacar diretamente um jogador que não tenha cartas, o AP da carta atacante é subtraído á vida total do jogador (ambos os jogadores têm dez pontos de vida total)");
                    Console.ReadLine();
                    Console.WriteLine("Se ambos os jogadores escolheram uma carta então o AP do das cartas é subtraído aos seus defense points (DP). Se o DP de uma carta chegar a zero então essa carda é destruída e retirada de jogo");
                    Console.ReadLine();
                    Console.WriteLine("Se uma carta tem 4 de AP e a carta que defende tem 2 de DP, a carta que defende morre e os restantes 2 de AP são subtraídos ao HP do jogador. Após a batalha os jogadores podem escolher se querem desistir da partida");
                    Console.ReadLine();
                }  

            }
            else if (option == 2)
            {
                Console.WriteLine("\nNa fase de batalha os jogadores combatem com as cartas que escolheram anteriormente na fase de feitiços.");
                Console.ReadLine();
                Console.WriteLine("Cada carda tem três parâmetros específicos. MP ou Mana points, DP ou defense points e AP ou attack points. Os mana points são o que cada carta custa para puder ser jogada, logo se um jogador não tiver mana suficiente, não pode jogar a carta");
                Console.ReadLine();
                Console.WriteLine("Se uma carta atacar diretamente um jogador que não tenha cartas, o AP da carta atacante é subtraído á vida total do jogador (ambos os jogadores têm dez pontos de vida total)");
                Console.ReadLine();
                Console.WriteLine("Se ambos os jogadores escolheram uma carta então o AP do das cartas é subtraído aos seus defense points (DP). Se o DP de uma carta chegar a zero então essa carda é destruída e retirada de jogo");
                Console.ReadLine();
                Console.WriteLine("Se uma carta tem 4 de AP e a carta que defende tem 2 de DP, a carta que defende morre e os restantes 2 de AP são subtraídos ao HP do jogador. Após a batalha os jogadores podem escolher se querem desistir da partida");
                Console.ReadLine();                
                Console.WriteLine("Gostaria de ler o primeiro tutorial? (sim/nao)" );
                string answer2 = Console.ReadLine();
                // Display the message for choosing 1
                // Display the message for choosing 2

                if (answer2.Equals("sim", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Opção 1 - Fase de feitiços: \n");
                    Console.ReadLine();
                    Console.WriteLine("A primeira fase de feitiços começa com o jogador já com 1 de MP, a partir dai pode escolher qual das 6 cartas iniciais pode jogar, se tiver MP suficientes. ");
                    Console.ReadLine();
                    Console.WriteLine("Depois de escolher é a vez do segundo jogador fazer o mesmo. A partir da primeira fase combate, todos os jogadores vao receber mais 1 de MP até á quinta ronda ");
                    // Display the message for choosing 1
                    Console.ReadLine();

                }
            }
        
            static int GetOptionChoice()
            {
                int option;
                while (true)
                {
                    Console.Write("Digite a sua resposta (1 ou 2): ");
                    if (int.TryParse(Console.ReadLine(), out option) && (option == 1 || option == 2))
                    {
                        break;
                    }
                    Console.WriteLine("Escolha inválida. Escolha 1 ou 2.");
                }
                return option;
            }

        }
        /// <summary>
        /// Fase de Feitiços, onde o jogador vai poder escolher a carta que quer jogar
        /// verificando se tem mana suficiente para isso.
        /// </summary>
        /// <param name="players">Lista de players</param>
        public void Feiticos(List<Player> players)
        {
            //Mostra mão do jogador à vez e perguntar que carta quer jogar
            foreach(Player p in players)
            {
                int contador = 0;
                Console.WriteLine($"\nO {p.Name} tem {p.MP} de MP e {p.HP} de HP.");
                Console.WriteLine($"\n--- Mão do {p.Name}: ---");
                Console.WriteLine();
                foreach(Carta c in p.HandPlayer)
                {
                    contador++;
                    Console.WriteLine($"[{contador}] {c}");
                }
                bool                     valid = false;
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
            }
            // Próxima fase
            Ataque(players);
        }
        private bool destruiu = false;
        /// <summary>
        /// Fase de Ataque, onde vai mostrar as cartas escolhidas na fase anterior
        /// e batalhar entre elas, atualiza o HP da carta
        /// </summary>
        /// <param name="players"></param>
        public void Ataque(List<Player> players)
        {
            Carta player1Card;
            Carta player2Card;
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
                player1Card = players[0].ChoosenCards.Peek();
                player2Card = players[1].ChoosenCards.Peek();

                player1Card.DP -= player2Card.AP;
                player2Card.DP -= player1Card.AP;

                if(player1Card.DP <= 0)
                {
                    destruiu = true;
                    Console.WriteLine($"\nA carta {player1Card.Name} foi destruida");
                    players[0].ChoosenCards.Dequeue();
                    players[0].HandPlayer.Remove(player1Card);
                }
                else if(player2Card.DP <= 0)
                {
                    destruiu = true;
                    Console.WriteLine($"\nA carta {player2Card.Name} foi destruida");
                    players[1].ChoosenCards.Dequeue();
                    players[1].HandPlayer.Remove(player2Card);
                }

            }while(destruiu == false);

            if(players[0].ChoosenCards.Count > 0 && players[1].ChoosenCards.Count <= 0)
            {
                players[1].HP = player1Card.AP;
            }
            else if(players[1].ChoosenCards.Count > 0 && players[0].ChoosenCards.Count <= 0)
            {
                players[0].HP = player2Card.AP;
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Fase em que o jogador decide se quer comprar carta ou não, caso já não
        /// se encontre com 6 cartas na mão
        /// </summary>
        /// <param name="players">Lista de players</param>
        public void BuyingPhase(List<Player> players)
        {
            foreach(Player p in players)
            {                    
                Console.WriteLine($"-----------------\n");
                Console.WriteLine($"{p.Name} deseja comprar carta? [S/N]");
                string resposta = Console.ReadLine();
                if(resposta == "S")
                {
                    Carta c = p.Deck[0];
                    p.HandPlayer.Add(c);
                    p.Deck.Remove(c);
                    Console.WriteLine($"O {p.Name} comprou a carta {c}.\n");
                }
                else if(resposta == "N")
                {
                    Console.WriteLine($"O {p.Name} não comprou carta.\n");
                }
            }
           
        }

        public int MainMenu(Carta carta)
        {
            throw new NotImplementedException();
        }
        
        
    }
}
