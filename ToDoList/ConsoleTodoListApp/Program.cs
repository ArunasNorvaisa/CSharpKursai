using ConsoleTodoListApp.Gui;
using ConsoleTodoListApp.Gui.Pictures;
using ConsoleTodoListApp.View;
using System;
using System.Collections.Generic;

namespace ConsoleTodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;


            MenuWindow menuWindow = new MenuWindow();

            menuWindow.SetButtonActive(ButtonName.Start);
            menuWindow.SetButtonActive(ButtonName.Quit);

            menuWindow.Draw();




            //Window menu = new Window(0, 0, 120, 30, "MENU");
            //menu.Draw();

            

            /*
            Diamond diamond = new Diamond(5, 10);
            diamond.Draw();

            Candle candle = new Candle(40, 3);
            candle.Draw();


            Rectangle rectangle = new Rectangle(60, 10, 15, 10);
            rectangle.Draw();

            Rectangle rectangle2 = new Rectangle(60, 7, 5, 7, '+');
            rectangle2.Draw();

            int x = 30; 
            int y = 15;
            int width = 20;
            TextLine textLine = new TextLine(x, y, width, "My super todo list app!");
            textLine.Draw();




            Console.ReadKey();

            */
            Console.ReadKey();
            Console.SetCursorPosition(0, 25);
        }
    }
}
