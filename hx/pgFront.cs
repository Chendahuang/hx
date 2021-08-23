using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hx
{
    public partial class pgFront : UIPage
    {
        public pgFront()
        {
            InitializeComponent();
        }

        private void ubtSelectLocate_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                utbDownload.Text = fbd.SelectedPath;
                AppConfigManage.modifyItem("datapath", fbd.SelectedPath);
            }
        }

        private void fmFront_Load(object sender, EventArgs e)
        {
            utbDownload.Text = AppConfigManage.valueItem("datapath");
        }
    }
}
