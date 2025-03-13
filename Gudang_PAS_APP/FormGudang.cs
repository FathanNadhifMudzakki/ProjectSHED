using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudang_PAS_APP
{
    public partial class FormGudang : Form
    {
        public FormGudang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void FormGudang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NambahBarang ftambahbarang = new NambahBarang();
            ftambahbarang.Show();
        }
    }
}
