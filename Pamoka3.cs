using System;

namespace CSharpKursai
{
  public class Pamoka3
  {
    public static void Meniu()
    {
      System.Console.WriteLine("Meniu:\n 1.Kava\n 2. Arbata\n 3.Vanduo\nPasirinkite:");
      int number;
      do
      {
        number = int.Parse(Console.ReadLine());
        if (number < 1 || number > 3)
        {
          System.Console.WriteLine("Tokio gėrimo mūsų meniu nėra");
        }
      } while (number >= 1 && number <= 3);

      System.Console.WriteLine("Jūs pasirinkote: " + number);
    }

    public static void KasTreciasSkaicius(int max)
    {
      for (int i = 0; i <= max; i += 3)
      {
        System.Console.Write(i + ", ");
      }
    }

    public static void Kvadratai()
    {
      Console.WriteLine("Įveskite mažesnį skaičių:");
      int min = int.Parse(Console.ReadLine());
      Console.WriteLine("Įveskite didesnį skaičių:");
      int max = int.Parse(Console.ReadLine());
      if (min >= max)
      {
        System.Console.WriteLine("Įvedimo klaida");
      }
      else
      {
        for (int i = min + 1; i < max; i++)
        {
          System.Console.WriteLine($"{i} {Math.pow(i, 2)}");
        }
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
      int fibonacci1 = 0;
      int fibonacci2 = 1;
      int temp;
      for (int i = 1; i <= howMany; i++)
      {
        System.Console.WriteLine($"{i}: {fibonacci1};");
        temp = fibonacci1;
        fibonacci1 = fibonacci2;
        fibonacci2 += temp;
      }
    }

    public static void SumaIki1000()
    {
      int suma = 0;
      for (int i = 1; i <= 1000; i++)
      {
        suma += i;
      }

      System.Console.WriteLine(suma);
    }

    public static void SumaIki1000Papildymas1()
    {
      int suma = 0;
      for (int i = 1; i <= 1000; i++)
      {
        if (i % 5 != 0) suma += i;
      }

      System.Console.WriteLine(suma);
    }

    public static void SumaIki1000Papildymas2()
    {
      int suma = 0;
      for (int i = 1; i <= 1000; i++)
      {
        if (i > 123) break;
        suma += suma;
      }

      System.Console.WriteLine(suma);
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

      System.Console.WriteLine(suma);
    }

    public class AtsitiktiniaiSkaiciai
    {
      private static void skaitykIvesti()
      {
        System.Console.WriteLine("Įveskite skaičių nuo 1 iki 100");
        int skaicius = System.Console.Read();
        return skaicius;
      }

      public static void AtspekSkaiciu()
      {
        int atsSkaicius = new Random().Next(0, 100);
        int skaicius = skaitykIvesti();
        bool arTesti = true;
        while (arTesti)
        {
          if (skaicius < atsSkaicius)
          {
            System.Console.WriteLine("Įvestas skaičius mažesnis už kompiuterio sugalvotą");
            skaitykIvesti();
          }
          else if (skaicius > atsSkaicius)
          {
            System.Console.WriteLine("Įvestas skaičius didesnis už kompiuterio sugalvotą");
            skaitykIvesti();
          }
          else
          {
            System.Console.WriteLine($"PERGALĖ!!! Jūsų skaičius - {skaicius}");
            arTesti = false;
          }
        }
      }
    }
  }
}