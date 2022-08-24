using System;
using System.Linq;

namespace IBANLib
{
    public class Util
    {
        public static bool ValidateIBAN(string iban)
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

        public static Bank GetBankByIBAN(string iban)
        {
            if(ValidateIBAN(iban))
            {
                string bankCode = iban.Substring(4, 2);
                return BankList.BANKS.FirstOrDefault(b => b.SamaCode == bankCode);
            } else
            {
                return null;
            }
        }
    }
}
