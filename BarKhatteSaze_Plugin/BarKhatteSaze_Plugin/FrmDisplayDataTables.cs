using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarKhatteSaze_Plugin
{
    public partial class FrmDisplayDataTables : Form
    {
        public Dictionary<string, DataTable> DataTable { get; set; }
        public List<string> DataTableKeys { get; set; }
        public FrmDisplayDataTables()
        {
            InitializeComponent();
        }

        private void CmbbxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CmbbxTableNames.GetItemText(CmbbxTableNames.SelectedItem);
            DtgrdDataTables.DataSource = DataTable[selected];
        }

        private void FrmDisplayDataTables_Load(object sender, EventArgs e)
        {
            List<string> keyList = new List<string>(DataTableKeys);

            CmbbxTableNames.Items.Clear();
            CmbbxTableNames.ResetText();
            foreach (var key in keyList)
            {
                CmbbxTableNames.Items.Add(key);
            }
            DtgrdDataTables.DataSource = null;
        }
    }
}
