using System;
using System.Collections.Generic;
using System.Threading;

class Lines
{
    public static void borekLine()
    {
        List<Guest> inBorekLine = new List<Guest>(Guests.getGuests());
        List<Guest> neverTakesBorek = new List<Guest>(Guests.getGuests());
        int index;
        Guest guest;
        bool fromNeverTakes = false;
        var rand = new Random();

        while (!Trays.isEmpty())
        {
            if (neverTakesBorek.Count != 0)
            {
                index = rand.Next(neverTakesBorek.Count);
                guest = neverTakesBorek[index];
                fromNeverTakes = true;
            }
            else
            {
                index = rand.Next(inBorekLine.Count);
                guest = inBorekLine[index];
            }
            if (Trays.totalBorek != 0 && Trays.borekInPlate > 0)
            {
                lock (guest)
                {
                    if (fromNeverTakes)
                    {
                        neverTakesBorek.RemoveAt(index);
                        fromNeverTakes = false;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(guest.name + " is going to take a borek");
                    guest.takenBorek++;
                    Trays.totalBorek--;
                    Trays.borekInPlate--;
                    Console.WriteLine(guest.name + " take a borek");
                    Console.WriteLine(guest.name + " is return\n");

                }
            }
            if (guest.takenBorek == 5)
            {
                inBorekLine.RemoveAt(index);
            }
            Thread.Sleep(rand.Next(1000, 4000));
        }
    }
    public static void cakeLine()
    {
        List<Guest> inCakeLine = new List<Guest>(Guests.getGuests());
        List<Guest> neverTakesCake = new List<Guest>(Guests.getGuests());
        bool fromNeverTakes = false;
        var rand = new Random();
        int index;
        Guest guest;

        while (!Trays.isEmpty())
        {
            if (neverTakesCake.Count != 0)
            {
                index = rand.Next(neverTakesCake.Count);
                guest = neverTakesCake[index];
                fromNeverTakes = true;
            }
            else
            {
                index = rand.Next(inCakeLine.Count);
                guest = inCakeLine[index];
            }

            if (Trays.totalCake != 0 && Trays.cakeInPlate > 0)
            {
                lock (guest)
                {
                    if (fromNeverTakes)
                    {
                        neverTakesCake.RemoveAt(index);
                        fromNeverTakes = false;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(guest.name + " is going to take a Cake");
                    guest.takenCake++;
                    Trays.totalCake--;
                    Trays.cakeInPlate--;
                    Console.WriteLine(guest.name + " take a Cake");
                    Console.WriteLine(guest.name + " is return\n");

                }
            }
            if (guest.takenCake == 2)
            {
                inCakeLine.RemoveAt(index);
            }
            Thread.Sleep(rand.Next(1000, 4000));
        }
    }
    public static void drinkLine()
    {
        List<Guest> inDrinkLine = new List<Guest>(Guests.getGuests());
        List<Guest> neverTakesDrink = new List<Guest>(Guests.getGuests());
        bool fromNeverTakes = false;
        var rand = new Random();
        int index;
        Guest guest;

        while (!Trays.isEmpty())
        {
            if (neverTakesDrink.Count != 0)
            {
                index = rand.Next(neverTakesDrink.Count);
                guest = neverTakesDrink[index];
                fromNeverTakes = true;

            }
            else
            {
                index = rand.Next(inDrinkLine.Count);
                guest = inDrinkLine[index];
            }


            if (Trays.totalDrink != 0 && Trays.drinkInPlate > 0)
            {
                lock (guest)
                {
                    if (fromNeverTakes)
                    {
                        neverTakesDrink.RemoveAt(index);
                        fromNeverTakes = false;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(guest.name + " is going to take a Drink");
                    guest.takenDrink++;
                    Trays.totalDrink--;
                    Trays.drinkInPlate--;
                    Console.WriteLine(guest.name + " take a Drink");
                    Console.WriteLine(guest.name + " is return\n");

                }
            }
            if (guest.takenDrink == 5)
            {
                inDrinkLine.RemoveAt(index);
            }
            Thread.Sleep(rand.Next(1000, 4000));
        }
    }
}