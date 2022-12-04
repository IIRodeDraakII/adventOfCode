
public class Day1
{
    public static void Run()
    {
        var InputVariable = File.ReadAllText("inputFiles/Day1.txt").Split("\r\n\r\n").ToList().Select(x => x.Split( "\r\n").Select(y => int.Parse(y)).Sum()).ToList();
        System.Console.WriteLine(InputVariable.Max());
        System.Console.WriteLine(InputVariable.OrderByDescending(x => x).Take(3).Sum());
    }
}
