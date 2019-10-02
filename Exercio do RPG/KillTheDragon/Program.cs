using System;
using KillTheDragon.Models;

namespace KillTheDragon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool PlayerdontGiveUp = true;
            do{

                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("        Kill the Dragon!!!");
                Console.WriteLine("==============================");

                Console.WriteLine(" 1 - Start Game");
                Console.WriteLine(" 0 - Quit  Game ");

                string opctionPlayer = Console.ReadLine();

                switch (opctionPlayer)
                {

                    case "1":
                    Console.Clear();
                    Warrior warrior = new Warrior(); 
                    warrior.Name = "Haseid";
                    warrior.LastName = "Faerûn";
                    warrior.Hometown = "Brussel";
                    warrior.BirthDate = DateTime.Parse("07/05/1371");
                    warrior.AttackEquipment = "QuarterStaff";
                    warrior.ProtectionEquipment ="LigthShield";                    
                    warrior.Strong = 4;
                    warrior.Agility = 3;
                    warrior.Intelligence = 1;
                    warrior.Life = 20;

                    Dragon dragon = new Dragon();
                    dragon.Name = "Smaug";
                    dragon.Strong = 5;
                    dragon.Agility = 1;
                    dragon.Intelligence = 3;
                    dragon.Life = 300;

                    /* START - FIRST DIALOGUE */
                    System.Console.WriteLine($"{warrior.Name.ToUpper()}:{dragon.Name}, you Crazy! been  killing him!");
                    System.Console.WriteLine($"{dragon.Name.ToUpper()}: Human foolly.  who thinks it is? ");

                    System.Console.WriteLine();
                    System.Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    
                    /*END - FIRST DIALOGUE  */

                    /* START - SECOND DIALOGUE */
                    System.Console.WriteLine($"{warrior.Name.ToUpper()}: I am {warrior.Name}! From the House {warrior.LastName}, oh evil creature!");
                    System.Console.WriteLine($"{dragon.Name.ToUpper()}:WHO?? WHERE?? Good, whatever...  I will fry you and devour you, insolent ape!");

                    System.Console.WriteLine($"BAMBAM: Its show time!");

                    System.Console.WriteLine();
                    System.Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    /* END - SECOND DIALOGUE */
                    Console.Clear();

                    bool PlayerAttackFirts =  warrior.Agility > dragon.Agility ? true : false;
                    
                    int powerAttackWarrior = warrior.Strong > warrior.Intelligence ? warrior.Strong + warrior.Agility : warrior.Intelligence + warrior.Agility;
                    bool playerDontRun = true;

                    if(PlayerAttackFirts){
                        System.Console.WriteLine("*** Player Turn ***");
                        System.Console.WriteLine("Choose an Action");
                        System.Console.WriteLine(" 1 - Attack");
                        System.Console.WriteLine(" 2 - escape");

                        string optionBattlePlayer = Console.ReadLine();
                        
                        switch (optionBattlePlayer)
                        {
                            case "1":
                            Random generationRandomNumbers = new Random();
                            int NumberRandomPlayer = generationRandomNumbers.Next(0, 5);
                            int NumberRandomDragon = generationRandomNumbers.Next(0, 5);
                            int warriorAgilityTotal = warrior.Agility + NumberRandomPlayer;
                            int dragonAgilityTotal = dragon.Agility + NumberRandomDragon;

                            if (warriorAgilityTotal > dragonAgilityTotal) {
                                System.Console.WriteLine($"{warrior.Name.ToUpper()}: Take it!! Lizard disgusting.");
                                dragon.Life -= powerAttackWarrior + 5;
                                System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                            } else{
                                System.Console.WriteLine($"{dragon.Name.ToUpper()}: Missed , LittleBoy!! AHAHHAHAHA");
                        
                            }
                            
                            break;

                            case "2":
                            System.Console.WriteLine($"{warrior.Name.ToUpper()}: Let's Go!");
                            System.Console.WriteLine($"{dragon.Name.ToUpper()}: Run LittleBoy!! HAHAHAHAAHAH ");
                            playerDontRun = false;
                            break;
                            
                        }
                        
                    }

                    System.Console.WriteLine();
                    System.Console.WriteLine("Press ENTER to Continue");
                    Console.ReadLine();

                    while(warrior.Life > 0 && dragon.Life > 0 && playerDontRun)
                    {
                        Console.Clear();
                        System.Console.WriteLine("*** Dragon Turn ***");
                        Random generationRandomNumbers = new Random();
                            int NumberRandomPlayer = generationRandomNumbers.Next(0, 5);
                            int NumberRandomDragon = generationRandomNumbers.Next(0, 5);
                            int warriorAgilityTotal = warrior.Agility + NumberRandomPlayer;
                            int dragonAgilityTotal = dragon.Agility + NumberRandomDragon;

                            if (dragonAgilityTotal > warriorAgilityTotal) {
                                System.Console.WriteLine($"{dragon.Name.ToUpper()}: Burning you bastard!! ");
                                warrior.Life = warrior.Life - dragon.Strong;
                                System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                            } else{
                                System.Console.WriteLine($"{warrior.Name.ToUpper()}: is your fire going out!?");
                        
                            } 
                            
                    System.Console.WriteLine();
                    System.Console.WriteLine("Press ENTER to Continue");
                    Console.ReadLine();   

                    Console.Clear(); 

                    
                        System.Console.WriteLine("*** Player Turn ***");
                        System.Console.WriteLine("Choose an Action");
                        System.Console.WriteLine(" 1 - Attack");
                        System.Console.WriteLine(" 2 - escape");

                        string optionBattlePlayer = Console.ReadLine();
                        
                        switch (optionBattlePlayer)
                        {
                            case "1":
                            generationRandomNumbers = new Random();
                            NumberRandomPlayer = generationRandomNumbers.Next(0, 5);
                            NumberRandomDragon = generationRandomNumbers.Next(0, 5);
                            warriorAgilityTotal = warrior.Agility + NumberRandomPlayer;
                            dragonAgilityTotal = dragon.Agility + NumberRandomDragon;

                            if (warriorAgilityTotal > dragonAgilityTotal) {
                                System.Console.WriteLine($"{warrior.Name.ToUpper()}: Take it!! Lizard disgusting.");
                                dragon.Life -= powerAttackWarrior + 5;
                                System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                            } else{
                                System.Console.WriteLine($"{dragon.Name.ToUpper()}: Missed , LittleBoy!! AHAHHAHAHA");
                        
                            }
                            
                            break;

                            case "2":
                            System.Console.WriteLine($"{warrior.Name.ToUpper()}: Let's Go!");
                            System.Console.WriteLine($"{dragon.Name.ToUpper()}: Run LittleBoy!! HAHAHAHAAHAH ");
                            playerDontRun = false;
                            break;
                            
                        }
                    
                                       
                    }
                   
                    break;                    

                    case "0":
                    PlayerdontGiveUp = false;
                    System.Console.WriteLine("See you Later");
                    break;
                    
                    default:
                    System.Console.WriteLine("Invalid Command!");
                    break;
                }
            
            }while(PlayerdontGiveUp);

            
        }
    }
}
