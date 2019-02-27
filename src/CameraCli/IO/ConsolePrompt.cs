using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.IO
{
    public class ConsolePrompt
    {
        private readonly IConsole _console;

        public ConsolePrompt(IConsole console)
        {
            _console = console;
        }

        public async Task<bool> GetYesNo(string prompt, bool defaultAnswer = false)
        {
            var answerHint = defaultAnswer ? "[Y/n]" : "[y/N]";
            do
            {
                await _console.Out.WriteAsync($"{prompt} {answerHint} ");

                // Write($"{prompt} {answerHint}", promptColor, promptBgColor);
                // Console.Write(' ');

                string response = await _console.In.ReadLineAsync();
                response = response?.ToLower()?.Trim();

                if (string.IsNullOrEmpty(response))
                {
                    return defaultAnswer;
                }

                if (response == "n" || response == "no")
                {
                    return false;
                }

                if (response == "y" || response == "yes")
                {
                    return true;
                }

                await _console.Out.WriteLineAsync($"Invalid response '{response}'. Please answer 'y' or 'n' or CTRL+C to exit.");
            } while (true);
        }
    }
}
