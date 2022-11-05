using Microsoft.VisualBasic.CompilerServices;

namespace Speedrunning_music_intensifies;

public class StringData
{
    public static bool Tweet(string post)
    {
        if (post.Length > 20)
        {
            return false;
        }
        return true;
        
    }

    private static string inventory = "Sword, Sheild, Potion, Amulet";

    public static bool Inventory(string item)
    {
        if (inventory.Contains(item))
        {
            return true;
        }

        return false;
    }

    private static bool VerifyEmail(string email)
    {
        if (email.Contains(".") && email.Contains("@"))
        {
            return true;
        }

        return false;
    }

    private static string[] NameSplit(string name)
    {
        return name.Split();
    } 
    
    private static byte ASCIItoEBBCDIC(char letter)
    {
        //TODO descover who asked
        return 0;
    }
}