using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarKhatteSaze_Plugin
{
    public class cPlugin
    {
        FrmMain form;
        public void Main(ref ETABSv1.cSapModel SapModel, ref ETABSv1.cPluginCallback ISapPlugin)
        {
            //form = new FrmMain(ref SapModel, ref ISapPlugin);
            form = new FrmMain();
            form.Show();
        }
        public long Info(ref string Text)
        {
            Text = "Etabs plugin template created by Jeremy Atkinson";
            return 0;
        }
    }
}
