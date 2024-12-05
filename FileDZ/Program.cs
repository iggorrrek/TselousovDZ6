using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание номер один\n");

            //первая виза
            VisaRus visa = new VisaRus();
            visa.UpdateVisaDetails(DateTime.Now, 6);
            visa.ActivateVisa();
            visa.SetSposob(Sposob.Для_работы);
            Console.WriteLine(visa.GetDetailedInfo());

            //вторая виза
            VisaUSA visa2 = new VisaUSA();
            visa2.UpdateVisaDetails(DateTime.Now, 5);
            visa2.DeactivateVisa();
            visa2.SetSposob(Sposob.Для_длительного_проживания);
            Console.WriteLine(visa2.GetDetailedInfo());

            //третья виза
            VisaFin visa3 = new VisaFin();
            visa3.UpdateVisaDetails(DateTime.Now, 5340);
            visa3.ActivateVisa();
            visa3.SetSposob(Sposob.Как_турист);
            Console.WriteLine(visa3.GetDetailedInfo());

            //четвертая виза (другой конструктор)
            VisaFin visa4 = new VisaFin(4322, true, DateTime.Now, Sposob.Для_работы);
            Console.WriteLine(visa4.GetDetailedInfo());


            Console.ReadKey();
        }
    }
}
