﻿using System;
using System.Linq;

namespace IBANLib
{
    public class Util
    {
        public static bool validateIBAN(string iban)
        {
            if (string.IsNullOrEmpty(iban))
            {
                return false;
            }
            iban = iban.Trim();
            if (iban.Length != 24)
            {
                return false;
            }

            return true;
        }

        public static Bank getBankByIBAN(string iban)
        {
            if(validateIBAN(iban))
            {
                string bankCode = iban.Substring(4, 6);
                return BankList.BANKS.FirstOrDefault(b => b.SamaCode == bankCode);
            } else
            {
                return null;
            }
        }
    }
}
