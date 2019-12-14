using System;

namespace CSharpKursai
{
  public class Program
  {
    private static void Main()
    {
      // Pamoka1:
      // Pamoka1.ApskritimoIlgisPlotas(1.2);
      // Pamoka1.GreitisKmh(3001, 151);
      // Pamoka1.MokinioIvertinimas(10);
      // Pamoka1.MokinioIvertinimas(-15);
      // Pamoka1.DidziausiasSkaicius(-1, -15.15, 23.054);
      
      //Pamoka3:
      Pamoka3.Meniu();
      Pamoka3.KasTreciasSkaicius(34);
      Pamoka3.Kvadratai();
      Console.WriteLine(Pamoka3.DaliniuSuma(3434));
      Pamoka3.Fibonacci(23);
      Pamoka3.SumaIki1000();
      Pamoka3.SumaIki1000Papildymas1();
      Pamoka3.SumaIki1000Papildymas2();
      Pamoka3.SumaIki1000Pakeista();
      Console.WriteLine(Pamoka3.Challenge.Variantas1());
      Pamoka3.AtsitiktiniaiSkaiciai.AtspekSkaiciu();
    }
  }
}
