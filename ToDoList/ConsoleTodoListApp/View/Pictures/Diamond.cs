using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui.Pictures
{
    class Diamond : Picture
    {
        static private string diamondPicture =
@"  .     '     ,
    _________
 _ /_|_____|_\ _
   '. \   / .'
     '.\ /.'
       '.'";

        public Diamond(int x, int y) : base(x, y, diamondPicture)
        {
        }


    }
}
