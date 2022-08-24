using System;
using System.Collections.Generic;
using System.Text;

namespace IBANLib
{
    public class BankList
    {
        public static Bank[] BANKS = new Bank[] {
            new Bank(){SamaCode="55", ArabicName="البنك السعودي الفرنسي", EnglishName="Banque Saudi Fransi", Code="3"},
            new Bank(){SamaCode="80", ArabicName="بنك الراجحي", EnglishName="Alrajhi Bank", Code="11"},
            new Bank(){SamaCode="10", ArabicName="البنك الأهلي التجاري", EnglishName="National Commercial Bank", Code="1"},
            new Bank(){SamaCode="45", ArabicName="البنك السعودي البريطاني", EnglishName="Saudi British Bank", Code="2"},
            new Bank(){SamaCode="20", ArabicName="بنك الرياض", EnglishName="Riyadh Bank", Code="9"},
            new Bank(){SamaCode="40", ArabicName="سامبا", EnglishName="Saudi American Bank", Code="4"},
            new Bank(){SamaCode="05", ArabicName="بنك الانماء", EnglishName="Alinma Bank", Code="12"},
            new Bank(){SamaCode="50", ArabicName="البنك الأول", EnglishName="Alawwal bank", Code="10"},
            new Bank(){SamaCode="60", ArabicName="بنك الجزيرة", EnglishName="Bank AlJazira", Code="8"},
            new Bank(){SamaCode="65", ArabicName="البنك السعودي للأستثمار", EnglishName="Saudi Investment Bank", Code="5"},
            new Bank(){SamaCode="15", ArabicName="بنك البلاد", EnglishName="Bank AlBilad", Code="7"},
            new Bank(){SamaCode="30", ArabicName="البنك العربي الوطني", EnglishName="Arab National Bank", Code="6"},
            new Bank(){SamaCode="90", ArabicName="بنك الخليج", EnglishName="Gulf International Bank", Code="13"},
            new Bank(){SamaCode="95", ArabicName="بنك الامارات", EnglishName="Emirates Bank", Code="14"},
            new Bank(){SamaCode="76", ArabicName="بنك مسقط", EnglishName="Bank Muscat", Code="17"},
            new Bank(){SamaCode="71", ArabicName="بنك البحرين الوطني", EnglishName="National Bank of Bahrain", Code="15"},
            new Bank(){SamaCode="75", ArabicName="بنك الكويت الوطني", EnglishName="National Bank of Kuwait", Code="16"},
            new Bank(){SamaCode="85", ArabicName="بي ان بي باريبوس", EnglishName="BNP PARIBAS SAUDI ARABIA", Code="19"}
        };
    }
}
