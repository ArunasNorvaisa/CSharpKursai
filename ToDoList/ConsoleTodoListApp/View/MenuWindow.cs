using ConsoleTodoListApp.Gui;
using ConsoleTodoListApp.Gui.Pictures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.View
{
    class MenuWindow : Window
    {

        private Diamond diamond1;
        private Diamond diamond2;
        private TextLine title;
        private TextLine copirightText;
        private Candle candle1;
        private Candle candle2;
        Dictionary<ButtonName, Button> menuButtons = new Dictionary<ButtonName, Button>();

        private ButtonName activeButtonName;

        public MenuWindow() : base(0, 0, 120, 30, "MENU")
        {
            diamond1 = new Diamond(10, 5);
            diamond2 = new Diamond(92, 5);
            candle1 = new Candle(5, 18);
            candle2 = new Candle(105, 18);

            title = new TextLine(20, 3, 80, " !!! My super TODO APP !!! ", true, ConsoleColor.Cyan, ConsoleColor.DarkRed);
            copirightText = new TextLine(10, 27, 100, "All right Not reserved, go wild!, 2020", true, ConsoleColor.DarkGray);




            int menuY = 16;
            int menuX = 22;
            int menuGaps = 28;
            int menuButtonWidth = 20;
            int menuButtonHeight = 5;


            List<ButtonName> menuButtonNames = new List<ButtonName>() { ButtonName.Start, ButtonName.Credits, ButtonName.Quit };
            activeButtonName = menuButtonNames[0];
            for (int i = 0; i < menuButtonNames.Count; i++)
            {
                Button button = new Button(menuX + menuGaps * i, menuY, menuButtonWidth, menuButtonHeight, menuButtonNames[i].ToString());
                menuButtons.Add(menuButtonNames[i], button);
            }
            SetButtonActive(activeButtonName);
        }

        public void SetButtonActive(ButtonName buttonName)
        {
            // sena migtuka diaktivuot.
            menuButtons[activeButtonName].Deactivate();
            activeButtonName = buttonName;
            // nauja migtuka aktivuot
            menuButtons[activeButtonName].Activate();
        }

        public override void Draw()
        {
            base.Draw();
            diamond2.Draw();
            diamond1.Draw();
            candle1.Draw();
            candle2.Draw();
            title.Draw();
            copirightText.Draw();

            foreach (var buttonData in menuButtons)
            {
                buttonData.Value.Draw();
            }

        }
    }
}
