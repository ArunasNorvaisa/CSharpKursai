using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class Rectangle : GuiObject
    {
        private char drawCharacter;

        public Rectangle(int x, int y, int width, int height, char drawCharacter = '#') : base(x, y, width, height)
        {
            this.drawCharacter = drawCharacter;
        }

        public override void Draw()
        {
            for (int j = 0; j < Height; j++)
            {
                Console.SetCursorPosition(X, Y + j);
                for (int i = 0; i < Width; i++)
                {
                    if (j == 0 || j == Height - 1 || i == 0 || i == Width - 1)
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
