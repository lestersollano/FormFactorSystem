using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormFactorSystem
{
    public partial class FormFactorAdminDashboard : Form
    {
        public FormFactorAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAddNewRam_Click(object sender, EventArgs e)
        {
            FormFactorAdminAddNewRAM addNewRAMForm = new FormFactorAdminAddNewRAM();
            addNewRAMForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RAMDatabase ramdatabase = new RAMDatabase();
            DataTable ramTable = ramdatabase.GetTable();
            dgvInventory.AutoGenerateColumns = true;
            dgvInventory.DataSource = ramTable;
        }
    }
}
