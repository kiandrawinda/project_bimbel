﻿using System;
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
    public partial class dashboardadmin : Form
    {
        public dashboardadmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Master_Data obj = new Master_Data();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jadwal_pelajaran obj = new jadwal_pelajaran();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ANGGOTA_BIMBEL obj = new ANGGOTA_BIMBEL();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_angsuran obj = new Data_angsuran();
            obj.Show();
            this.Hide();
        }
    }
}
