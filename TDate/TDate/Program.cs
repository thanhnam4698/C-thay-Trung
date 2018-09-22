using System;

namespace TDate
{
    class TDate
    {
        int ngay, thang, nam;
        public TDate()
        {
            ngay = 0;
            thang = 0;
            nam = 0;
        }
        public TDate(int a, int b, int c)
        {
            ngay = a;
            thang = b;
            nam = c;
        }
        public void input()
        {
            Console.Write("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine("Date: {0}/{1}/{2}", ngay, thang, nam);
        }
        public static bool operator >(TDate a, TDate b)
        {
            if (a.nam > b.nam) return true;
            else if (a.nam == b.nam && a.thang > b.thang) return true;
            else if (a.nam == b.nam && a.thang == b.thang && a.ngay > b.ngay) return true;
            else return false;
        }
        public static bool operator <(TDate a, TDate b)
        {
            if (a.nam < b.nam) return true;
            else if (a.nam == b.nam && a.thang < b.thang) return true;
            else if (a.nam == b.nam && a.thang == b.thang && a.ngay < b.ngay) return true;
            else return false;
        }
        public static bool operator ==(TDate a, TDate b)
        {
            if (a.nam == b.nam && a.thang == b.thang && a.ngay == b.ngay) return true;
            else return false;
        }
        public static bool operator !=(TDate a, TDate b)
        {
            if (a.nam == b.nam && a.thang == b.thang && a.ngay == b.ngay) return false;
            else return true;
        }
        public static int operator -(TDate a, TDate b)
        {

            int z = Math.Abs(a.nam - b.nam) * 365;

            return z;
        }
        public static TDate operator +(TDate a,int b)
        {
            TDate z;
            int dlm;
            if (a.nam % 4 == 0)
            {
                if (a.thang == 1 || a.thang == 3 || a.thang == 5 || a.thang == 7 || a.thang == 8 || a.thang == 10 || a.thang == 12)
                {
                    dlm = 31;
                }
                else if (a.thang == 4 || a.thang == 6 || a.thang == 9 || a.thang == 11)
                {
                    dlm = 30;
                }
                else dlm = 29;
            }
            else 
            {
                if (a.thang == 1 || a.thang == 3 || a.thang == 5 || a.thang == 7 || a.thang == 8 || a.thang == 10 || a.thang == 12)
                {
                    dlm = 31;
                }
                else if (a.thang == 4 || a.thang == 6 || a.thang == 9 || a.thang == 11)
                {
                    dlm = 30;
                }
                else dlm = 28;
            }
            if (a.ngay == dlm + 1)
            {
                a.ngay = 1;
                a.thang++;
                if (a.thang == 13)
                {
                    a.thang = 1;
                    a.nam++;
                }

            }
            else a.ngay++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
