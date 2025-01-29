using Encapsulation;

public class Program
{
    /*
    private static List<string> _names = new();
    private static List<List<int>> _scores = new();
    private static List<string> _majors = new();
    */

    private static Dictionary<string, Student> _students = new();

    public static void Main(string[] args)
    {
        //LabRoom room = new() { Windows = false };
        LabRoom room = new(false);

        //drinks allowed
        //LabRoom.DrinksAllowed = true;


        //Bob, CS, 80/70/92
        /*
        _names.Add("Bob");
        _scores.Add(new List<int> { 80, 70, 92 });
        _majors.Add("CS");

        //what if our list had a bunch of students
        //how could we change major of Bob to MATH?
        int index = _names.IndexOf("Bob");
        _majors[index] = "MATH";*/


        Student s = new("Bob");
        s.Major = "CS";
        s.AddScore(40);

        _students["Bob"] = s;

        //add other students

        //change bob's major
        _students["Bob"].Major = "MATH";
    }
}