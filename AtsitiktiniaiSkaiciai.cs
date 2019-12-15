using System;

namespace CSharpKursai
{
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
      int kompSkaicius = RandomNumber(0, 100);
      Console.WriteLine($"Komp. sugalvotas skaičius: {kompSkaicius}"); // Šiaip, kad būtų lengviau ;)
      int musuSkaicius = SkaitykIvesti();
      bool arTesti = true;
      while (arTesti)
      {
        if (musuSkaicius < kompSkaicius)
        {
          Console.WriteLine("Įvestas skaičius mažesnis už kompiuterio sugalvotą");
          musuSkaicius = SkaitykIvesti();
        }
        else if (musuSkaicius > kompSkaicius)
        {
          Console.WriteLine("Įvestas skaičius didesnis už kompiuterio sugalvotą");
          musuSkaicius = SkaitykIvesti();
        }
        else
        {
          Console.WriteLine($"PERGALĖ!!! Kompiuterio sugalvotas skaičius: {musuSkaicius}");
          arTesti = false;
        }
      }
    }
  }
}