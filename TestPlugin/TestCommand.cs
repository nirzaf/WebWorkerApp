using System;
using BasePlugin;

namespace TestPlugin
{
    public class TestCommand : ICommand
    {
        private static readonly InternalIdentifier SIdentifier;
        static TestCommand()
        {
            SIdentifier = new InternalIdentifier()
            {
                Created = DateTime.Now
            };
        }

        public string Name => "test";
        public string Description => "Dummy command for testing purpose.";
        public string Execute()
        {
            Console.WriteLine($"Hello from plugin {SIdentifier}!");
            return "Hello world!";
        }
    }

    internal class InternalIdentifier
    {
        public DateTime Created { get; set; }
        public override string ToString()
            => $"id_TestCommand_{Created:O}";
    }
}
