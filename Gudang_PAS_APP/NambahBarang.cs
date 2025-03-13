using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudang_PAS_APP
{
    public partial class NambahBarang : Form
    {

        private string conStr ="Data Source=SATYA\\MSSQLSERVER01;Initial Catalog=shed;Integrated Security=True";

        private SqlConnection sqlCon;

        private void ClearData()
        {
            textNamabarang.Clear();
            textIDKategori.Clear();
            texthargasatuan.Clear();
            txtstocks.Clear();
        }
        public NambahBarang()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conStr);
        }

        private void NambahBarang_Load(object sender, EventArgs e)
        {
            tampilDataBarang();
        }

        private void labelhargasatuan_Click(object sender, EventArgs e)
        {

        }

        private void labelsatuan_Click(object sender, EventArgs e)
        {

        }

        private void labelidkategori_Click(object sender, EventArgs e)
        {

        }

        private void labelnamabarang_Click(object sender, EventArgs e)
        {

        }

        private void tampilDataBarang()
        {
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Table_Barang";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            sda.Fill(ds, "Table_Barang");
            DatagridBarang.DataSource = ds;
            DatagridBarang.DataMember = "Table_Barang";
            sqlCon.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT  Into Table_Barang (nama_barang, id_kategori, harga_satuan, stock)" +  "VALUES ('" + textNamabarang.Text +  "' , '" + textIDKategori.Text + "' , '" + texthargasatuan.Text + "' , '" + txtstocks.Text + "')";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            tampilDataBarang();
            ClearData();
        }

       

        private void textNamabarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Table_Barang SET " +
                              "nama_barang = '" + textNamabarang.Text + "', " +
                              "id_kategori = '" + textIDKategori.Text + "', " +
                              "harga_satuan = '" + texthargasatuan.Text + "', " +
                              "stock = '" + txtstocks.Text + "' " +
                              "WHERE id_barang = '" + textidBarang.Text + "'"; // Gunakan kolom unik
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            tampilDataBarang();
            ClearData();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatagridBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Table_Barang " +
                "WHERE id_barang = '" + textidBarang.Text + "'"; // Gunakan kolom unik
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            tampilDataBarang();
            ClearData();
        }
    }
}
