namespace Speedrunning_music_intensifies;

public class oneDArray
{
    public static void NoteBook()
    {
        string input;
        string input2;
        string[] notebook = {"", "", "", "", "", "", "", "", "", ""};
        while (true)
        {
            Console.WriteLine("Select a page [0-9]:");
            input = Console.ReadLine();
            
            Console.WriteLine("1: Read\n2: Write\n>");
            input2 = Console.ReadLine();
            if (input2 == "1")
            {
                Console.WriteLine(notebook[int.Parse(input)]);
            }
            else
            {
                notebook[int.Parse(input)] = Console.ReadLine();
            }
        }
    }

    private static string[] stations = { "Brixton", "Stockwell", "Vauxhall", "Pimlico", "Victoria", "Green Park", "Oxford Circus", 
        "Warren Street", "Euston", "King's Cross", "Highbury & Islington", "Finsbury Park", "Seven Sisters", "Tottenham Hale", "Blackhorse Road and Walthamstow Central"};

    public static int Underground(string place1, string place2)
    {
        return Math.Abs(Array.FindIndex(stations, x => x.Contains(place1)) -
                        Array.FindIndex(stations, x => x.Contains(place2)));
    }
}