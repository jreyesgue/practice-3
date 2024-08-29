namespace Practice3.Utils
{
    public static class ConsoleReader
    {
        public static int GetOption()
        {
            Console.Write("\nSelect an option: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        public static string GetStringParam(string message)
        {
            Console.Write(message);

            return Console.ReadLine() ?? string.Empty;
        }
    }
}
