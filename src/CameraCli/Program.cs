using CameraCli.Commands;
using CameraCli.IO;
using CameraCli.Utils;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace CameraCli
{
    [Command(Name = "camera", Description = "Dependency Injection sample project")]
    [Subcommand(typeof(SnapCommand))]
    [Subcommand(typeof(ListCommand))]
    [Subcommand(typeof(EnableCommand))]
    [Subcommand(typeof(DisableCommand))]
    [HelpOption]
    class Program
    {
        static int Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddSingleton<IConsole>(provider =>
                {
                    if (CurrentUser.IsAdmin())
                    {
                        return new PipedConsole("cameraclipipe");
                    }
                    return new DefaultConsole();
                })
                .AddSingleton<ConsolePrompt>()
                .BuildServiceProvider();

            var app = new CommandLineApplication<Program>();
            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(services);

            return app.Execute(args);
        }

        public void OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
        }
    }
}
