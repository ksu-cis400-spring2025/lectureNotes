using Encapsulation;

public class Program
{
    private static List<string> _names;
    private static List<List<int>> _scores;
    private static List<string> _majors;

    public static void Main(string[] args)
    {
        //LabRoom room = new() { Windows = false };
        LabRoom room = new(false);

        //drinks allowed
        //LabRoom.DrinksAllowed = true;


        _names = new();
        _scores = new();
        _majors = new();

        //how to store this info?
        //Bob, CS, 80/70/92
        //Jill, CMPEN, 95/68/88

        //how could we change major of Bob to MATH?
    }

    public static void ChangeMajor(string name, string newMajor)
    {
        throw new NotImplementedException();
    }
}