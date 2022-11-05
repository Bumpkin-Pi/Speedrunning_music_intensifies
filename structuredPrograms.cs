using System.Diagnostics;

namespace Speedrunning_music_intensifies;

public class structuredPrograms
{
    public static void dice()
    {
        Console.WriteLine("ooooooooooo\no         o\no  #   #  o\no    #    o\no  #   #  o\no         o\nooooooooooo");
    }

    public static double tempConverter(double C)
    {
        //Console.WriteLine((C * 1.8) + 32);
        return (C * 1.8) + 32;
    }
    
    public class CharProblem
    {
        public static void DisplayDigits()
        {
            Console.WriteLine("The digits are: 0123456789");
        }
        public static void DisplayCharacters()
        {
            Console.WriteLine("The characters are: abcdABCD@#!£");
        }
        public static void DisplayAlphaNumeric()
        {
            Console.WriteLine("The AlphaNumeric are: ");
            DisplayCharacters();
            DisplayDigits();
        }
    }

    public static double FishTank(double height, double length, double depth)
    {
        return (height * length * depth) / 1000;
    }

    public static double EnergyBill(double previousReading, double currentReading, double calorificValue)
    {
        double kWh = (currentReading - previousReading) * 1.022 * (calorificValue / 3.6);
        return kWh * 0.0284;
    }

    public static void circleProps(double diameter, double arcAngle)
    {
        Console.WriteLine("R  = " + diameter/2);
        Console.WriteLine("A  = " + Math.Pow((diameter/2), 2)*Math.PI);
        Console.WriteLine("C  = "+diameter*Math.PI);
        Console.WriteLine("AL = "+ (diameter*Math.PI) * arcAngle / 360);
    }


}

