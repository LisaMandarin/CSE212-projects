using System;
using System.Text.Json;

public class Program
{
    static void Main(string[] args)
    {   
        var letters = new [] {'A', 'A', 'B', 'G', 'C', 'G', 'G', 'D', 'B'};
        var summaryTable = new Dictionary<char, int>();

        foreach (var letter in letters)
        {
            if (!summaryTable.ContainsKey(letter))
            {
                summaryTable[letter] = 1;
            }
            else
            {
                summaryTable[letter] += 1;
            }
        }

        Console.WriteLine(string.Join(", ", summaryTable));
    }
}