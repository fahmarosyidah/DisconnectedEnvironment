﻿
namespace Disconnected_Environment
{
    partial class FormDataProdi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kampusDataSet = new Disconnected_Environment.KampusDataSet();
            this.label = new System.Windows.Forms.Label();
            this.nmp = new System.Windows.Forms.TextBox();
            this.prodiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.prodiTableAdapter = new Disconnected_Environment.KampusDataSetTableAdapters.ProdiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.prodiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kampusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodiDataGridViewTextBoxColumn,
            this.namaprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(187, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // prodiBindingSource
            // 
            this.prodiBindingSource.DataMember = "Prodi";
            this.prodiBindingSource.DataSource = this.kampusDataSet;
            // 
            // kampusDataSet
            // 
            this.kampusDataSet.DataSetName = "KampusDataSet";
            this.kampusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(210, 313);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Nama Prodi";
            // 
            // nmp
            // 
            this.nmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodiBindingSource1, "nama_prodi", true));
            this.nmp.Location = new System.Drawing.Point(309, 310);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(178, 22);
            this.nmp.TabIndex = 2;
            // 
            // prodiBindingSource1
            // 
            this.prodiBindingSource1.DataMember = "Prodi";
            this.prodiBindingSource1.DataSource = this.kampusDataSet;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(635, 49);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(309, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(412, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // prodiTableAdapter
            // 
            this.prodiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Prodi";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodiBindingSource, "id_prodi", true));
            this.txtId.Location = new System.Drawing.Point(309, 276);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(178, 22);
            this.txtId.TabIndex = 8;
            // 
            // prodiBindingSource2
            // 
            this.prodiBindingSource2.DataMember = "Prodi";
            this.prodiBindingSource2.DataSource = this.kampusDataSet;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            this.idprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaprodiDataGridViewTextBoxColumn
            // 
            this.namaprodiDataGridViewTextBoxColumn.DataPropertyName = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.HeaderText = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaprodiDataGridViewTextBoxColumn.Name = "namaprodiDataGridViewTextBoxColumn";
            this.namaprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormDataProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataProdi";
            this.Text = "Data Prodi";
            this.Load += new System.EventHandler(this.FormDataProdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kampusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private KampusDataSet kampusDataSet;
        private System.Windows.Forms.BindingSource prodiBindingSource;
        private KampusDataSetTableAdapters.ProdiTableAdapter prodiTableAdapter;
        private System.Windows.Forms.BindingSource prodiBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prodiBindingSource2;
    }
}