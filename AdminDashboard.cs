using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormFactorSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAddNewRam_Click(object sender, EventArgs e)
        {
            AdminAddNewRam addNewRAMForm = new AdminAddNewRam();
            addNewRAMForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RAMDatabase ramdatabase = new RAMDatabase();
            DataTable ramTable = ramdatabase.GetTable();
            dgvInventory.AutoGenerateColumns = true;
            dgvInventory.DataSource = ramTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewMotherboard_Click(object sender, EventArgs e)
        {
            AdminAddNewMotherboard adminAddNewMotherboardForm = new AdminAddNewMotherboard();
            adminAddNewMotherboardForm.ShowDialog();
        }
    }
}
