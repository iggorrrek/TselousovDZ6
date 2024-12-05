using System;

namespace FileDZ
{
    enum Sposob 
    {
        Как_турист,
        Для_работы,
        Для_длительного_проживания
    }

    internal abstract class Visa
    {
        public int Dlitelnost { get; set; }
        public bool Dejstvitelnost { get; set; }
        public DateTime DataVudachi { get; set; }
        public Sposob Sposob { get; set; }
        public abstract double CalculateCost();
        public abstract string Requirements();

        public virtual string GetVisaInfo()
        {
            return $"Длительность: {Dlitelnost} месяцев, Действительна: {Dejstvitelnost}, Дата выдачи: {DataVudachi.ToShortDateString()}";
        }
    }

    internal class VisaRus : Visa
    {
        public VisaRus()
        {
           
        }

        public VisaRus(int dlitelnost, bool dejstvitelnost, DateTime dataVudachi, Sposob sposob)
        {
            Dlitelnost = dlitelnost;
            Dejstvitelnost = dejstvitelnost;
            DataVudachi = dataVudachi;
            Sposob = sposob;
        }

        public override double CalculateCost() { return 50.0; }
        public override string Requirements() { return "Необходимые документы для визы в Россию: пачпорт"; }

        public string Country => "Россия";

        public Sposob GetSposob()
        {
            return Sposob;
        }

        public override string GetVisaInfo()
        {
            return base.GetVisaInfo() + $", Страна: {Country}";
        }
        public DateTime GetEndDate()
        {
            return DataVudachi.AddMonths(Dlitelnost); 
        }
        public string GetDetailedInfo()
        {
            return $"\nВиза в {Country}, Длительность: {Dlitelnost} месяцев, \n" +
                   $"Действительна: {(Dejstvitelnost ? "да" : "нет")}, \n" +
                   $"Дата выдачи: {DataVudachi.ToShortDateString()}, \n" +
                   $"Дата окончания: {GetEndDate().ToShortDateString()}\n" +
                   $"Цена получения визы: {CalculateCost()}\n" +
            Requirements()+ $"\nЦель получения визы: {GetSposob()}";
        }
        public void SetSposob(Sposob sposob)
        {
            Sposob = sposob;
        }
        public void UpdateVisaDetails(DateTime newIssueDate, int newDuration)
        {
            DataVudachi = newIssueDate;
            Dlitelnost = newDuration;
        }

        public void ActivateVisa()
        {
            Dejstvitelnost = true;
        }

        public void DeactivateVisa()
        {
            Dejstvitelnost = false;
        }
    }

    internal class VisaUSA : Visa
    {
        public VisaUSA() { }

        public VisaUSA(int dlitelnost, bool dejstvitelnost, DateTime dataVudachi, Sposob sposob)
        {
            Dlitelnost = dlitelnost;
            Dejstvitelnost = dejstvitelnost;
            DataVudachi = dataVudachi;
            Sposob = sposob;
        }

        public override double CalculateCost() { return 160.0; }
        public override string Requirements() { return "Необходимые документы для визы в США: загранпаспорт с не истекшим сроком действия\nанкета, заполненная на сайте Департамента Иммиграции США, и распечатанное подтверждение о ее заполнении\nквитанция об оплате визового сбора\nфотографии, сделанные в соответствии с требованиями посольства"; }

        public string Country => "США";

        public override string GetVisaInfo()
        {
            return base.GetVisaInfo() + $", Страна: {Country}";
        }
        public DateTime GetEndDate()
        {
            return DataVudachi.AddMonths(Dlitelnost); 
        }
        public Sposob GetSposob()
        {
            return Sposob;
        }
        public string GetDetailedInfo()
        {
            return $"\nВиза в {Country}, Длительность: {Dlitelnost} месяцев, \n" +
                   $"Действительна: {(Dejstvitelnost ? "да" : "нет")}, \n" +
                   $"Дата выдачи: {DataVudachi.ToShortDateString()}, \n" +
                   $"Дата окончания: {GetEndDate().ToShortDateString()}\n" +
                   $"Цена получения визы: {CalculateCost()}\n" +
            Requirements() + $"\nЦель получения визы: {GetSposob()}";
        }
        public void SetSposob(Sposob sposob)
        {
            Sposob = sposob;
        }
        public void UpdateVisaDetails(DateTime newIssueDate, int newDuration)
        {
            DataVudachi = newIssueDate;
            Dlitelnost = newDuration;
        }

        public void ActivateVisa()
        {
            Dejstvitelnost = true;
        }

        public void DeactivateVisa()
        {
            Dejstvitelnost = false;
        }
    }

    internal class VisaFin : Visa
    {
        public VisaFin() { }

        public VisaFin(int dlitelnost, bool dejstvitelnost, DateTime dataVudachi, Sposob sposob)
        {
            Dlitelnost = dlitelnost;
            Dejstvitelnost = dejstvitelnost;
            DataVudachi = dataVudachi;
            Sposob = sposob;
        }

        public override double CalculateCost() { return 70.0; }
        public override string Requirements() { return "Необходимые документы для визы в Финляндию: справка о том что ты хороший мальчик (или девочка)"; }

        public string Country => "Финляндия";

        public override string GetVisaInfo()
        {
            return base.GetVisaInfo() + $", Страна: {Country}";
        }
        public DateTime GetEndDate()
        {
            return DataVudachi.AddMonths(Dlitelnost); 
        }
        public Sposob GetSposob()
        {
            return Sposob;
        }
        public string GetDetailedInfo()
        {
            return $"\nВиза в {Country}, Длительность: {Dlitelnost} месяцев, \n" +
                   $"Действительна: {(Dejstvitelnost ? "да" : "нет")}, \n" +
                   $"Дата выдачи: {DataVudachi.ToShortDateString()}, \n" +
                   $"Дата окончания: {GetEndDate().ToShortDateString()}\n" +
                   $"Цена получения визы: {CalculateCost()}\n" +
            Requirements() + $"\nЦель получения визы: {GetSposob()}";
        }
        public void SetSposob(Sposob sposob)
        {
            Sposob = sposob;
        }
        public void UpdateVisaDetails(DateTime newIssueDate, int newDuration)
        {
            DataVudachi = newIssueDate;
            Dlitelnost = newDuration;
        }

        public void ActivateVisa()
        {
            Dejstvitelnost = true;
        }

        public void DeactivateVisa()
        {
            Dejstvitelnost = false;
        }
    }
}