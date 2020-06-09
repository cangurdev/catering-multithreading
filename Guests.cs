using System.Collections.Generic;

class Guests
{
    static List<Guest> guests = new List<Guest>();

    public void addGuest(Guest guest)
    {
        guests.Add(guest);
    }
    public static List<Guest> getGuests()
    {
        return guests;
    }
    public static int getGuestsCount()
    {
        return guests.Count;

    }
    public static Guest getGuest(int index)
    {
        return guests[index];
    }
}