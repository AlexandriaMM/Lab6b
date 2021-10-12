using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] Odd = new int[10];
    int[] Even = new int[10];
    int sumEven = 0;
    int sumOdd = 0;

    for(int i = 0; i < 10; i++)
    {
      Console.WriteLine("enter a number");
      int number = Convert.ToInt32(Console.ReadLine());
      if(number % 2 == 0)
      {
        Even[i] = number;
        sumEven = sumEven + Even[i];
      }
      else
      {
        Odd[i] = number;
        sumOdd = sumOdd + Odd[i];
      }
    }
    Array.Sort(Even);
    foreach (int n in Even)
     {
      Console.WriteLine(n);
     }

    Array.Reverse(Odd);
    foreach (int j in Odd)
    {
     Console.WriteLine(j);
    }

    Console.WriteLine("Sum of odd numbers: " + sumOdd);
    Console.WriteLine("Sum of even numbers: " + sumEven); 
  }
}