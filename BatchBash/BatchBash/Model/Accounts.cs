using System;
using System.Collections.Generic;
using System.Text;

namespace BatchBash.Model
{
    class Accounts
    {
        public static string adduser(string name, bool sudo)
        {
            string outp = "adduser ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string deluser(string name, bool sudo)
        {
            string outp = "deluser ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string su(string name, bool sudo)
        {
            string outp = "su ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string passwd(string name, bool sudo)
        {
            string outp = "passwd ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string exit(string returnCode = "")
        {
            string outp = "exit ";
            if (returnCode != "") { outp += returnCode; }
            return outp;
        }
    }
}
