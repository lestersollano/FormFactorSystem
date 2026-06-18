using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Data.Sqlite;

namespace FormFactorSystem
{
    public partial class AdminAddNewRam : Form
    {
        public AdminAddNewRam()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtGhz.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                IncompleteFormAlert();
                return;
            }
            string name = txtName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int capacity;
            if (rb1.Checked) capacity = 1;
            else if (rb2.Checked) capacity = 2;
            else if (rb4.Checked) capacity = 4;
            else if (rb8.Checked) capacity = 8;
            else if (rb16.Checked) capacity = 16;
            else if (rb32.Checked) capacity = 32;
            else if (rb64.Checked) capacity = 64;
            else if (rb128.Checked) capacity = 128;
            else
            {
                IncompleteFormAlert();
                return;
            }
            int ghz = Convert.ToInt32(txtGhz.Text);
            string version;
            if (rbDDR2.Checked) version = "DDR2";
            else if (rbDDR3.Checked) version = "DDR3";
            else if (rbDDR4.Checked) version = "DDR4";
            else if (rbDDR5.Checked) version = "DDR5";
            else
            {
                IncompleteFormAlert();
                return;
            }
            int quantity = Convert.ToInt32(numQuantity.Value);

            RAMDatabase database = new RAMDatabase();
            database.Add(name, capacity, ghz, version, quantity, price);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RAMDatabase database = new RAMDatabase();
            this.Close();
        }

        private void IncompleteFormAlert()
        {
            MessageBox.Show("Please fill in all fields before saving.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
