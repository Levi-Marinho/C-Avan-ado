using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class2

{
  public class Ex1
  {
    public static void run()
    {
      // Imprima os números 1 - 1000 em uma thread, e os números 1001-2000 em
      // outra thread.
      // Use System.Threading.Thread.
      // Quando ambas as threads terminarem, imprima "Pronto.".

    Thread t = new Thread (Write2);
    Thread a = new Thread (Go);
    t.Start();
    a.Start();

    t.Join();
    a.Join();
    Console.Write("  Pronto.");


    

    void Go() {for (int i = 1; i <1001; i++) Console.WriteLine(i); };

    void Write2()
    {
      for(int i = 1001; i<2001; i++) Console.WriteLine(i);

    }
    }
  }
}