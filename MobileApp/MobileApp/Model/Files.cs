using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Model
{
    class Files
    {
        public static string ls(bool longFormat, bool hidden, bool recursive, bool humanReadable)
        {
            string outp = "ls ";
            if (longFormat) { outp += "-l "; }
            if (hidden) { outp += "-a "; }
            if (recursive) { outp += "-R "; }
            if (humanReadable) { outp += "-h "; }
            return outp;
        }
        public static string mkdir(string name)
        {
            string outp = "mkdir ";
            outp += name; 
            return outp;
        }
        public static string nano(string name, bool sudo)
        {
            string outp = "nano ";
            outp += name;
            if (sudo) { outp = "sudo " + outp; }
            return outp;
        }
        public static string touch(string name, bool sudo)
        {
            string outp = "ls ";
            if (sudo) { outp =  "sudo " + outp; }
            outp += name;
            return outp;
        }
    }
}
