using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gennalize_Tick_Tack_Toe
{
    enum Turn { BLUE,RED,EMPTY};
    class Cells:Button
    {
        public int  ri;
        public int ci;
        public Turn Value;
       public Cells(int r,int c)
        {
           this.ri=r;
           this.ci=c;
           this.Value=Turn.EMPTY;
        }
    }
}
