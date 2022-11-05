namespace Speedrunning_music_intensifies;

public class NumberData
{

    public static void SaveChange()
    {
        //TODO Understand what on earth thats suposed to mean
    }
    
    public static int PolyDice(int D)
    {
        Random rnd = new Random();
        return rnd.Next(0, D);
    }

    public static bool LeapYear(int year)
    {
        if (year % 400 == 0)
        { 
            return true;
        }else if (year % 100 == 0)
        {
            return false;
        }else if (year % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int DiceGame(int dice1, int dice2, int dice3)
    {
        int[] allDice = { dice1, dice2, dice3 };
        if (dice1 == dice2 && dice2 == dice3)
        {
            return 3;
        }
        if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
        {
            return allDice.GroupBy(i=>i).OrderByDescending(grp=>grp.Count()).Select(grp=>grp.Key).First() - allDice.GroupBy(i=>i).OrderByDescending(grp=>grp.Count()).Select(grp=>grp.Key).Last();
        }
        else
        {
            return 0;
        }
    }

    public static bool Devisible(double num1, double num2)
    {
        if (num2 == 0)
        {
            return false;
        }

        if (num1 % num2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void ElectricCar()
    {
        //TODO be arsed
    }
    
}