namespace FormFactorSystem
{
    partial class FormFactorUserSelect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnLoginAdmin = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(291, 52);
            label1.TabIndex = 0;
            label1.Text = "Admins can enter their credentials here to manage the system.";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(291, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(6, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 23);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoginAdmin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 196);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Control";
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Location = new Point(222, 162);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(75, 23);
            btnLoginAdmin.TabIndex = 5;
            btnLoginAdmin.Text = "Login";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(321, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 196);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Shopping";
            // 
            // button2
            // 
            button2.Location = new Point(187, 162);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(256, 42);
            label4.TabIndex = 6;
            label4.Text = "Users can enter the shop and start building their PC!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 8;
            label5.Text = "Email Address";
            // 
            // FormFactorUserSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 220);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormFactorUserSelect";
            Text = "FormFactor - Select User";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnLoginAdmin;
        private GroupBox groupBox2;
        private Label label4;
        private Button button2;
        private Label label5;
        private TextBox textBox1;
    }
}
