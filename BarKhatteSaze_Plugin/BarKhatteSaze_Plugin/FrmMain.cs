using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETABSv1;

namespace BarKhatteSaze_Plugin
{
    public partial class FrmMain : Form
    {
        public cPluginCallback _Plugin = null;
        public cSapModel _SapModel = null;
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(ref cSapModel SapModel, ref cPluginCallback Plugin)
        {
            _Plugin = Plugin;
            _SapModel = SapModel;
            InitializeComponent();
        }

        Dictionary<string, DataTable> EtabsDataTable;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            string FileAddress;
            try
            {
                // پیدا کردن آدرس فایل ایتبس
                FileAddress = _SapModel.GetModelFilename();
                
                // ساختن یک متغیر که همه داده ها در قالب جدول در آن قرار میگیرد
                EtabsDataTable = new Dictionary<string, DataTable>();
                // ایجاد آدرس فایل متنی
                FileAddress = FileAddress.Remove(FileAddress.Length - 3, 3) + "$et";
                // تقکیک مقادیر در جدولهای اطلاعات
                // Read Text Data => خواندن داده های متنی
                DialogResult SaveETABSFile;
                SaveETABSFile = MessageBox.Show("Do you want to save ETABS file?","Save ETABS File", MessageBoxButtons.YesNo);
                if (SaveETABSFile == DialogResult.Yes)
                {
                    _SapModel.File.Save();
                    EtabsDataTable = ReadData.ReadTextData(FileAddress);
                    LblInfo.Text = "Data was imported.";
                }
                else
                {
                    LblInfo.Text = "Data was mot imported.";
                }
            }
            catch
            {
                FileAddress = "C:\\Users\\Esmail\\Desktop\\Rayan\\Samples\\Ejaredar_V13.$et";
                EtabsDataTable = new Dictionary<string, DataTable>();
                EtabsDataTable = ReadData.ReadTextData(FileAddress);
                LblInfo.Text = "Error in reading data.";
            }
        }

        FrmDisplayDataTables DDTable;
        private void dataTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DDTable = new FrmDisplayDataTables()
            {
                DataTable = EtabsDataTable,
                DataTableKeys = EtabsDataTable.Keys.Cast<string>().ToList()
            };
            DDTable.Show();
        }
    }
}
