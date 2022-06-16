using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alarm501_Library;
namespace Alarm501_GUI
{
    public class Alarm501Controller
    {
        public static void Open(Model m)
        {
            Add_Edit add_Edit = new Add_Edit(m);
            add_Edit.Show();
        }
    }
}
