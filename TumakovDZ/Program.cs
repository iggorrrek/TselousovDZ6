using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovDZ
{
    public enum TypeSchet
    {
        tekushiy,
        sberegatelnuy
    }
    public class BankSchet
    {
        private int IDSchet ;
        private decimal BalanceSchet;
        private TypeSchet typeSchet ;
        public BankSchet(int iDSchet, decimal balanceSchet, TypeSchet typeSchet)
        {
            IDSchet = iDSchet;
            BalanceSchet = balanceSchet;
            this.typeSchet = typeSchet;
        }
        public int GetIDSchet()
        { return IDSchet; }
        public decimal GetBalanceSchet()
        { return BalanceSchet; }
        public decimal SetBalanceSchet(decimal newBalanceSchet) => BalanceSchet = newBalanceSchet;
        public TypeSchet GetTypeSchet()
        { return typeSchet; }
        public void PrintBankSchet()
        {
            Console.WriteLine($"Номер счета: {IDSchet}");
            Console.WriteLine($"Баланс: {BalanceSchet}");
            Console.WriteLine($"Тип счета: {typeSchet}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        static void Task1()
        {
            Console.WriteLine("N1\n");

            BankSchet bankSchet = new BankSchet(1234, 2000000, TypeSchet.tekushiy);
            Console.WriteLine("VVedite schet  i  td");
            decimal num;
            bool a = decimal.TryParse(Console.ReadLine(), out num); 
            bankSchet.SetBalanceSchet(num);
            bankSchet.PrintBankSchet();
            Console.ReadKey();
        }

        static void CHtenie()
        {

        }
        static void Vuvod()
        {
           // Console.WriteLine($"Ваш номер счета:{BankSchet.bankSchet.IDSchet}");
        }
    }
}
