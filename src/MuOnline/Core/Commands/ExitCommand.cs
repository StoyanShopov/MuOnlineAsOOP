namespace MuOnline.Core.Commands
{
    using System;
    using System.Threading;
    using MuOnline.Core.Commands.Contracts;

    class ExitCommand : ICommand
    {
        public string Execute(string[] inputArgs)
        {
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Exit after {i}s");   
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.WriteLine("BOOM");

            Environment.Exit(0);
            return null;
        }
    }
}
