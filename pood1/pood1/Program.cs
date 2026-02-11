using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pood1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string password = "731";
      int maxAttempts = 3;
      int attempts = 0;

      Console.WriteLine("=== Secure Safe ===");

      while (attempts < maxAttempts)
      {
        Console.Write("Enter password (Ctrl + C to exit): ");
        string input = Console.ReadLine();      

        if (input == password)
        {
          Console.WriteLine("Welcome!");
          break;
        }
        else
        {
          attempts++;
          Console.WriteLine("Wrong password Attempt {0}/{1}", attempts, maxAttempts);
        }
      }

      if (attempts == maxAttempts)
      {
        Console.WriteLine("SYSTEM LOCKED!");
        Console.WriteLine("Too many failed attempts.");
      }

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();



    }
  }
}
