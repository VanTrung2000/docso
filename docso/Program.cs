using System;

namespace docso
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Nhap so: ");
            int number = int.Parse(Console.ReadLine());
            docso(number);
            Console.ReadLine();
        }

        private static void docso(int number)
        {
            string[] donvi = { "Mot", "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam", "Chin", "Muoi", "Muoi mot", "Muoi hai", "Muoi ba", "Muoi bon", "Muoi lam", "Muoi sau", "Muoi bay", "Muoi tam", "Muoi chin" };
            string[] chuc = { "Muoi", "Hai muoi", "Ba muoi", "Bon muoi", "Nam muoi", "Sau muoi", "Bay muoi", "Tam muoi", "Chin muoi" };


            string so = "";


            if (number > 99 && number < 1000)
            {
                int i = number / 100;
                so = so + donvi[i - 1] + " Tram ";
                number = number % 100;
            }

            if (number > 19 && number < 100)
            {
                int i = number / 10;
                so = so + chuc[i - 1] + " ";
                number = number % 10;
            }

            if (number > 0 && number < 20)
            {
                so = so + donvi[number - 1];
            }

            Console.WriteLine("So cua ban là : {0}", so);
        }
    }
}
