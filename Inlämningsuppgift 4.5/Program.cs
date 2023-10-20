using System;

namespace uppgift_4._5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();

            for (int i = 0;i<heltal.Length;i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                int x = siffra+1;
                if (x == 10)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.Write(x);
                }
            }
            Console.Read();
        }
    }
}