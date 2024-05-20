using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Master_Data : Form
    {
        public Master_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_admin obj = new data_admin();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data_guru obj = new data_guru();
            obj.Show();
            this.Hide();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            data_kelas obj = new data_kelas();
            obj.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            data_paketbimbel obj = new data_paketbimbel();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DATA_SISWA obj = new DATA_SISWA();
            obj.Show();
            this.Hide();
        }
    }
}
