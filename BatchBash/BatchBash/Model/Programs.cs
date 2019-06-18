using System;
using System.Collections.Generic;
using System.Text;

namespace BatchBash.Model
{
    class Programs
    {
        public static string install(string name, bool sudo)
        {
            string outp = "apt-get install ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string remove(string name, bool sudo)
        {
            string outp = "apt-get remove ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string purge(string name, bool sudo)
        {
            string outp = "apt-get purge ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string autoremove(bool sudo)
        {
            string outp = "apt-get auto-remove ";
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
    }
}
