using System;

namespace CaesarCrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
   _____         _____ 
  / ____|       / ____|
 | |           | |     
 | |           | |     
 | |___        | |____ 
  \_____AESAR'S \_____|ODE
               
");
            Console.WriteLine("=================================");
            Console.WriteLine("Menu:");
            Console.WriteLine("\t1 - Encrypt");
            Console.WriteLine("\t2 - Decrypt");
            Console.WriteLine("\t0 - Exit");
            Console.WriteLine("=================================");

            int op = -1;
            do
            {
                Console.WriteLine("What do you wanna do?");
                op = int.Parse(Console.ReadLine());
            } while (op < 0 || op > 2);

            string phrase = "", cryptoPhrase = "";
            int key = 0;
            Cryptography crypt = new Cryptography();
            switch (op)
            {
                case 1: // Encrypt
                    Console.WriteLine("What do you want to Encrypt?");
                    phrase = Console.ReadLine();

                    Console.WriteLine("What's the code? (a number from 0 to 25)");
                    key = int.Parse(Console.ReadLine());

                    cryptoPhrase = crypt.Encrypt(phrase, key);
                    Console.WriteLine("\nYour Encrypted Phrase is:");
                    Console.WriteLine("\t\"" + cryptoPhrase + "\", Key - " + key);
                    break;

                case 2: // Decryptograph
                    Console.WriteLine("What do you want to Decrypt?");
                    phrase = Console.ReadLine();

                    Console.WriteLine("What's the code? (a number from 0 to 25)");
                    key = int.Parse(Console.ReadLine());

                    cryptoPhrase = crypt.Decrypt(phrase, key);
                    Console.WriteLine("\nYour Decrypted Phrase is:");
                    Console.WriteLine("\t\"" + cryptoPhrase + "\", Key - " + key);
                    break;

                default: // Exit
                    Console.WriteLine("\nFinishing Application...\n\nThanks for using it!\n");

                    Console.WriteLine("Press enter to continue...");
                    Console.Read();

                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("\nFinishing Application...\n\nThanks for using it!\n");

            Console.WriteLine("Press enter to continue...");
            Console.Read();

            Environment.Exit(0);
        }
    }
}
