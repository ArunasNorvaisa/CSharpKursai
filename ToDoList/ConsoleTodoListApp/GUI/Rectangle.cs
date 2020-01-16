using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.GUI
{
  class Rectangle
  {
    private int x;
    private int y;
    private int width;
    private int height;

    private char drawCharacter;

    public Rectangle(int x, int y, int width, int height, char drawCharacter = '#')
    {
      this.x = x;
      this.y = y;
      this.width = width;
      this.height = height;
      this.drawCharacter = drawCharacter;

    }

    public void Draw()
    {
      for (int j = 0; j < height; j++)
      {
        Console.SetCursorPosition(x, y + j);
        for (int i = 0; i < width; i++)
        {
          if (j == 0 || j == height - 1 || i == 0 || i == width - 1)
          {
            Console.Write(drawCharacter);
          }
          else
          {
            Console.Write(' ');
          }
        }
      }
    }
  }
}
