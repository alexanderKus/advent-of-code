namespace aoc.day2;

public class DayTwo
{
    private Dictionary<string, string> _winScenario = new()
    {
        { "A", "Y" },
        { "B", "Z" },
        { "C", "X" }
    };

    private Dictionary<string, string> _drawScenario = new()
    {
        { "A", "X" },
        { "B", "Y" },
        { "C", "Z" }
    };
    
    private Dictionary<string, string> _loseScenario = new()
    {
        { "A", "Z" },
        { "B", "X" },
        { "C", "Y" }
    };
    
    private Dictionary<string, int> _pointPerMove = new()
    {
        { "X", 1 },
        { "Y", 2 },
        { "Z", 3 }
    };

    public void GetAnswer()
    {
        Console.WriteLine("*** Part 1 ***");
        var totalScore = 0;
        foreach (var line in File.ReadLines("day2/data.txt"))
        {
            var data = line.Split(" ");
            var oponent = data.First();
            var you = data.Last();
            totalScore += (int)_pointPerMove[you];
            
            if (_drawScenario[oponent] == you) //draw
            {
                totalScore += 3;
            }
            else if (_winScenario[oponent] == you) // win
            {
                totalScore += 6;
            }
        }
        Console.WriteLine($"Part 1: {totalScore}");
        
        Console.WriteLine("\n*** Part 1 ***");
        
        var totalScore2 = 0;
        foreach (var line in File.ReadLines("day2/data.txt"))
        {
            var data = line.Split(" ");
            var oponent = data.First();
            var strategy = data.Last();
            var you = string.Empty;
            
            if (strategy == "Y") //draw
            {
                you = _drawScenario[oponent];
                totalScore2 += 3;
            }
            else if (strategy == "Z") // win
            {
                you = _winScenario[oponent];
                totalScore2 += 6;
            }
            else // lose
            {
                you = _loseScenario[oponent];
            }
            totalScore2 += (int)_pointPerMove[you];
        }
        Console.WriteLine($"Part 2: {totalScore2}");
    }
}