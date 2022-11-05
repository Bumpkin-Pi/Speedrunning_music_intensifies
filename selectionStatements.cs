namespace Speedrunning_music_intensifies;

public class selectionStatements
{

    public static void StateOfWater(decimal temp)
    {
        if (temp >= 100)
        {
            Console.WriteLine("Gaseous");
        }
        else if (temp >= 1)
        {
            Console.WriteLine("Liquid");
        }
        else
        {
            Console.WriteLine("Solid");
        }
    }

    public static string DrivingTest(int MinorFaults)
    {
        if (MinorFaults < 16)
        {
            Console.WriteLine("Pass");
            return "Pass";
        }
        else
        {
            Console.WriteLine("Fail");
            return "Fail";
        }
    }

    public static int Max(int int1, int int2)
    {
        return Math.Max(int1, int2);
    }


    private const double GBPtoUSD = 1.233; // Im lazy, give me a break
    private const double GBPtoEU = 1.15;
    private const double GBPtoYEN = 134.2;
    private const double GBPtoYUAN = 133.2;

    public static double CurrencyConverter(double GBP, string Curency)
    {
        if (Curency == "USD")
        {
            return GBP * GBPtoEU;
        }
        else if (Curency == "EU")
        {
            return GBP * GBPtoEU;
        }
        else if (Curency == "YEN")
        {
            return GBP * GBPtoYEN;
        }
        else if (Curency == "YUAN")
        {
            return GBP * GBPtoYUAN;
        }
        else
        {
            return -1;
        }
    }

    public static double NitrateDose(double niterate)
    {
        if (niterate > 10)
        {
            return 3;
        }

        if (niterate > 2.5)
        {
            return 2;
        }

        if (niterate > 1)
        {
            return 1;
        }
        else
        {
            return 0.5;
        }
    }

    public static void PeriodicTable()
    {
        //TODO: Care enough
    }

    private static string[] day = {
        "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
    };
    private static string[] shortDay = {
        "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"
    };
    private static string[] charDay = {
        "M", "Tu", "W", "Th", "F", "Sa", "Su"
    };
    
    public static string DayProblem(int dayNo, string type)
    {
        if (type == "day")
        {
            return day[dayNo];
        }else if (type == "shortday")
        {
            return shortDay[dayNo];
        }else
        {
            return charDay[dayNo];
        }
    }
}