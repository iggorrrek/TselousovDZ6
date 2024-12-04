using System;


namespace TumakovDZ
{
    public class Zdanie
    {
        private static int lastnumZdan = 0;
        private int buildingId;
        private double height;
        private int etazi;
        private int kvart;
        private int podiezd;
        public Zdanie()
        {
            this.buildingId = GenerateId();
        }
        public static int GenerateId()
        {
            return ++lastnumZdan;
        }
        public void SetValues(double height, int floors, int apartments, int entrances)
        {
            this.height = height;
            this.etazi = floors;
            this.kvart = apartments;
            this.podiezd = entrances;
        }
        public int GetBuildingId()
        {
            return buildingId;
        }

        public double GetHeight()
        {
            return height;
        }

        public int GetEtazi()
        {
            return etazi;
        }

        public int GetKvart()
        {
            return kvart;
        }

        public int GetPodiezd()
        {
            return podiezd;
        }
        public double EtazVus => etazi > 0 ? height / etazi : 0;
        public int KvVPod => podiezd > 0 ? kvart / podiezd : 0;
        public int KvVEtaz => etazi > 0 ? kvart / etazi : 0;
        public void PrintInfo()
        {
            Console.WriteLine($"\nУникальный номер здания: {GetBuildingId()}");
            Console.WriteLine($"Высота здания: {GetHeight():F2} м");
            Console.WriteLine($"Этажность: {GetEtazi()} этажей");
            Console.WriteLine($"Общее количество квартир: {GetKvart()}");
            Console.WriteLine($"Количество подъездов: {GetPodiezd()}");
            Console.WriteLine($"Высота одного этажа: {EtazVus:F2} м");
            Console.WriteLine($"Квартир в одном подъезде: {KvVPod}");
            Console.WriteLine($"Квартир на одном этаже: {KvVEtaz}\n");
        }
    }
    
}
