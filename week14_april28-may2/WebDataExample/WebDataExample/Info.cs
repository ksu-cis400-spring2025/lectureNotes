namespace WebDataExample
{
    public static class Info
    {
        public static List<string> Words { get; } = new();

        public static void AddWord(string s)
        {
            Words.Add(s);
        }
    }
}
