using EasyArchive.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive
{
    public partial class MainForm : Form
    {
        ActivityLogger _activityLogger;
        public MainForm()
        {
            InitializeComponent();
            _activityLogger = new ActivityLogger(new LabelDisplay(lblStatus));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("Cancel btn clicked");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("Ok btn clicked");
        }
    }
}
