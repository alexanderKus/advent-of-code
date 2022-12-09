namespace aoc.day1;

public class DayOne
{
    public void GetAnswer()
    {
        List<int> all = new List<int>();
        var max = 0;
        var current = 0;
        foreach (var line in File.ReadLines("day1/data.txt"))
        {
            if (line == string.Empty)
            {
                all.Add(current);
                max = current > max ? current : max;
                current = 0;
            }
            else
            {
                current += int.Parse(line);
            }
        }
        all.Sort();
        all.Reverse();
        var top3 = all.Take(3).Sum();
        Console.WriteLine($"Part 1: {max}");
        Console.WriteLine($"Part 2: {top3}");
    }
}