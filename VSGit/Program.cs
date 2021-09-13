using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGit
{
  class Program
  {
    static void Main(string[] args)
    {
      ElsoFeladat();
      Masodikfeladat();

      Console.ReadKey();
    }

    private static void Masodikfeladat()
    {
      Random rnd = new Random();
      int veletlen = rnd.Next(1, 101);
      Console.WriteLine("Random szám:{0}", rnd.Next(1, 101));
    }

    private static void ElsoFeladat()
    {
      Console.WriteLine("Próba");
    }
  }
}
