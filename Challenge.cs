using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpKursai
{
  public static class Challenge
  {
    private static int Pow(this int bas, int exp)
    {
      return Enumerable
        .Repeat(bas, exp)
        .Aggregate(1, (a, b) => a * b);
    }
    private static string ReadInput()
    {
      Console.WriteLine("Įveskite skaičių nuo -9 iki 9:");
      string input = Console.ReadLine();
      return input;
    }
    
    private static int CharToInt(char c) => c - '0';

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

    private static bool IsNumeric(string str) => Regex.IsMatch(str, @"^-?\d+$");

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