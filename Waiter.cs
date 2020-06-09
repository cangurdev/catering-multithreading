using System;
using System.Threading;

class Waiter
{
    static public void serve()
    {
        while (!Trays.isEmpty())
        {

            if (Trays.borekInPlate <= 1 && Trays.totalBorek != 0 && !(Trays.borekInPlate == Trays.totalBorek))
            {
                Console.WriteLine("The waiter is going to fill the borek tray...");

                if (Trays.totalBorek > 4)
                {
                    Trays.borekInPlate = 5;

                }
                else
                {
                    Trays.borekInPlate = Trays.totalBorek;
                }
                Console.WriteLine("The waiter is return..\n");

            }
            else if (Trays.drinkInPlate <= 1 && Trays.totalDrink != 0 && !(Trays.drinkInPlate == Trays.totalDrink))
            {
                Console.WriteLine("The waiter is going to fill the drink tray...");

                if (Trays.totalDrink > 4)
                {
                    Trays.drinkInPlate = 5;
                }
                else
                {
                    Trays.drinkInPlate = Trays.totalDrink;
                }
                Console.WriteLine("The waiter is return..\n");

            }
            else if (Trays.cakeInPlate <= 1 && Trays.totalCake != 0 && !(Trays.cakeInPlate == Trays.totalCake))
            {
                Console.WriteLine("The waiter is going to fill the cake tray...");

                if (Trays.totalCake > 4)
                {
                    Trays.cakeInPlate = 5;
                }
                else
                {
                    Trays.cakeInPlate = Trays.totalCake;
                }
                Console.WriteLine("The waiter is return..\n");

            }
            Thread.Sleep(2000);
        }
        Console.ResetColor();
        foreach (var guest in Guests.getGuests())
        {
            Console.WriteLine(guest.name + "\nBorek: {0} Drink: {1} Cake: {2}", guest.takenBorek, guest.takenDrink, guest.takenCake);
            Console.WriteLine("*****************************");
        }

    }

}
