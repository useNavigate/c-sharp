using Spectre.Console;

class Program
{
    static void Main(string[] args)
    {
        int[] rolls = { 2, 3, 9, 15, 11, 17, 22, 8, 6, 5, 2 };
        PrintStatistics(rolls);
        Console.ReadKey();
    }

    static void PrintStatistics(int[] rolls)
    {
        // Create a new BarChart
        var chart = new BarChart()
            .Width(60)
            .Label("[green bold underline]Roll Statistics[/]")
            .CenterLabel();

        // Add data points for each roll
        for (int i = 2; i <= 12; i++)
        {
            chart.AddItem(i.ToString(), rolls[i - 2], Color.Yellow);
        }

        // Write the chart to the console
        AnsiConsole.Render(chart);
    }
}
