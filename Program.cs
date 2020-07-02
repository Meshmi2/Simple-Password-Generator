using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
namespace Pass
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !");
            Console.WriteLine("Secure Password Generator");
            Console.WriteLine("Please Input Your Name");
           // Read Old Password
            string string1 = Console.ReadLine();
            Console.WriteLine(string1 + " Is your Name?");
            var rnd = new Random();
            // Pause for 3 second
            Thread.Sleep(3000);
            // Instantiate random number generator using system-supplied value as seed.
            var rand = new Random();
            Console.WriteLine("Your New Password");
            Console.WriteLine("Possible Secure Password = ");
            // Generate And Display 5 Random Values
            var bytes = new byte[5];
            rand.NextBytes(bytes);
            foreach (byte byteValue in bytes)
                Console.Write("{0, 5}"+string1, byteValue);
            //Pause
            Console.WriteLine(" ...now the program exits");
            Thread.Sleep(9000);

        }
    }
}
