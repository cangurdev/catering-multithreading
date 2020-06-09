class Trays
{
    static public int totalBorek { get; set; } = 30;
    static public int totalDrink { get; set; } = 30;
    static public int totalCake { get; set; } = 15;
    static public int borekInPlate { get; set; } = 5;
    static public int drinkInPlate { get; set; } = 5;
    static public int cakeInPlate { get; set; } = 5;



    static public bool isEmpty()
    {
        return totalBorek == 0 && totalDrink == 0 && totalCake == 0;
    }

}