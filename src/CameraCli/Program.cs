using System;
using CameraCli.Commands;
using CameraCli.Devices;
using CameraCli.IO;
using CameraCli.Utils;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace CameraCli
{
    [Command(Name = "camera", Description = "Dependency Injection sample project")]
    [Subcommand(typeof(SnapCommand))]
    [Subcommand(typeof(UsedByCommand))]
    [Subcommand(typeof(ListCommand))]
    [Subcommand(typeof(EnableCommand))]
    [Subcommand(typeof(DisableCommand))]
    [HelpOption]
    class Program
    {
        static int Main(string[] args)
        {
            var isElevated = Environment.GetEnvironmentVariable("__CAMERA_CLI_IS_ELEVATED");

            Console.WriteLine(isElevated);
            var services = new ServiceCollection()
                .AddSingleton<IConsole, DefaultConsole>()
                .AddCameraManager()
                .BuildServiceProvider();

            var app = new CommandLineApplication<Program>();
            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(services);

            return app.Execute(args);
        }

        public void OnExecute(CommandLineApplication app) => app.ShowHelp();
    }
}
