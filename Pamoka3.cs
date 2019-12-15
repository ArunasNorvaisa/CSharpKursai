using System;

namespace CSharpKursai
{
  public class Pamoka3
  {
    public static void Meniu()
    {
      string[] gerimai = {"Kava", "Arbata", "Vanduo"};
      Console.WriteLine("Meniu. Pasirinkite vieną:");
      for (int i = 0; i < gerimai.Length; i++) Console.WriteLine($"{i + 1}: {gerimai[i]}");

      int number = int.Parse(Console.ReadLine());
      while (number < 1 || number > 3)
      {
        Console.WriteLine("Tokio gėrimo mūsų meniu nėra");
        number = int.Parse(Console.ReadLine());
      }

      Console.WriteLine($"Jūs pasirinkote: {gerimai[number - 1]}");
    }

    public static void KasTreciasSkaicius(int max)
    {
      for (int i = 0; i <= max; i += 3) Console.Write(i + ", ");
    }

    public static void Kvadratai()
    {
      Console.WriteLine("\nĮveskite mažesnį skaičių:");
      int min = int.Parse(Console.ReadLine());
      
      Console.WriteLine("Įveskite didesnį skaičių:");
      int max = int.Parse(Console.ReadLine());
      
      if (min >= max) Console.WriteLine("Įvedimo klaida");
      else
      {
        for (int i = min + 1; i < max; i++) Console.WriteLine($"{i} {Math.Pow(i, 2)}");
      }
    }

    public static int DaliniuSuma(int maxNumber)
    {
      int suma = 0;
      for (int i = maxNumber - 1; i < 0; i--)
      {
        if (i % 3 == 0 || i % 5 == 0) suma += i;
      }

      return suma;
    }

    public static void Fibonacci(int howMany)
    {
      int fibonacci1 = 0,
          fibonacci2 = 1,
          temp;
      
      for (int i = 1; i <= howMany; i++)
      {
        Console.WriteLine($"Fibonacci #{i}: {fibonacci1};");
        temp = fibonacci1;
        fibonacci1 = fibonacci2;
        fibonacci2 += temp;
      }
    }

    public static void SumaIki1000()
    {
      int suma = 0;
      for (int i = 1; i <= 1000; i++) suma += i;
      Console.WriteLine(suma);
    }

    public static void SumaIki1000Papildymas1()
    {
      int suma = 0;
      for (int i = 1; i <= 1000; i++)
      {
        if (i % 5 != 0) suma += i;
      }

      Console.WriteLine(suma);
    }

    public static void SumaIki1000Papildymas2()
    {
      int suma = 0;
      for (int i = 1; i <= 1000; i++)
      {
        if (i > 123) break;
        
        suma += i;
      }

      Console.WriteLine($"suma iki 123: {suma}");
    }

    public static void SumaIki1000Pakeista()
    {
      int suma = 0;
      int i = 1;
      
      for (;;)
      {
        if (i <= 1000)
        {
          suma += i;
          i++;
        }
        else break;
      }

      Console.WriteLine(suma);
    }
  }
}
