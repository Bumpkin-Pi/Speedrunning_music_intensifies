namespace Speedrunning_music_intensifies;

public class indefiniteIteration
{
    public static int CompoundInterest(double inisial, double desired, double interestRate)
    {
        int years = 0;
        while (inisial < desired)
        {
            inisial += inisial * interestRate;
            years++;
        }

        return years;
    }

    public static void CarValue()
    {
        //TODO im lazy, that is effort
    }

    public static int LotterChallenge(int[] numbers)
    {
        Random rnd = new Random();
        int weeks = 0;
        while (true)
        {
            weeks++;
            if (numbers[0] == rnd.Next(0, 30) && numbers[1] == rnd.Next(0, 30) && numbers[2] == rnd.Next(0, 30))
            {
                break;
            }
        }

        return weeks;
    }

    public static double Sqrt(double number)
    {
        return Math.Sqrt(number); // Anyone who complains can shut it.
    }

    public static string ToBinary(int number)
    {
        return Convert.ToString(number, 2);
    }


    public static void HappyNumber()
    {
        //TODO be bothered
    }
    
    
}