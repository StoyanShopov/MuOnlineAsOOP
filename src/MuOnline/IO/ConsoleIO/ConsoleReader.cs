namespace MuOnline.IO.ConsoleIO
{
    using System;
    using MuOnline.IO.Contracts;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
            => Console.ReadLine();
    }
}
