using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui.Pictures
{
    class Candle : Picture
    {

        static private string candleData =
@"    (
     )
    ()
   |--|
   |  |
 .-|  |-.
:  |  |  :
:  '--'  :
 '-....-'";
        
        public Candle(int x, int y) : base(x, y, candleData)
        {
        }
    }
}
