using System;

namespace BARSGroupHW1
{
    class Program
    {

        class Task
        {
            public event EventHandler <char>  OnKeyPressed;
            public void Run()
            {
                var symbol = Console.ReadKey();
                while (true)
                {
                    if (symbol.Key == ConsoleKey.C)
                    {
                        break;
                    }
                    else
                    {
                        OnKeyPressed?.Invoke(this, symbol.KeyChar);
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Task Subscriber = new Task();
            EventHandler<char> OnKeyPressed = (sender, symbol) => Console.WriteLine($"веденный символ:", symbol);
            Subscriber.Run();

        }
    }
}
