
namespace Disconnected_Environment
{
    partial class FormDataMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataMahasiswa));
            this.bnMahasiswa = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.cbxJenisKelamin = new System.Windows.Forms.ComboBox();
            this.cbxProdi = new System.Windows.Forms.ComboBox();
            this.dtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.kampusDataSet1 = new Disconnected_Environment.KampusDataSet1();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Disconnected_Environment.KampusDataSet1TableAdapters.MahasiswaTableAdapter();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnMahasiswa)).BeginInit();
            this.bnMahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kampusDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // bnMahasiswa
            // 
            this.bnMahasiswa.AddNewItem = this.bindingNavigatorDeleteItem;
            this.bnMahasiswa.CountItem = this.bindingNavigatorCountItem;
            this.bnMahasiswa.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnMahasiswa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnMahasiswa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnMahasiswa.Location = new System.Drawing.Point(0, 0);
            this.bnMahasiswa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMahasiswa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMahasiswa.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMahasiswa.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMahasiswa.Name = "bnMahasiswa";
            this.bnMahasiswa.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMahasiswa.Size = new System.Drawing.Size(800, 27);
            this.bnMahasiswa.TabIndex = 0;
            this.bnMahasiswa.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prodi";
            // 
            // txtNIM
            // 
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "nim", true));
            this.txtNIM.Location = new System.Drawing.Point(340, 73);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(223, 22);
            this.txtNIM.TabIndex = 7;
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "nama_mahasiswa", true));
            this.txtNama.Location = new System.Drawing.Point(340, 115);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(223, 22);
            this.txtNama.TabIndex = 8;
            // 
            // txtAlamat
            // 
            this.txtAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource3, "alamat", true));
            this.txtAlamat.Location = new System.Drawing.Point(340, 198);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(223, 22);
            this.txtAlamat.TabIndex = 9;
            // 
            // cbxJenisKelamin
            // 
            this.cbxJenisKelamin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource2, "jenis_kelamin", true));
            this.cbxJenisKelamin.FormattingEnabled = true;
            this.cbxJenisKelamin.Location = new System.Drawing.Point(340, 157);
            this.cbxJenisKelamin.Name = "cbxJenisKelamin";
            this.cbxJenisKelamin.Size = new System.Drawing.Size(223, 24);
            this.cbxJenisKelamin.TabIndex = 10;
            // 
            // cbxProdi
            // 
            this.cbxProdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource5, "id_prodi", true));
            this.cbxProdi.FormattingEnabled = true;
            this.cbxProdi.Location = new System.Drawing.Point(340, 280);
            this.cbxProdi.Name = "cbxProdi";
            this.cbxProdi.Size = new System.Drawing.Size(223, 24);
            this.cbxProdi.TabIndex = 11;
            // 
            // dtTanggalLahir
            // 
            this.dtTanggalLahir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource4, "tgl_lahir", true));
            this.dtTanggalLahir.Location = new System.Drawing.Point(340, 238);
            this.dtTanggalLahir.Name = "dtTanggalLahir";
            this.dtTanggalLahir.Size = new System.Drawing.Size(223, 22);
            this.dtTanggalLahir.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(355, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(488, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // kampusDataSet1
            // 
            this.kampusDataSet1.DataSetName = "KampusDataSet1";
            this.kampusDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.kampusDataSet1;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.kampusDataSet1;
            // 
            // mahasiswaBindingSource2
            // 
            this.mahasiswaBindingSource2.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource2.DataSource = this.kampusDataSet1;
            // 
            // mahasiswaBindingSource3
            // 
            this.mahasiswaBindingSource3.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource3.DataSource = this.kampusDataSet1;
            // 
            // mahasiswaBindingSource4
            // 
            this.mahasiswaBindingSource4.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource4.DataSource = this.kampusDataSet1;
            // 
            // mahasiswaBindingSource5
            // 
            this.mahasiswaBindingSource5.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource5.DataSource = this.kampusDataSet1;
            // 
            // FormDataMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtTanggalLahir);
            this.Controls.Add(this.cbxProdi);
            this.Controls.Add(this.cbxJenisKelamin);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnMahasiswa);
            this.Name = "FormDataMahasiswa";
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.FormDataMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnMahasiswa)).EndInit();
            this.bnMahasiswa.ResumeLayout(false);
            this.bnMahasiswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kampusDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnMahasiswa;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.ComboBox cbxJenisKelamin;
        private System.Windows.Forms.ComboBox cbxProdi;
        private System.Windows.Forms.DateTimePicker dtTanggalLahir;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private KampusDataSet1 kampusDataSet1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private KampusDataSet1TableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource3;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource2;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource4;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource5;
    }
}