using System.Diagnostics;

namespace CameraCli.Utils
{
    public static class CurrentProcess
    {
        public static string FileName => System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

        public static Process RunAsAdmin()
        {
            var startInfo = new ProcessStartInfo(FileName)
            {
                Verb = "runas",
                UseShellExecute = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
            };

            foreach (var arg in System.Environment.GetCommandLineArgs())
            {
                startInfo.ArgumentList.Add(arg);
            }

            var process = new Process();
            process.StartInfo = startInfo;

            return process;
        }
    }
}
