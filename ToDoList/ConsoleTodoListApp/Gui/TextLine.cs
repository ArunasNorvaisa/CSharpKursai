using ConsoleTodoListApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class TextLine : GuiObject
    {
        private string data;

        public bool IsCentered;

        private ConsoleColor textColor;
        private ConsoleColor backgroundColor;

        public TextLine(
            int x, int y, 
            int width,
            string data,
            bool isCentered = false,
            ConsoleColor textColor = ConsoleColor.White,
            ConsoleColor backgroundColor = ConsoleColor.Black
            ) : base(x, y, width, 1)
        {
            this.data = data;
            IsCentered = isCentered;
            this.textColor = textColor;
            this.backgroundColor = backgroundColor;
        }

        public override void Draw()
        {
            if (IsCentered && data.Length < Width)
            {
                ConsoleUtil.Draw(X + (Width - data.Length) / 2, Y, data, textColor, backgroundColor);
            }
            else
            {
                string printData = data;
                if (data.Length > Width)
                {
                    printData = data.Substring(0, Width);
                }
                ConsoleUtil.Draw(X, Y, printData, textColor, backgroundColor);
            }
        }
    }
}
