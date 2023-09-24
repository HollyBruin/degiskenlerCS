using System;
using System.Runtime.CompilerServices;
namespace variables
{
    class Program
    {
        public static void Main (string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;
            Console.WriteLine(deger + degisken + Degisken);

            byte b = 5;          //1 byte
            sbyte sb = 5;        //1 byte

            short s = 5;         //2 byte
            ushort us = 5;       //2 byte

            Int16 i16 = 2;       //2 byte
            int i = 2;           //4 byte
            Int32 i32 = 2;       //4 byte
            Int64 i64 = 2;       //8 byte
            uint ui = 5;         //4 byte

            long l = 4;          //8 byte
            ulong ul = 4;        //8 byte

            //reel sayılar
            float f = 5;         //4 byte
            double d = 5;        //8 byte
            decimal de = 5;      //16 byte

            char ch = '2';       //2 byte
            string str = "Eren"; //unlimited

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;


            //STRİNG İFADELER

            string str1 = string.Empty;
            str1 = "Eren";
            string ad = "Eren";
            string soyad = "ÖZEL";
            string tamisim = ad + " " +soyad;


            //INTEGER IFADELER

            int int1 = 5;
            int int2 = 2;
            int int3 = int1 * int2;


            //BOOLEAN IFADELER

            bool bool1 = 10<2; //false
            bool bool2 = 10>2; //true


            // DEGISKEN DONUSUMLERI

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);  //ÇIKTISI 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);      //ÇIKTISI 40


            int int22 = int20 + int.Parse(str20); //ÇIKTISI 40
            Console.WriteLine(int22);


            //DATETIME IFADELER

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour);






        }
    }

}