﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace SulfurLauncher.Helpers
{
    public class StringsHelper
    {
        public static string ReplaceDisallowedChars(string OriginString)
        {
            string RetValue = OriginString;
            RetValue = RetValue.Replace(" ", "SPACE");
            RetValue = RetValue.Replace("-", "DASH");
            RetValue = RetValue.Replace("+", "PLUS");
            RetValue = RetValue.Replace(".", "DOT");
            RetValue = RetValue.Replace(",", "COMMA");

            return RetValue;
        }

        public static string ReturnDisallowedChars(string OriginString)
        {
            string RetValue = OriginString;
            RetValue = RetValue.Replace("SPACE", " ");
            RetValue = RetValue.Replace("DASH", "-");
            RetValue = RetValue.Replace("PLUS", "+");
            RetValue = RetValue.Replace("DOT", ".");
            RetValue = RetValue.Replace("COMMA", ",");

            return RetValue;
        }

        public static string GetLnkTarget(string lnkPath)
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(lnkPath);
            return shortcut.TargetPath;
        }
    }
}
