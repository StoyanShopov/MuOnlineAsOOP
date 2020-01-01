namespace MuOnline.IO.ConsoleIO
{
    using System;
    using MuOnline.IO.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }

        public void Write(string content)
        {
            Console.Write(content);
        }
    }
}
