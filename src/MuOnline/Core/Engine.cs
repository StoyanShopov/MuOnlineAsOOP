namespace MuOnline.Core
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using MuOnline.Core.Contracts;
    using MuOnline.IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IServiceProvider serviceProvider, IReader reader, IWriter writer)
        {
            this.serviceProvider = serviceProvider;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    var inputArgs = this.reader
                        .ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    var commandInterpreter = this.serviceProvider.GetService<ICommandInterpreter>();
                    var result = commandInterpreter.Read(inputArgs);

                    this.writer.Write(result);
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
                catch (ArgumentException ax)
                {
                    Console.WriteLine(ax.Message);
                }
                catch (InvalidOperationException iox)
                {
                    Console.WriteLine(iox.Message);
                }
            }
        }
    }
}
