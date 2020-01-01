namespace MuOnline.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Core.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string Suffix = "command";
        private const string InvalidCommandMessage = "Invalid Command!";

        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] args)
        {
            var commandName = args[0].ToLower() + Suffix;

            var inputArgs = args
                .Skip(1)
                .ToArray();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName);

            if (type == null)
            {
                throw new ArgumentNullException(InvalidCommandMessage);
            }

            var constructor = type
                .GetConstructors()
                .FirstOrDefault();

            var constructorParams = constructor
                ?.GetParameters()
                .Select(x => x.ParameterType)
                .ToArray();

            var services = constructorParams
                ?.Select(this.serviceProvider.GetService)
                .ToArray();

            var typeInstance = Activator.CreateInstance(type, services) as ICommand;

            string result = typeInstance?.Execute(inputArgs);

            return result;
        }
    }
}
