﻿namespace Programma
{
    partial class ProvForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdition = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProv = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
<<<<<<< HEAD
            this.provisionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinBDDataSet = new Programma.magazinBDDataSet();
=======
            this.magazinBDDataSet = new Programma.magazinBDDataSet();
            this.provisionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
            this.magazinBDDataSet = new Programma.magazinBDDataSet();
            this.provisionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            this.provisionerTableAdapter = new Programma.magazinBDDataSetTableAdapters.ProvisionerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).BeginInit();
<<<<<<< HEAD
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBDDataSet)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.magazinBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).BeginInit();
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
            ((System.ComponentModel.ISupportInitialize)(this.magazinBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).BeginInit();
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(262, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdition
            // 
            this.btnEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdition.Location = new System.Drawing.Point(137, 12);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(119, 31);
            this.btnEdition.TabIndex = 7;
            this.btnEdition.Text = "Редактировать";
            this.btnEdition.UseVisualStyleBackColor = true;
            this.btnEdition.Click += new System.EventHandler(this.btnEdition_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProv
            // 
            this.dgvProv.AllowUserToAddRows = false;
            this.dgvProv.AllowUserToDeleteRows = false;
            this.dgvProv.AutoGenerateColumns = false;
            this.dgvProv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.agentDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvProv.DataSource = this.provisionerBindingSource;
            this.dgvProv.Location = new System.Drawing.Point(12, 49);
            this.dgvProv.Name = "dgvProv";
            this.dgvProv.ReadOnly = true;
            this.dgvProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProv.Size = new System.Drawing.Size(760, 501);
            this.dgvProv.TabIndex = 9;
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // provisionerBindingSource
            // 
            this.provisionerBindingSource.DataMember = "Provisioner";
            this.provisionerBindingSource.DataSource = this.magazinBDDataSet;
            // 
=======
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            // magazinBDDataSet
            // 
            this.magazinBDDataSet.DataSetName = "magazinBDDataSet";
            this.magazinBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            // provisionerBindingSource
            // 
            this.provisionerBindingSource.DataMember = "Provisioner";
            this.provisionerBindingSource.DataSource = this.magazinBDDataSet;
            // 
<<<<<<< HEAD
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            // provisionerTableAdapter
            // 
            this.provisionerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
<<<<<<< HEAD
<<<<<<< HEAD
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
=======
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
<<<<<<< HEAD
<<<<<<< HEAD
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
=======
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            // 
            // agentDataGridViewTextBoxColumn
            // 
            this.agentDataGridViewTextBoxColumn.DataPropertyName = "agent";
<<<<<<< HEAD
<<<<<<< HEAD
            this.agentDataGridViewTextBoxColumn.HeaderText = "ФИО представителя";
            this.agentDataGridViewTextBoxColumn.Name = "agentDataGridViewTextBoxColumn";
            this.agentDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentDataGridViewTextBoxColumn.Width = 150;
=======
            this.agentDataGridViewTextBoxColumn.HeaderText = "agent";
            this.agentDataGridViewTextBoxColumn.Name = "agentDataGridViewTextBoxColumn";
            this.agentDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
            this.agentDataGridViewTextBoxColumn.HeaderText = "agent";
            this.agentDataGridViewTextBoxColumn.Name = "agentDataGridViewTextBoxColumn";
            this.agentDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
<<<<<<< HEAD
<<<<<<< HEAD
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
=======
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            // 
            // ProvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvProv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdition);
            this.Controls.Add(this.btnAdd);
            this.Name = "ProvForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр поставщиков";
            this.Load += new System.EventHandler(this.ProvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).EndInit();
<<<<<<< HEAD
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBDDataSet)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.magazinBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).EndInit();
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
=======
            ((System.ComponentModel.ISupportInitialize)(this.magazinBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).EndInit();
>>>>>>> 71c4a41b082a75bedc1ab27644212efc02354df6
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProv;
        public magazinBDDataSet magazinBDDataSet;
        public System.Windows.Forms.BindingSource provisionerBindingSource;
        public magazinBDDataSetTableAdapters.ProvisionerTableAdapter provisionerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}