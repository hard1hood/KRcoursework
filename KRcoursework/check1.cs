﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KRcoursework
{
    class Check
    {
        int state=1;
        public bool CheckName(string str)
        {
            int i;
            if (str == "" || str.Length > 50)
                return false;
            for (i = 0; i < str.Length; i++)
            {
                if (!((str[i] > 64 && str[i] < 91) || (str[i] > 96 && str[i] < 123) || str[i] == 32))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return (strIn != "" && Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"));
        }
        public bool CheckPass(string str)
        {
            return (str.Length >= 4 && str.Length <= 15);
        }
        public bool PassConfirm(string pass1, string pass2)
        {
            return pass1 == pass2;
        }
        public bool checkLen(string str)
        {
            return (str != "" && str.Length < 50);
        }
       


    }
}
