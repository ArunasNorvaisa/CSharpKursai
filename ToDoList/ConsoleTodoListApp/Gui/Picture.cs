using ConsoleTodoListApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class Picture : GuiObject
    {

        private string[] pictureLines;

        public Picture(int x, int y, string picData) : base(x, y, 0, 0)
        {
            SetPicture(picData);
        }

        public void SetPicture(string picData)
        {
            pictureLines = picData.Split('\n');
            Height = pictureLines.Length;

            int longestLineLenght = 0;
            for (int i = 0; i < pictureLines.Length; i++)
            {
                if (pictureLines[i].Length > longestLineLenght)
                {
                    pictureLines[i] = pictureLines[i].Trim('\r');
                    longestLineLenght = pictureLines[i].Length;
                }
            }
            Width = longestLineLenght;
        }

        public override void Draw()
        {
            for (int i = 0; i < pictureLines.Length; i++)
            {
                ConsoleUtil.Draw(X, Y + i, pictureLines[i]);
            }
        }
    }
}
