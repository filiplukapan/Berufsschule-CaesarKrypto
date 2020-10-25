using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ceasar_Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            intro();
        }
        static void intro()
        {
            Console.WriteLine("Do you want to encrypt or decrypt?");
            Thread.Sleep(1500);
            Console.Write("Press e (for encryption) or d (for decryption): ");
            string einlesen = Console.ReadLine();
            if (einlesen == "e")
            {
                encrypt();
            }
            else if (einlesen == "d")
            {
                decrypt();
            }
            else
            {
                Console.WriteLine("invalid");
                intro();
            }
        }
        static void encrypt()
        {
            Console.WriteLine("");
            Console.WriteLine("Now enter an integer for shifting.");
            Thread.Sleep(1000);
            Console.Write("Enter the integer for shifting: ");
            int key = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            key = key % 37;
            Console.Write("Now write the text you want to encrypt: ");
            string para = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Shifting " + para + " for " + key + " times");
            Console.WriteLine("");
            string parag = para.ToUpper();
            char[] text = parag.ToCharArray();
            int j = text.Length - 1;
            int k = alpha.Length - 1;
            char[] text3 = new char[text.Length];
            for (int i = 0; i <= j; i++)
            {
                char text2 = text[i];
                int n = Array.IndexOf(alpha, text2);
                int f = n + key;
                if (f > k)
                {
                    f = f - k;
                }
                text3[i] = alpha[f];
            }
            string fin = new string(text3);
            Console.WriteLine(text3);
            intro();
        }
        static void decrypt()
        {
            Console.WriteLine("");
            Console.WriteLine("Now enter an integer for shifting.");
            Thread.Sleep(1000);
            Console.Write("Enter the integer for shifting: ");
            int key = Convert.ToInt16(Console.ReadLine());
            key = key % 37;
            Console.Write("Now write the text you want to decrypt: ");
            string para = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Shifting " + para + " for " + key + " times");
            Console.WriteLine("");
            string parag = para.ToUpper();
            char[] text = parag.ToCharArray();
            int j = text.Length - 1;
            int k = alpha.Length - 1;
            char[] text3 = new char[text.Length];
            for (int i = 0; i <= j; i++)
            {
                char text2 = text[i];
                int n = Array.IndexOf(alpha, text2);
                int f = n - key;
                if (f < 0)
                {
                    f = f + k;
                }
                text3[i] = alpha[f];
            }
            string fin = new string(text3);
            Console.WriteLine(text3);
            intro();
        }
        static char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '5', '6', '7', '8', '9', '0', ' ', '.', ',', '?' };
    }
}