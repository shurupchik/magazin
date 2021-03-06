﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programma
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.dgvManager". При необходимости она может быть перемещена или удалена.
            this.dgvManagerTableAdapter.Fill(this.magazinBDDataSet.dgvManager);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdManagerForm form = new AddEdManagerForm();
            dgvManagerBindingSource.AddNew();
            form.managerBindingSource.DataSource = dgvManagerBindingSource;
            form.managerBindingSource.Position = dgvManagerBindingSource.Position;
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvManagerTableAdapter.Update(this.magazinBDDataSet.dgvManager);
                this.dgvManagerTableAdapter.Fill(this.magazinBDDataSet.dgvManager);
                dgvManager.CurrentCell = dgvManager.Rows[dgvManagerBindingSource.Count - 1].Cells[2];
            }

        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdManagerForm form = new AddEdManagerForm();
            form.managerBindingSource.DataSource = dgvManagerBindingSource;
            form.managerBindingSource.Position = dgvManagerBindingSource.Position;
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvManagerTableAdapter.Update(this.magazinBDDataSet.dgvManager);
                int index = dgvManager.CurrentRow.Index;
                this.dgvManagerTableAdapter.Fill(this.magazinBDDataSet.dgvManager);
                dgvManager.CurrentCell = dgvManager.Rows[index].Cells[2];
            }

        }
    }
}
