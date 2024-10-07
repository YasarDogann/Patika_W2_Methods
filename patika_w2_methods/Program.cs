using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace patika_w2_methods
{
    internal class Program
    {

        //1.Geriye Değer Döndürmeyen Bir void metot.
        public static void Song()
        {
            Console.WriteLine("Mutlu Son Olmasın Mutlu Sonsuz Olsun");
        }


        //2.Geriye Tamsayı Döndüren Bir metot
        public static int Number()
        {
            Random rand = new Random();
            int num = rand.Next(1,100);
            Console.WriteLine("Üretilen sayı: "+num);

            return num % 2;
        }


        //3.Parametre Alan ve Geriye Değer Döndüren Bir Metot
        public static int Carp(int num1, int num2)
        {
            return num1*num2;
        }


        //4.Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
        public static void Message(string name, string surname)
        {
            Console.WriteLine("Hoşgeldiniz {0} {1}", name, surname);
        }



        static void Main(string[] args)
        {
            //1.SORU
            Song();

            //2. SORU
            int result = Number();
            Console.WriteLine(result);


            //3.SORU
            int result_carp = Carp(5, 2);
            Console.WriteLine("iki sayının çarpımı: "+result_carp);


            //4.SORU
            Message("Mauro","Icardi");




            Console.Read();
            
        }
    }
}
