using System;
using System.Globalization;

namespace StringManipulation
{
    class manipulation 
    {

        static String intToRoman(int num)
        {
            // storing roman values of digits from 0-9
            // when placed at different places
            String[] m = { "", "M", "MM", "MMM" };
            String[] c = { "",  "C",  "CC",  "CCC",  "CD",
                       "D", "DC", "DCC", "DCCC", "CM" };
            String[] x = { "",  "X",  "XX",  "XXX",  "XL",
                       "L", "LX", "LXX", "LXXX", "XC" };
            String[] i = { "",  "I",  "II",  "III",  "IV",
                       "V", "VI", "VII", "VIII", "IX" };

            // Converting to roman
            String thousands = m[num / 1000];
            String hundreds = c[(num % 1000) / 100];
            String tens = x[(num % 100) / 10];
            String ones = i[num % 10];

            String ans = thousands + hundreds + tens + ones;

            return ans;
        }


        static void Main(string[] args) 
        {
            const string inv = "INV";
            int nomorsurat;
            const int counter = 1;
            

            Console.WriteLine(" Masukan nomor surat ");
            nomorsurat = Convert.ToInt32(Console.ReadLine());
            int nomorsuratcounter = nomorsurat + counter;
            DateTime date = DateTime.Now;
            DateTime date3 = date.AddDays(3);
            string day2 = date3.ToString("dddd");
            string day3 = date3.ToString("dd");
            string bulan = date3.ToString("MM");
            string year = date3.ToString("yyyy");


            Console.WriteLine
                (inv + "/" + 
                year + bulan + "/" + 
                day2.ToUpper().Substring(0,2) + "/" +
                intToRoman(int.Parse(day3.Substring(0,2))) + "/" +
                intToRoman(int.Parse(year.Substring(0,2))) + intToRoman(int.Parse(year.Substring(1,2))) + "/" + 
                nomorsuratcounter);
            
            //Untuk mengambil 2 character pada hari gunakan identifier.substring(mulai.panjang huruf)


        }

    }

}