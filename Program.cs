using System;
using System.IO;
using System.Diagnostics;

namespace ComputerInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Inventário de Hardware");
            Console.WriteLine("2 - Inventário de Software");
            Console.WriteLine("3 - Inventário de Hardware e Software");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GenerateHardwareInventory();
                    break;
                case "2":
                    GenerateSoftwareInventory();
                    break;
                case "3":
                    GenerateHardwareInventory();
                    GenerateSoftwareInventory();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        static void GenerateHardwareInventory()
        {
            string hardwareInfo = GetHardwareInfo();
            File.WriteAllText("hardware_inventory.dat", hardwareInfo);
            Console.WriteLine("Inventário de hardware salvo em hardware_inventory.dat");
        }

        static void GenerateSoftwareInventory()
        {
            string softwareInfo = GetSoftwareInfo();
            File.WriteAllText("software_inventory.dat", softwareInfo);
            Console.WriteLine("Inventário de software salvo em software_inventory.dat");
        }

        static string GetHardwareInfo()
        {
            // Aqui você pode adicionar comandos específicos para coletar informações de hardware, como o comando systeminfo
            return ExecuteCommand("systeminfo");
        }

        static string GetSoftwareInfo()
        {
            // Aqui você pode adicionar comandos específicos para coletar informações de software, como o comando Get-InstalledSoftware no PowerShell
            return ExecuteCommand("powershell.exe Get-InstalledSoftware");
        }

        static string ExecuteCommand(string command)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.Start();

            string result = proc.StandardOutput.ReadToEnd();
            return result;
        }
    }
}
