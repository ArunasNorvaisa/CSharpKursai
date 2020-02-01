using ConsoleTodoListApp.Gui.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class Button : Rectangle, IActivatable
    {
        private TextLine lable;

        public Button(int x, int y, int width, int height, string lableText) : base(x, y, width, height, '+')
        {
            lable = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, lableText, true, ConsoleColor.Red);
        }

        public bool IsActive { get; private set; } = false;

        public void Activate()
        {
            if (!IsActive)
            {
                ChangeDrawCharacter('#');
                IsActive = true;
            }
        }

        public void Deactivate()
        {
            if (IsActive)
            {
                // pakeisk remali i "+"
                ChangeDrawCharacter('+');
                IsActive = false;
            }
        }

        public override void Draw()
        {
            base.Draw();
            lable.Draw();
        }
    }
}
