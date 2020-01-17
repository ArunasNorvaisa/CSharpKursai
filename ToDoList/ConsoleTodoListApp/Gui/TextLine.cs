using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class TextLine : GuiObject
    {
        private string data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 1)
        {
            this.data = data;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(X, Y);
            string printData = data;
            if (data.Length > Width)
            {
                printData = data.Substring(0, Width);
            }
            Console.Write(printData);
        }
    }
}
