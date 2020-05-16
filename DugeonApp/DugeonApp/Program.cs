using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DugeonLibary;
namespace DugeonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WELCOME TO THE DUGEON TRAIN!";
            Console.WriteLine("You find a train in the woods....\n You Enter.... ");

            //TODO Player needs to be finished being built 
            //TODO create a loop for the room 

            bool exit = false;

            do
            {
                var roomService = new RoomService();
                var room = roomService.GetRoom();
                Console.WriteLine(room.Description);
                Console.WriteLine($"You see a {room.RoomMonsters[0].Name}");
                //add logic 
                bool reload = false;

             

                do
                {
                    #region menu 
                    Console.WriteLine("\n Please Choose an Action\n "+
                        "A) Attack\n" +
                        "S) Player Status\n" +
                        "M) Monster Status\n" +
                        "R) RunAway\n" +
                        "X) Exit\n");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {

                        case ConsoleKey.A:
                            break;

                        case ConsoleKey.M:
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run AWAY.......! ! ! !");
                            Console.WriteLine();
                            break;
                        case ConsoleKey.S:
                            break;

                        case ConsoleKey.X:
                            break;

                        default:
                            break;
                    } //end switch
                    #endregion
                } while (!exit && !reload);

            } while (true);



        }

    } //end method

}