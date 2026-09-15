namespace Shared
{
    /// <summary>
    /// Reusable console input helper, shared by every logic exercise so
    /// each one does not repeat the same Console.Write + Console.ReadLine
    /// + int.Parse pattern.
    /// </summary>
    public static class ConsoleHelper
    {
        public static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine()!);
        }
    }
}
