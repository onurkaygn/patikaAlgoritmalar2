using System.Collections;

namespace KoleksiyonAlgoritma1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string input = Console.ReadLine();
            string inputLower = input.ToLower();
            ArrayList sesliHarfler = new ArrayList();

           foreach (var item in inputLower) { 
                if(item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                {
                    sesliHarfler.Add(item);
                }
            }
           foreach (var harfler in sesliHarfler)
            {
                Console.WriteLine(harfler);
            }

            }
    }
    }
