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
            //random number generated within length of array
            //return string value at random number index
            string[] enemyTypes =
            {
                "tonberry",
                "cactuar",
                "giant spider",
                "pegasus with red eyes",
                "squirrel with absurdly sharp fangs",
                "rabbit with three eyes",
                "centaur",
                "panther",
                "three headed wolf"
            };
            
            Random rand = new Random();
            int enemySwitch = rand.Next(enemyTypes.Length);
            return enemyTypes[enemySwitch];
        }

        static string newRoom()
        {
            //array of room descriptions
            //random number generated within length of array
            //return string value at random number index
            string[] roomTypes =
            {
                "The room is so dark that you cannot see at all. \nYou feel a chill go through you as the wind whistles, \nas though you are in a long hallway.",
                "There is an altar in the middle of the room, with bones scattered around it.",
                "There is a bridge spanning from your side of the room to the other, above a floor of what appears to be lava. \nSome kind of fish is swimming through it, with what seem to be scales like thick armor. ",
                "When you enter the room, you feel sunshine on your face and feel a breeze. \nIt looks like you have entered a beautiful meadow, but there is absolute silence.\nYou speak to make sure you can still hear, and realize there is no echo. Something is wrong here."
            };
            Random rand = new Random();
            int roomSwitch = rand.Next(roomTypes.Length);
            return roomTypes[roomSwitch];
        } 

        static bool battle()
        {
            //TODO battle loop
            bool battleWin = true;
            return battleWin;
        }

        static void Main(string[] args)
        {
            Console.Title = "Final Fantasy: Text Edition";
            
            #region Title screen, Keypress, Screen Clear
            Console.WriteLine("\n\n -*-*-*-Final Fantasy: Text Edition-*-*-*");
            Console.WriteLine(" -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
            Console.WriteLine("        Do you dare enter...?");
            Console.WriteLine("     Press any key to continue.");
            Console.ReadKey(true);
            Console.Clear();
            #endregion

            #region Loop to contain all active game content while continueGame = true
            bool continueGame = true;
            do 
            {
                #region Do/While loop to get player name, Welcome message, Keypress
                //Weapon playerWeapon = new Weapon(10, 30, "High Steel Fork", 3, true, WeaponType.Polearm);
                //Player player = new Player(100, "Sarra", 80, 40, 100, Race.Viera, playerWeapon);
                //TODO: Generate player
                string playerName;
                string answer;
                do
                {
                    Console.Clear();
                    Console.WriteLine("What is your name? ");
                    playerName = Console.ReadLine();
                    Console.Write($"\nHello, {playerName}. Did I get your name right? (Y/N) ");
                    answer = Console.ReadLine().ToUpper();
                } while (answer != "Y" && answer != "YES");
                //Console.WriteLine($"\nWelcome, {playerName}!\nPress any key to proceed to the next room.");
                //Console.WriteLine("\n\n" + player + "\n\n");
                //Console.ReadKey(true);
                #endregion

                #region Screen Clear, Welcome to the game prior to first menu loop
                Console.Clear();
                Console.WriteLine("\n\nWelcome to Eorzea!\n");
                Console.WriteLine("It's time to fight your first battle!\n\n");
                #endregion

                #region Menu loop, Screen clear after selection is processed
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
                    Console.Clear();
                } while (repeatMenu); //menu will repeat by default
                #endregion

                continueGame = false;
                Console.WriteLine("Thank you for playing. Until next time.");
            } while (continueGame);
            #endregion
        }
    }
}
