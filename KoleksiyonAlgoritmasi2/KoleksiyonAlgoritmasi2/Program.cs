using System;

namespace KoleksiyonAlgoritma1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int[] inputArray = new int[20];
            Console.WriteLine("20 adet sayı giriniz...");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + ". sayıyı giriniz...");
                input = Convert.ToInt32(Console.ReadLine());
                inputArray[i] = input;
            }

            
            Array.Sort(inputArray);
            int smallArithmetic = (inputArray[0] + inputArray[1] + inputArray[2])/3;
            int bigArithmetic = (inputArray[inputArray.Length - 1] + inputArray[inputArray.Length - 2] + inputArray[inputArray.Length - 3]) / 3;

            Console.WriteLine("En küçük 3 sayı: "+inputArray[0] +" "+ inputArray[1] +" "+ inputArray[2]);
            Console.WriteLine("En küçük 3 sayının aritmetik ortalaması: " + smallArithmetic);
            Console.WriteLine("En büyük 3 sayı: "+inputArray[inputArray.Length-1] + " " + inputArray[inputArray.Length-2] + " " + inputArray[inputArray.Length-3]);
            Console.WriteLine("En büyük 3 sayının aritmetik ortalaması: " + bigArithmetic);



        }
    }
}
