using System;
using IBANLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = Util.GetBankByIBAN("SA3545000000043794452001");
            Console.WriteLine("Hello World!");
        }
    }
}
