class Guest
{
    public int takenBorek { get; set; }
    public int takenDrink { get; set; }
    public int takenCake { get; set; }
    public string name { get; set; }
    public Guest(string Name)
    {
        name = Name;
        takenBorek = 0;
        takenDrink = 0;
        takenCake = 0;
    }

}