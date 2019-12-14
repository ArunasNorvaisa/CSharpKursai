using System;

namespace CSharpKursai
{
  class Pamoka1
  {
    float myFloat = 12.5f;
    int myInt = -100;
    char myChar = 'a';
    string myString = "uzduotis";
    bool myBool = false;

    Console.WriteLine("Įveskite vardą:");
    string vardas = Console.ReadLine();
    Console.WriteLine("Įveskite pavardę:");
    string pavarde = Console.ReadLine();
    Console.WriteLine("Įveskite amžių:");
    int amzius = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Įveskite ūgį:");
    double ugis = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Įvestas vardas: " + vardas);
    Console.WriteLine("Įvesta pavardė: " + pavarde);
    Console.WriteLine("Įvestas amžius: " + amzius);
    Console.WriteLine("Įvestas ūgis: " + ugis);

    public static void ApskritimoIlgisPlotas (double spindulys)
    {
      Console.WriteLine("Apskritimo plotas: " + Math.PI * Math.Pow(spindulys, 2));
      Console.WriteLine("Apskritimo ilgis: " + Math.PI * 2 * spindulys);
    }
    
    public static double GreitisKmh(int m, int s)
    {
      return (m * 1000) / (s * 3600);
    }
    
    public static string MokinioIvertinimas (int pazymys)
    {
      switch (pazymys)
      {
        case 10:
          return "puiku";
        case 9:
        case 8:
          return "labai gerai";
        case 7:
        case 6:
          return "gerai";
        case 5:
          return "vidutiniškai";
        case 4:
          return "bent teigiamas";
        case 3:
        case 2:
        case 1:
          return "labai blogai";
        default:
          return "neteisingas pažymys";
      }
    }
    
    public static string DidziausiasSkaicius(double x, double y, double z) {
      //Papildomos sąlygos:
      if (x > y && x < 100)
      {
        Console.WriteLine($"{x} yra didesnis už {y} ir mažesnis už 100");
      }
      if (y > 0 || y > x)
      {
        Console.WriteLine($"{y} yra didesnis už {x} arba didesnis už 0");
      }
      if ((x > y && x > z) || x >= 0)
      {
        Console.WriteLine($"{x} yra didesnis už {y} ir {z} arba teigiamas");
      }
      if ((z >= 5 && z <= 10) || z > x || z > y)
      {
        Console.WriteLine($"{z} yra didesnis už {x} arba {y} arba patenka į rėžius 5-10");
      }
      //Pagrindinė sąlyga:
      if (x >= y && x >= z)
      {
        return "Didžiausias skaičius: " + x;
      }
      if (y >= z)
      {
        return "Didžiausias skaičius: " + y;
      }
      return "Didžiausias skaičius: " + z;
    };
  }
}
