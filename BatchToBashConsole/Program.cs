using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimS.Telnet;
using System.IO;

namespace BatchToBashConsole
{
    class Program
    {
        static string com = "ls";
        static void Main(string[] args)
        {
            var ssh = new Model.SSH("tulak.host", "tun", "Tunel");
            ssh.Connect();
            Console.WriteLine(ssh.Command("df -h"));
            Console.WriteLine(ssh.Command("ls -la"));
            ssh.Disconnect();


            Console.ReadLine();

        }
    }
}
