using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

using System.Threading;

namespace ActivateWindows
{
    class Program
    {
        public static string textLogo =
            @"" + Environment.NewLine +
            @"$$$$$$$\            $$\                     $$\            " + Environment.NewLine +
            @"$$  __$$\           \__|                    \__|           " + Environment.NewLine +
            @"$$ |  $$ | $$$$$$\  $$\  $$$$$$\   $$$$$$\  $$\ $$$$$$$\   " + Environment.NewLine +
            @"$$ |  $$ |$$  __$$\ $$ |$$  __$$\ $$  __$$\ $$ |$$  __$$\  " + Environment.NewLine +
            @"$$ |  $$ |$$ |  \__|$$ |$$ /  $$ |$$ /  $$ |$$ |$$ |  $$ | " + Environment.NewLine +
            @"$$ |  $$ |$$ |      $$ |$$ |  $$ |$$ |  $$ |$$ |$$ |  $$ | " + Environment.NewLine +
            @"$$$$$$$  |$$ |      $$ |$$$$$$$  |$$$$$$$  |$$ |$$ |  $$ | " + Environment.NewLine +
            @"                        $$ |      $$ |                     " + Environment.NewLine +
            @"                        $$ |      $$ |                     " + Environment.NewLine +
            @"                        \__|      \__|                     " + Environment.NewLine;


        static void Main(string[] args)
        {
            Console.Title = "Drippin ";


            Console.Clear();
            Console.WriteLine(textLogo);

            Console.WriteLine("  ┌─────────────────────────────────────────┐");
            Console.WriteLine("  │ [1] Activate Windows                    │");
            Console.WriteLine("  │ [2] Exit                                │");
            Console.WriteLine("  │ [3] Credits                             │");
            Console.WriteLine("  └─────────────────────────────────────────┘");

            Console.WriteLine("  ┌─────────────────────────────────────────┐");
            Console.WriteLine("  │Discord: Drippin#0001                    │");
            Console.WriteLine("  └─────────────────────────────────────────┘");

            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine("slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX");
                process.StandardInput.WriteLine("slmgr /skms kms8.msguides.com");
                process.StandardInput.WriteLine("slmgr /ato");
                process.Close();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ended");

            }
            if (input == "2")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                Thread.Sleep(1);
            }
            if (input == "3")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine("start https://github.com/Detroitt");
                process.Close();
            }
        }
    }
}
