using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace BatchToBashConsole.Model
{
    class SSH
    {
        private string user;
        private string pass;
        private int port;
        private string host;
        private SshClient ssh;


        public SSH(string host, string user, string pass, int port = 22)
        {
            this.host = host;
            this.port = port;
            this.user = user;
            this.pass = pass;
            this.ssh = new SshClient(host, port, user, pass);
        }
        public void sendCommand(string command)
        {
            var cmd = this.ssh.RunCommand(command).Execute(command);
        }
        public string Command(string command)
        {
            return this.ssh.RunCommand(command).Execute(command);
        }
        public void Connect()
        {
            this.ssh.Connect();
        }
        public void Disconnect()
        {
            this.ssh.Disconnect();
        }

    }
}
