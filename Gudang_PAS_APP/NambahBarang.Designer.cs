namespace Gudang_PAS_APP
{
    partial class NambahBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnamabarang = new System.Windows.Forms.Label();
            this.labelidkategori = new System.Windows.Forms.Label();
            this.labelhargasatuan = new System.Windows.Forms.Label();
            this.labelstock = new System.Windows.Forms.Label();
            this.tableBarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shedDataSet2 = new Gudang_PAS_APP.shedDataSet2();
            this.tableBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shedDataSet1 = new Gudang_PAS_APP.shedDataSet1();
            this.table_BarangTableAdapter = new Gudang_PAS_APP.shedDataSet1TableAdapters.Table_BarangTableAdapter();
            this.textNamabarang = new System.Windows.Forms.TextBox();
            this.texthargasatuan = new System.Windows.Forms.TextBox();
            this.txtstocks = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.table_BarangTableAdapter1 = new Gudang_PAS_APP.shedDataSet2TableAdapters.Table_BarangTableAdapter();
            this.dataSetBarang1 = new Gudang_PAS_APP.DataSetBarang();
            this.DatagridBarang = new System.Windows.Forms.DataGridView();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textidBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIDKategori = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableBarangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shedDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shedDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBarang1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAMBAH BARANG";
            // 
            // labelnamabarang
            // 
            this.labelnamabarang.AutoSize = true;
            this.labelnamabarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnamabarang.Location = new System.Drawing.Point(57, 132);
            this.labelnamabarang.Name = "labelnamabarang";
            this.labelnamabarang.Size = new System.Drawing.Size(132, 25);
            this.labelnamabarang.TabIndex = 1;
            this.labelnamabarang.Text = "Nama Barang";
            this.labelnamabarang.Click += new System.EventHandler(this.labelnamabarang_Click);
            // 
            // labelidkategori
            // 
            this.labelidkategori.AutoSize = true;
            this.labelidkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidkategori.Location = new System.Drawing.Point(57, 177);
            this.labelidkategori.Name = "labelidkategori";
            this.labelidkategori.Size = new System.Drawing.Size(109, 25);
            this.labelidkategori.TabIndex = 2;
            this.labelidkategori.Text = "ID Kategori";
            this.labelidkategori.Click += new System.EventHandler(this.labelidkategori_Click);
            // 
            // labelhargasatuan
            // 
            this.labelhargasatuan.AutoSize = true;
            this.labelhargasatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhargasatuan.Location = new System.Drawing.Point(57, 221);
            this.labelhargasatuan.Name = "labelhargasatuan";
            this.labelhargasatuan.Size = new System.Drawing.Size(133, 25);
            this.labelhargasatuan.TabIndex = 3;
            this.labelhargasatuan.Text = "Harga Satuan";
            this.labelhargasatuan.Click += new System.EventHandler(this.labelhargasatuan_Click);
            // 
            // labelstock
            // 
            this.labelstock.AutoSize = true;
            this.labelstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstock.Location = new System.Drawing.Point(57, 260);
            this.labelstock.Name = "labelstock";
            this.labelstock.Size = new System.Drawing.Size(62, 25);
            this.labelstock.TabIndex = 4;
            this.labelstock.Text = "Stock";
            this.labelstock.Click += new System.EventHandler(this.labelsatuan_Click);
            // 
            // tableBarangBindingSource1
            // 
            this.tableBarangBindingSource1.DataMember = "Table_Barang";
            this.tableBarangBindingSource1.DataSource = this.shedDataSet2;
            // 
            // shedDataSet2
            // 
            this.shedDataSet2.DataSetName = "shedDataSet2";
            this.shedDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBarangBindingSource
            // 
            this.tableBarangBindingSource.DataMember = "Table_Barang";
            this.tableBarangBindingSource.DataSource = this.shedDataSet1;
            // 
            // shedDataSet1
            // 
            this.shedDataSet1.DataSetName = "shedDataSet1";
            this.shedDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_BarangTableAdapter
            // 
            this.table_BarangTableAdapter.ClearBeforeFill = true;
            // 
            // textNamabarang
            // 
            this.textNamabarang.Location = new System.Drawing.Point(227, 136);
            this.textNamabarang.Name = "textNamabarang";
            this.textNamabarang.Size = new System.Drawing.Size(308, 22);
            this.textNamabarang.TabIndex = 6;
            this.textNamabarang.TextChanged += new System.EventHandler(this.textNamabarang_TextChanged);
            // 
            // texthargasatuan
            // 
            this.texthargasatuan.Location = new System.Drawing.Point(227, 221);
            this.texthargasatuan.Name = "texthargasatuan";
            this.texthargasatuan.Size = new System.Drawing.Size(308, 22);
            this.texthargasatuan.TabIndex = 8;
            // 
            // txtstocks
            // 
            this.txtstocks.Location = new System.Drawing.Point(227, 263);
            this.txtstocks.Name = "txtstocks";
            this.txtstocks.Size = new System.Drawing.Size(308, 22);
            this.txtstocks.TabIndex = 9;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(573, 134);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(109, 23);
            this.buttonTambah.TabIndex = 10;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(573, 180);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(109, 23);
            this.buttonUbah.TabIndex = 11;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(573, 220);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(109, 23);
            this.buttonHapus.TabIndex = 12;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(573, 261);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(109, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // table_BarangTableAdapter1
            // 
            this.table_BarangTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetBarang1
            // 
            this.dataSetBarang1.DataSetName = "DataSetBarang";
            this.dataSetBarang1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatagridBarang
            // 
            this.DatagridBarang.AllowUserToAddRows = false;
            this.DatagridBarang.AllowUserToDeleteRows = false;
            this.DatagridBarang.AutoGenerateColumns = false;
            this.DatagridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.idkategoriDataGridViewTextBoxColumn,
            this.hargasatuanDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.DatagridBarang.DataSource = this.tableBarangBindingSource1;
            this.DatagridBarang.Location = new System.Drawing.Point(62, 310);
            this.DatagridBarang.MultiSelect = false;
            this.DatagridBarang.Name = "DatagridBarang";
            this.DatagridBarang.ReadOnly = true;
            this.DatagridBarang.RowHeadersWidth = 51;
            this.DatagridBarang.RowTemplate.Height = 24;
            this.DatagridBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridBarang.Size = new System.Drawing.Size(674, 363);
            this.DatagridBarang.TabIndex = 14;
            this.DatagridBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridBarang_CellContentClick);
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.namabarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // idkategoriDataGridViewTextBoxColumn
            // 
            this.idkategoriDataGridViewTextBoxColumn.DataPropertyName = "id_kategori";
            this.idkategoriDataGridViewTextBoxColumn.HeaderText = "id_kategori";
            this.idkategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkategoriDataGridViewTextBoxColumn.Name = "idkategoriDataGridViewTextBoxColumn";
            this.idkategoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkategoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargasatuanDataGridViewTextBoxColumn
            // 
            this.hargasatuanDataGridViewTextBoxColumn.DataPropertyName = "harga_satuan";
            this.hargasatuanDataGridViewTextBoxColumn.HeaderText = "harga_satuan";
            this.hargasatuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargasatuanDataGridViewTextBoxColumn.Name = "hargasatuanDataGridViewTextBoxColumn";
            this.hargasatuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargasatuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textidBarang
            // 
            this.textidBarang.Location = new System.Drawing.Point(227, 95);
            this.textidBarang.Name = "textidBarang";
            this.textidBarang.Size = new System.Drawing.Size(308, 22);
            this.textidBarang.TabIndex = 16;
            this.textidBarang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textIDKategori
            // 
            this.textIDKategori.Location = new System.Drawing.Point(227, 177);
            this.textIDKategori.Name = "textIDKategori";
            this.textIDKategori.Size = new System.Drawing.Size(308, 22);
            this.textIDKategori.TabIndex = 18;
            // 
            // NambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.textIDKategori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textidBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatagridBarang);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.txtstocks);
            this.Controls.Add(this.texthargasatuan);
            this.Controls.Add(this.textNamabarang);
            this.Controls.Add(this.labelstock);
            this.Controls.Add(this.labelhargasatuan);
            this.Controls.Add(this.labelidkategori);
            this.Controls.Add(this.labelnamabarang);
            this.Controls.Add(this.label1);
            this.Name = "NambahBarang";
            this.Text = "NambahBarang";
            this.Load += new System.EventHandler(this.NambahBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBarangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shedDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shedDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBarang1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnamabarang;
        private System.Windows.Forms.Label labelidkategori;
        private System.Windows.Forms.Label labelhargasatuan;
        private System.Windows.Forms.Label labelstock;
        private shedDataSet1 shedDataSet1;
        private System.Windows.Forms.BindingSource tableBarangBindingSource;
        private shedDataSet1TableAdapters.Table_BarangTableAdapter table_BarangTableAdapter;
        private System.Windows.Forms.TextBox textNamabarang;
        private System.Windows.Forms.TextBox texthargasatuan;
        private System.Windows.Forms.TextBox txtstocks;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonClear;
        private shedDataSet2 shedDataSet2;
        private System.Windows.Forms.BindingSource tableBarangBindingSource1;
        private shedDataSet2TableAdapters.Table_BarangTableAdapter table_BarangTableAdapter1;
        private DataSetBarang dataSetBarang1;
        private System.Windows.Forms.DataGridView DatagridBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textidBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIDKategori;
    }
}