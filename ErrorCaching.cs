namespace Speedrunning_music_intensifies;

public class ErrorCaching
{
    public static void DaysOfTheWeek()
    {
        try
        {
            int x = int.MaxValue;
            x++;
            //Do that thing will crash, look come on, its a try catch block. give me a break.
        }
        catch
        {
            Console.WriteLine("Damn, it broke. Im shocked");
        }
    }
    
    //TODO be bothered
}