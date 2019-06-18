using System;
using System.Collections.Generic;
using System.Text;

namespace BatchBash.Model
{
    class Networking
    {
        public static string ifconfig(bool all, bool sudo)
        {
            string outp = "ifconfig";
            if (sudo) { outp = "sudo " + outp; }
            if (all) { outp += " -a"; }
            return outp;
        }

        public static string iwconfig(bool all, bool sudo)
        {
            string outp = "iwconfig";
            if (sudo) { outp = "sudo " + outp; }
            if (all) { outp += " -a"; }
            return outp;
        }
        public static string dhclient(bool release, bool sudo, string iface)
        {
            string outp = "dhclient ";
            if (sudo) { outp = "sudo " + outp; }
            if (release) { outp += "-R "; }
            outp += iface;
            return outp;
        }
        public static string rfkill(bool state, bool sudo, string iface)
        {
            string outp = "rfkill ";
            if (sudo) { outp = "sudo " + outp; }
            outp += state ? "block " : "unblock ";
            outp += iface;
            return outp;
        }
        public static string ping(string host)
        {
            string outp = "ping ";
            outp += host;
            return outp;
        }

    }
}
