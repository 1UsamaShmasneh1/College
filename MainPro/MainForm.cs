using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hackerme.DB;

namespace MainPro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Course dotNetBasic = new Course();
            Course oOP = new Course();
            Course core = new Course();
            Course hTML = new Course();
            Course cSS = new Course();
            MyDB.courses.Add(dotNetBasic);
            MyDB.courses.Add(oOP);
            MyDB.courses.Add(core);
            MyDB.courses.Add(hTML);
            MyDB.courses.Add(cSS);
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            StudentUserControl studentUserContro = new StudentUserControl();
            MainPanel.Controls.Add(studentUserContro);
            studentUserContro.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
