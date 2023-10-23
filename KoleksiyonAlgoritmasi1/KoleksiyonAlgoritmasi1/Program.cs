using System.Collections;

namespace KoleksiyonAlgoritma1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFounder();

            static void PrimeFounder()
            {
                ArrayList primeNumbers = new ArrayList();
                ArrayList nonprimeNumbers = new ArrayList();
                int count = 0;

                while (count < 20)
                {
                    Console.Write("Lütfen bir sayı girin: ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        if (number < 0)
                        {
                            Console.WriteLine("Sayı 0'dan küçük olamaz. Lütfen tekrar girin.");
                        }
                        else
                        {
                            if (IsPrime(number))
                            {
                                primeNumbers.Add(number);
                            }
                            else
                            {
                                nonprimeNumbers.Add(number);
                            }
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sadece pozitif sayı girişi yapılabilir. Lütfen tekrar deneyin.");
                    }
                }


                primeNumbers.Sort();
                nonprimeNumbers.Sort();

                Console.WriteLine("Asal Sayılar:");
                foreach (var prime in primeNumbers)
                {
                    Console.Write(prime + " ");
                }

                Console.WriteLine("\nAsal Olmayan Sayılar:");
                foreach (var nonprime in nonprimeNumbers)
                {
                    Console.Write(nonprime + " ");
                }

                double averagePrime = primeNumbers.Cast<int>().Average();
                double averageNonprime = nonprimeNumbers.Cast<int>().Average();

                Console.WriteLine($"\nAsal Sayılar Ortalama: {Convert.ToInt32(averagePrime)}");
                Console.WriteLine($"Asal Olmayan Sayılar Ortalama: {Convert.ToInt32(averageNonprime)}");
            }

            static bool IsPrime(int num)
            {

                if (num <= 1)
                    return false;
                if (num == 2)
                    return true;
                if (num % 2 == 0)
                    return false;

                for (int i = 3; i * i <= num; i += 2)
                {
                    if (num % i == 0)
                        return false;
                }

                return true;

            }
        }
    }
}







