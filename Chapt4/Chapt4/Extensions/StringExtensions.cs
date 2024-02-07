


namespace Chapt4.Extensions
{
    // extension methods can only be defined in static classes
    public static class StringExtensions
    {
        public static int CountLines(this string input) => input.Split(Environment.NewLine).Length;
    }
}
