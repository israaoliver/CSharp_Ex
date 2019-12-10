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
                    
                    Warrior warrior = CharacterMaker();

                    Dragon dragon = new Dragon();
                    dragon.Name = "Smaug";
                    dragon.Strong = 5;
                    dragon.Agility = 1;
                    dragon.Intelligence = 3;
                    dragon.Life = 300;

                    /* START - FIRST DIALOGUE */

                    DialogueMaker(warrior.Name, $"{dragon.Name}, you Crazy! been  killing him!");
                    DialogueMaker(dragon.Name, "Human foolly.  who thinks it is?");

                    DialogueEnd();
                    
                    /*END - FIRST DIALOGUE  */

                    /* START - SECOND DIALOGUE */
                    DialogueMaker(warrior.Name, $"I am {warrior.Name}! From the House {warrior.LastName}, oh evil creature!");
                    DialogueMaker(dragon.Name, $"WHO?? WHERE?? Good, whatever...  I will fry you and devour you, insolent ape!");
                    System.Console.WriteLine($"BAMBAM: Its show time!");

                    DialogueEnd();
                    /* END - SECOND DIALOGUE */
                    Console.Clear();

                    bool PlayerAttackFirts =  warrior.Agility > dragon.Agility ? true : false;
                    
                    int powerAttackWarrior = warrior.Strong > warrior.Intelligence ? warrior.Strong + warrior.Agility : warrior.Intelligence + warrior.Agility;
                    bool playerDontRun = true;

                    Random generationRandomNumbers = new Random();
                    int NumberRandomPlayer = generationRandomNumbers.Next(0, 5);
                    int NumberRandomDragon = generationRandomNumbers.Next(0, 5);
                    int warriorAgilityTotal = warrior.Agility + NumberRandomPlayer;
                    int dragonAgilityTotal = dragon.Agility + NumberRandomDragon;
                    

                    if(PlayerAttackFirts){
                        System.Console.WriteLine("*** Player Turn ***");
                        System.Console.WriteLine("Choose an Action");
                        System.Console.WriteLine(" 1 - Attack");
                        System.Console.WriteLine(" 2 - Escape");

                        string optionBattlePlayer = Console.ReadLine();
                        
                        switch (optionBattlePlayer)
                        {
                            case "1":
                            if (warriorAgilityTotal > dragonAgilityTotal) {

                                DialogueMaker(warrior.Name, "Take it!! Lizard disgusting.");
                                dragon.Life -= powerAttackWarrior + 5;
                                System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                            } else{
                                DialogueMaker(warrior.Name, "Missed , LittleBoy!! AHAHHAHAHA"  );
                            }
                            
                            break;

                            case "2":
                            DialogueMaker(warrior.Name, "Let's Go!");
                            DialogueMaker(dragon.Name, $"Run LittleBoy!! HAHAHAHAAHAH ");
                            playerDontRun = false;
                            break;
                            
                        }
                        
                    }

                    DialogueEnd();

                    while(warrior.Life > 0 && dragon.Life > 0 && playerDontRun)
                    {
                        generationRandomNumbers = new Random();
                        NumberRandomPlayer = generationRandomNumbers.Next(0, 5);
                        NumberRandomDragon = generationRandomNumbers.Next(0, 5);
                        warriorAgilityTotal = warrior.Agility + NumberRandomPlayer;
                        dragonAgilityTotal = dragon.Agility + NumberRandomDragon;
                        Console.Clear();
                        System.Console.WriteLine("*** Dragon Turn ***");
                            if (dragonAgilityTotal > warriorAgilityTotal) {
                                DialogueMaker(dragon.Name, "Burning you bastard!!");
                                warrior.Life = warrior.Life - dragon.Strong;
                                System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                            } else{
                                DialogueMaker(warrior.Name, "is your fire going out!?");
                                System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                        
                            } 

                        DialogueEnd();

                        System.Console.WriteLine("*** Player Turn ***");
                        System.Console.WriteLine("Choose an Action");
                        System.Console.WriteLine(" 1 - Attack");
                        System.Console.WriteLine(" 2 - Escape");

                        string optionBattlePlayer = Console.ReadLine();
                        
                        switch (optionBattlePlayer)
                        {
                            case "1":
                                if (warriorAgilityTotal > dragonAgilityTotal) {
                                    DialogueMaker(warrior.Name, "Take it!! Lizard disgusting.");
                                    dragon.Life -= powerAttackWarrior + 5;
                                    System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                    System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                                    Console.ReadLine();
                                    
                                } else{
                                    DialogueMaker(dragon.Name, " Missed , LittleBoy!! AHAHHAHAHA");
                                    System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                    System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                                    Console.ReadLine();
                                    
                            
                                }
                            
                            break;

                            case "2":
                            DialogueMaker(warrior.Name, "Let's Go!");
                            DialogueMaker(dragon.Name, $"Run LittleBoy!! HAHAHAHAAHAH ");
                            playerDontRun = false;
                            break;
                            
                        }

                        DialogueEnd();
                    
                    } 

                    if(warrior.Life <= 0){
                        System.Console.WriteLine("GAME OVER!");
                        System.Console.WriteLine("Press ENTER to Continue");
                        Console.ReadLine();
                    }
                    if(dragon.Life <= 0){
                        System.Console.WriteLine("YOU WIN!!");
                        System.Console.WriteLine("CONGRATULATIONS");
                        System.Console.WriteLine("Press ENTER to Continue");
                        Console.ReadLine();
                    }
                    break;  

                    /**
                     * todo: Exemplo de alerta pendente
                     * ! Exemplo de alerta urgente
                     */                  

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

    public static void DialogueMaker(String name, string phrase)
        {
        
            System.Console.WriteLine($"{name.ToUpper()}:{phrase}");

        }
    
    public static void DialogueEnd()
    {

        System.Console.WriteLine();
        System.Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
        Console.Clear();

    }

    public static Warrior CharacterMaker()
    {
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

        return warrior;
    }

    }
}
