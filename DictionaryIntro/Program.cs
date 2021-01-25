using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> adYas = new MyDictionary<string, int>();
            adYas.Add("Sueda", 20);
            Console.WriteLine(adYas.Count);
            adYas.Add("Elif", 30);
            Console.WriteLine(adYas.Count);
            adYas.Add("Zehra", 50);

            for (int i = 0; i < adYas.Count; i++)
            {
                for (int j = 0; j < adYas.Count; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("["+adYas.Items[i]+","+adYas.Items2[j]+"]");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
