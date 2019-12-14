using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace CSharpKursai
{
  public static class Pamoka3
  {
    
    private static int Pow(this int bas, int exp)
    {
      return Enumerable
        .Repeat(bas, exp)
        .Aggregate(1, (a, b) => a * b);
    }
    public static void Meniu()
    {
      string[] gerimai = {"Kava", "Arbata", "Vanduo"};
      Console.WriteLine("Meniu. Pasirinkite vieną:");
      for (int i = 0; i < gerimai.Length; i++)
      {
        Console.WriteLine($"{i + 1}: {gerimai[i]}");
      }

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
      for (int i = 0; i <= max; i += 3)
      {
        Console.Write(i + ", ");
      }
    }

    public static void Kvadratai()
    {
      Console.WriteLine("\nĮveskite mažesnį skaičių:");
      int min = int.Parse(Console.ReadLine());
      Console.WriteLine("Įveskite didesnį skaičių:");
      int max = int.Parse(Console.ReadLine());
      if (min >= max)
      {
        Console.WriteLine("Įvedimo klaida");
      }
      else
      {
        for (int i = min + 1; i < max; i++)
        {
          Console.WriteLine($"{i} {Math.Pow(i, 2)}");
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
      for (int i = 1; i <= 1000; i++)
      {
        suma += i;
      }

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
        if (i > 123)
        {
          break;
        }
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

    public class AtsitiktiniaiSkaiciai
    {
      private static int SkaitykIvesti()
      {
        Console.WriteLine("Įveskite skaičių nuo 1 iki 100");
        int skaicius = int.Parse(Console.ReadLine());
        return skaicius;
      }
      
      private static int RandomNumber(int min, int max)  
      {  
        Random random = new Random();
        return random.Next(min, max);  
      }

      public static void AtspekSkaiciu()
      {
        int atsSkaicius = RandomNumber(0, 100);
        Console.WriteLine($"atsSkaicius {atsSkaicius}");
        int skaicius = SkaitykIvesti();
        bool arTesti = true;
        while (arTesti)
        {
          if (skaicius < atsSkaicius)
          {
            Console.WriteLine("Įvestas skaičius mažesnis už kompiuterio sugalvotą");
            skaicius = SkaitykIvesti();
          }
          else if (skaicius > atsSkaicius)
          {
            Console.WriteLine("Įvestas skaičius didesnis už kompiuterio sugalvotą");
            skaicius = SkaitykIvesti();
          }
          else
          {
            Console.WriteLine($"PERGALĖ!!! Jūsų ir mūsų skaičius - {skaicius}");
            arTesti = false;
          }
        }
      }
    }

    public class Challenge
    {
      private static string ReadInput()
      {
        Console.WriteLine("Įveskite skaičių:");
        string input = Console.ReadLine();
        return input;
      }
      
      private static int CharToInt(char c)
      {
        return (c - '0');
      }

      private static int StringToInt(string str)
      {
        bool isPositive = true;
        if (str[0].Equals('-'))
        {
          str = str.Replace(str[0], '0');
          isPositive = false;
        }
        int result = 0;
        int j = str.Length - 1;
        for (int i = 0; i < str.Length; i++)
        {
          result += CharToInt(str[i]) * 10.Pow(j);
          j--;
        }
        if (!isPositive) result *= -1;

        return result;
      }

      private static bool IsNumeric(string str)
      {
        return Regex.IsMatch(str, @"^-?\d+$");
      }

      public static string Variantas1()
      {
        string input = ReadInput();
        
        if (!IsNumeric(input))
        {
          Console.WriteLine("Įvedimo klaida, galima vesti tik skaičius ir minuso ženklą");
          return "";
        }
        
        int number = StringToInt(input);
        string output = "";
        
        if (number < -9 || number > 9)
        {
          Console.WriteLine("Įvedimo klaida, veskite skaičius nuo -9 iki 9");
          return "";
        }

        if (number < 0)
        {
          output = "minus ";
          number = Math.Abs(number);
        }
        
        switch (number)
        {
          case 0:
            return "nulis";
            break;
          case 1:
            output += "vienas";
            break;
          case 2:
            output += "du";
            break;
          case 3:
            output += "trys";
            break;
          case 4:
            output += "keturi";
            break;
          case 5:
            output += "penki";
            break;
          case 6:
            output += "šeši";
            break;
          case 7:
            output += "septyni";
            break;
          case 8:
            output += "aštuoni";
            break;
          case 9:
            output += "devyni";
            break;
        }
        return output;
      }
    }
  }
}
