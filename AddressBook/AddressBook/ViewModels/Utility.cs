using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook.ViewModels
{
    public class Utility
    {
        public static bool CheckMobilePhone(string phone)
        {
            if (phone.Length != 11 ||
                !Regex.IsMatch(phone,
                @"13[0-9]\d{8}|15[0-9]\d{8}|18[0-9]\d{8}")){
                return false;
            }
            return true;
        }

        public static bool CheckEmail(string email)
        {
            if (!Regex.IsMatch(email, @"\w+([.-+]\w+)*@\w+([-.]\w+)*\.\w+[-.]\w+)*"))
            {
                return false;
            }
            return true;
        }

        public static bool CheckQQ(string qq)
        {
            if (!Regex.IsMatch(qq, @"^[1-9]*[1-9][0-9]*$"))
            {
                return false;
            }
            return true;
        }

        public static bool CheckPhone(string phone)
        {
            if (!Regex.IsMatch(phone, @"^(0[0-9]{2,3}\-)?([2-9][0-9]{6,7})+(\-[0-9]{1,4})?$"))
            {
                return false;
            }
            return true;
        }
    }
}
