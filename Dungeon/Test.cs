using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("First Name | Last Name  |   Age");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Bill", "Gates", 51));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Edna", "Parker", 114));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Johnny", "Depp", 44));
            Console.WriteLine("-------------------------------");



            string dragon = @"
                                                         ,--,  ,.-.
                           ,                   \,       '-,-`,'-.' | ._
                          /|           \    ,   |\         }  )/  / `-,',
                          [ ,          |\  /|   | |        /  \|  |/`  ,`
                          | |       ,.`  `,` `, | |  _,...((      .',
                          \  \  __, -` `  ,  , `/ |, '      Y     (   /_L\
                           \  \_\,``,   ` , ,  /  |         )         _,/
                            \  '  `  ,_ _`_,-,<._.<        /         /
                             ', `>.,`  `  `   ,., |_      |         /
                               \/`  `,   `   ,`  | /__,.-`    _,   `\
                           -,-..\  _  \  `  /  ,  / `._) _,-\`       \
                            \_,,.) /\    ` /  / ) (-,, ``    ,        |
                           ,` )  | \_\       '-`  |  `(               \
                          /  /```(   , --, ,' \   |`<`    ,            |
                         /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)
                   ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`
                  (-, \           ) \ ('_.-._)/ /,`    /
                  | /  `          `/ \\ V   V, /`     /
               ,--\(        ,     <_/`\\     ||      /
              (   ,``-     \/|         \-A.A-`|     /
             ,>, _ )_,..()\          -,, _-`  _--`
            (_ \|`   _,/_  /  \_,--`
             \( `   <.,../`     `-.._   _,-`
                 ";



            Console.WriteLine(dragon);
        }
    }
}
