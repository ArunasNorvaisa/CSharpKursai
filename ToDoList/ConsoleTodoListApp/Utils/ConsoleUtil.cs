using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Utils
{
    static class ConsoleUtil
    {

        public static void FillArea(int x, int y, int width, int height, char fillCharacter = ' ')
        {
            string line = "";
            // sukurti eilutes string
            for (int i = 0; i < width; i++)
            {
                line += fillCharacter;
            }

            // ispiesti visas eilutes specifinese x, y..
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(line);
            }
        }

        public static void Draw(int x, int y, char drawCharacter, ConsoleColor foregroundColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            SetNewColors(foregroundColor, backgroundColor);
            Console.SetCursorPosition(x, y);
            Console.Write(drawCharacter);
            RestoreOldColors();
        }

        public static void Draw(int x, int y, string drawData, ConsoleColor foregroundColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            SetNewColors(foregroundColor, backgroundColor);
            Console.SetCursorPosition(x, y);
            Console.Write(drawData);
            RestoreOldColors();
        }

        static private ConsoleColor oldForegroundColor;
        static private ConsoleColor oldBackgroundColor;
        private static void SetNewColors(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            oldForegroundColor = Console.ForegroundColor;
            oldBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
        }
        private static void RestoreOldColors()
        {
            Console.ForegroundColor = oldForegroundColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}
