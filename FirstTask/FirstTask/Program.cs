using System;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keyPress = new TestClass();
            keyPress.OnKeyPressed += (Sender, ButtonKey) => Console.WriteLine($"\nYou pressed '{ButtonKey}' button!");
            keyPress.Run();
        }
    }
}
