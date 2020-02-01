using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class Window : Rectangle
    {
        private TextLine lable;

        public Window(int x, int y, int width, int height, string lableText) : base(x, y, width, height, '*')
        {
            lable = new TextLine(x + 1, y, width - 2, lableText, true, ConsoleColor.Green);
        }

        public override void Draw()
        {
            base.Draw();
            lable.Draw();
        }
    }
}
