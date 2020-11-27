using System;
using CaesarCipherLibrary;

namespace CaesarCodeApp_Milosevic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola:");
            string plaintext = Console.ReadLine();
            int key;
            CaesarCode m1;

            try
            {
                do
                {
                    Console.WriteLine("Inserisci la chiave:");
                    key = int.Parse(Console.ReadLine());
                } while (key < 0 || key > 25);

                m1 = new CaesarCode(plaintext, key);

                Console.WriteLine($"Il testo cifrato è: {m1.CipherText}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
