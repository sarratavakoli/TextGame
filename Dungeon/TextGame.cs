using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;



namespace Dungeon
{
    internal class TextGame
    {
        static string newEnemy()
        {
            //array of monster names
            string[] enemyTypes =
            {
                "giant spider",
                "pegasus with red eyes",
                "squirrel with absurdly sharp fangs",
                "rabbit with three eyes",
                "centaur",
                "panther",
                "three headed wolf"
            };

            //generate a random int to select a random item from the enemy array
            Random rand = new Random();
            int enemySwitch = rand.Next(enemyTypes.Length);

            //use the random number as index for enemy array
            //return string value for name
            return enemyTypes[enemySwitch];
        } //end NewEnemy() method

        static string newRoom()
        {
            //array of room descriptions
            string[] roomTypes =
            {
                "The room is so dark that you cannot see at all. \nYou feel a chill go through you as the wind whistles, \nas though you are in a long hallway.",
                "There is an altar in the middle of the room, with bones scattered around it.",
                "There is a bridge spanning from your side of the room to the other, above a floor of what appears to be lava. \nSome kind of fish is swimming through it, with what seem to be scales like thick armor. ",
                "When you enter the room, you feel sunshine on your face and feel a breeze. \nIt looks like you have entered a beautiful meadow, but there is absolute silence.\nYou speak to make sure you can still hear, and realize there is no echo. Something is wrong here."
            };

            //generate a random int to select an item from the room array
            Random rand = new Random();
            int roomSwitch = rand.Next(roomTypes.Length);

            //use the random number as index for room array
            //return string value for room description
            return roomTypes[roomSwitch];
        } //end NewRoom() method

        static bool battle()
        {
            bool battleWin = true;
            //TODO: calculate combat and return bool to indicate win or loss
            return battleWin;
        }

        static void Main(string[] args)
        {
            Console.Title = "Dungeon Game";
            #region title menu
            Console.WriteLine("\n\n -*-*-*-*-*-*Dungeon Game-*-*-*-*-*-*");
            Console.WriteLine(" -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
            Console.WriteLine("        Do you dare enter...?");
            Console.WriteLine("     Press any key to continue.");
            Console.ReadKey(true);
            Console.Clear();
            #endregion title menu
            //for do while loop for primary gameplay
            bool continueGame = true;
            do //this will continue while continueGame is true
            {
                //repeat value for player name menu
                bool repeat = true;
                string playerName = "";
                string answer = "N";
                
                //create a weapon
                Weapon playerWeapon = new Weapon(10, 30, "High Steel Fork", 3, true, WeaponType.Polearms);
                //create a player
                Player player = new Player(100, "New Player", 80, 40, 100, Race.viera, playerWeapon);
                //get player name 
                do
                {
                    Console.Clear();
                    Console.WriteLine("What is your name? ");
                    playerName = Console.ReadLine();
                    Console.Write($"\nHello, {playerName}. Did I get your name right? (Y/N) ");
                    answer = Console.ReadLine().ToUpper();
                } while (answer != "Y" && answer != "YES");
                Console.WriteLine("\nGreat!\nPress any key to proceed to the next room.");
                Console.ReadKey(true);
                //boolean counter variable for inner menu loop
                bool repeatMenu = true;
                //do while for menu loop
                do //true until repeatMenu is false
                {
                    //use method newRoom() to create a room
                    //use method EnemyName() to create a random enemy
                    //store the selections in room & enemy variables to reuse
                    string room = newRoom();
                    string enemy = newEnemy();
                    //TODO: call a method to generate a new enemy and store in a string value

                    Console.Clear();
                    Console.WriteLine($"There is a {enemy} standing before you, and it seems ready to fight.");
                    Console.WriteLine($"You look at the {enemy} and evaluate your options. What will you do? \n\n");
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1) Attack");
                    Console.WriteLine("2) Run Away");
                    Console.WriteLine("3) Character Info");
                    Console.WriteLine("4) Enemy Info");
                    Console.WriteLine("5) Exit\n\n");

                    //get user menu selection as a console key
                    ConsoleKey menuSelection = Console.ReadKey(true).Key;

                    //provide result based on selection
                    switch (menuSelection)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            Random rand = new Random();
                            //bool battleWin = battle();
                            //battle method
                            if (battle())
                            {
                                Console.WriteLine("You win.");
                                Console.Write("Press any key to proceed to the next room. ");
                            }
                            else
                            {
                                Console.WriteLine("You lost.");
                                Console.WriteLine("GAME OVER.\n\n\n\n");
                                repeatMenu = false;
                            }
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            Console.WriteLine("You ran away successfully, to another room.");
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            Console.WriteLine($"You are a human named {playerName}, on a perilous adventure.");
                            break;
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            Console.WriteLine($"You are fighting a {enemy}");
                            break;
                        case ConsoleKey.NumPad5:
                        case ConsoleKey.D5:
                            repeatMenu = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid selection (1-5).\nPress any key to try again.");
                            break;
                    }
                    
                    //get key press to proceed                        
                    Console.ReadKey(true);

                } while (repeatMenu); //menu will repeat by default

                //break out of game loop
                continueGame = false;
                Console.WriteLine("Thank you for playing. Until next time.");
            } while (continueGame);
        }
    }
}
