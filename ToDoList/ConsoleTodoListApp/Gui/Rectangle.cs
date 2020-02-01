using ConsoleTodoListApp.Utils;
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

        public void ChangeDrawCharacter(char drawCharacter)
        {
            this.drawCharacter = drawCharacter;
            DrawFrame();
        }

        public override void Draw()
        {
            DrawBackground();
            DrawFrame();
        }

        private void DrawFrame()
        {
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (j == 0 || j == Height - 1 || i == 0 || i == Width - 1)
                    {
                        ConsoleUtil.Draw(X + i, Y + j, drawCharacter);
                    }
                }
            }
        }

        private void DrawBackground()
        {
            ConsoleUtil.FillArea(X + 1, Y + 1, Width - 2, Height - 2);
        }
    }
}
