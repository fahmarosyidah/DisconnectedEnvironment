using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class DataMaster : Form
    {
        public DataMaster()
        {
            InitializeComponent();
        }

        private void dataProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataProdi fm = new FormDataProdi();
            fm.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataMahasiswa fo = new FormDataMahasiswa();
            fo.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataStatusMahasiswa fr = new FormDataStatusMahasiswa();
            fr.Show();
            this.Hide();
        }
    }
}
