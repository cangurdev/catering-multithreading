using System;
using System.Threading;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest g1 = new Guest("Can");
            Guest g2 = new Guest("Ali");
            Guest g3 = new Guest("Burak");
            Guest g4 = new Guest("Polat");
            Guest g5 = new Guest("Memati");
            Guest g6 = new Guest("Abdulhey");
            Guest g7 = new Guest("Çakır");
            Guest g8 = new Guest("Elif");
            Guest g9 = new Guest("Fatih");
            Guest g10 = new Guest("Melda");

            Guests guests = new Guests();
            guests.addGuest(g1);
            guests.addGuest(g2);
            guests.addGuest(g3);
            guests.addGuest(g4);
            guests.addGuest(g5);
            guests.addGuest(g6);
            guests.addGuest(g7);
            guests.addGuest(g8);
            guests.addGuest(g9);
            guests.addGuest(g10);

            Thread borekLine = new Thread(new ThreadStart(Lines.borekLine));
            Thread cakeLine = new Thread(new ThreadStart(Lines.cakeLine));
            Thread drinkLine = new Thread(new ThreadStart(Lines.drinkLine));
            Thread waiter = new Thread(new ThreadStart(Waiter.serve));
            waiter.Priority = ThreadPriority.AboveNormal;

            borekLine.Start();
            cakeLine.Start();
            drinkLine.Start();
            waiter.Start();
        }
    }
}
