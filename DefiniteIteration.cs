namespace Speedrunning_music_intensifies;

public class DefiniteIteration
{
    public static int Factorial(int number)
    {
        for (int i = number-1; i > 0; i--)
        {
            number *= i;
        }

        return number;
    }

    public static void GreenBottles(int numberOfTimes)
    {
        for (int i = numberOfTimes; i > 0; i--)
        {
            Console.WriteLine(i + " green bottles hanging on the wall, \n"+i+" green bottles hanging on the wall\nAnd if one green bottle should accidently fall,\nThere'll be "+(i-1)+" green bottles hanging on the wall.\n");
        }
    }
    
    // TODO: Make text art of text, in the form of characters representing the same characters 

    public static int ScrabbleScore(string word)
    {
        int score = 0;

        for (int c = 0; c < word.Length; c++) //YOOOOOOOOO IT THAT A BETTER PROGRAMMING LANGUAGE??!!
        {
            if ("eaionrtlsu".Contains(word.ToLower()[c]))
            {
                score++;
            }else if ("dg".Contains(word.ToLower()[c]))
            {
                score += 2;
            }else if ("bcmp".Contains(word.ToLower()[c]))
            {
                score += 3;
            }else if ("fhvwy".Contains(word.ToLower()[c]))
            {
                score += 4;
            }else if ("k".Contains(word.ToLower()[c]))
            {
                score += 5;
            }else if ("jx".Contains(word.ToLower()[c]))
            {
                score += 8;
            }else
            {
                score += 10;
            }
        }
        
        return score;
    }

    public static bool IsPrime(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void PasscodeChallenge()
    {
        //TODO be bothered
    }
    
    
    
    
    
}