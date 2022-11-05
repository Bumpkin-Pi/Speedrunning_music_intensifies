namespace Speedrunning_music_intensifies;

public class lists
{
    private List<string> inventory = new List<string>();

    public void pick(string item)
    {
        inventory.Add(item);
    }

    public void drop(string item)
    {
        inventory.Remove(item);
    }

    public string pull()
    {
        var random = new Random();
        int index = random.Next(inventory.Count);
        return (inventory[index]);
    }
    
    //Brain damage
}