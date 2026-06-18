namespace FormFactorSystem
{
    partial class AdminAddNewMotherboard
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
            groupBox1 = new GroupBox();
            txtChipset = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSocketType = new TextBox();
            groupBox2 = new GroupBox();
            groupBox6 = new GroupBox();
            rbDIMM = new RadioButton();
            rbSODIMM = new RadioButton();
            txtSpeed = new TextBox();
            numCapacity = new NumericUpDown();
            rbDDR2 = new RadioButton();
            label5 = new Label();
            rbDDR5 = new RadioButton();
            rbDDR3 = new RadioButton();
            rbDDR4 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            chkSATA = new CheckBox();
            chkM2SATA = new CheckBox();
            chkM2NVME = new CheckBox();
            groupBox5 = new GroupBox();
            rbMINIITX = new RadioButton();
            rbATX = new RadioButton();
            rbMicroATX = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChipset);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSocketType);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CPU";
            // 
            // txtChipset
            // 
            txtChipset.Location = new Point(6, 81);
            txtChipset.Name = "txtChipset";
            txtChipset.Size = new Size(100, 23);
            txtChipset.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "Chipset";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Socket Type";
            // 
            // txtSocketType
            // 
            txtSocketType.Location = new Point(6, 37);
            txtSocketType.Name = "txtSocketType";
            txtSocketType.Size = new Size(100, 23);
            txtSocketType.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(txtSpeed);
            groupBox2.Controls.Add(numCapacity);
            groupBox2.Controls.Add(rbDDR2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(rbDDR5);
            groupBox2.Controls.Add(rbDDR3);
            groupBox2.Controls.Add(rbDDR4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 300);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "RAM";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rbDIMM);
            groupBox6.Controls.Add(rbSODIMM);
            groupBox6.Location = new Point(6, 174);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(157, 100);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Form Factor";
            // 
            // rbDIMM
            // 
            rbDIMM.AutoSize = true;
            rbDIMM.Location = new Point(6, 22);
            rbDIMM.Name = "rbDIMM";
            rbDIMM.Size = new Size(58, 19);
            rbDIMM.TabIndex = 8;
            rbDIMM.TabStop = true;
            rbDIMM.Text = "DIMM";
            rbDIMM.UseVisualStyleBackColor = true;
            // 
            // rbSODIMM
            // 
            rbSODIMM.AutoSize = true;
            rbSODIMM.Location = new Point(6, 47);
            rbSODIMM.Name = "rbSODIMM";
            rbSODIMM.Size = new Size(78, 19);
            rbSODIMM.TabIndex = 9;
            rbSODIMM.TabStop = true;
            rbSODIMM.Text = "SO-DIMM";
            rbSODIMM.UseVisualStyleBackColor = true;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(6, 145);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(100, 23);
            txtSpeed.TabIndex = 5;
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(6, 101);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(120, 23);
            numCapacity.TabIndex = 7;
            // 
            // rbDDR2
            // 
            rbDDR2.AutoSize = true;
            rbDDR2.Location = new Point(100, 62);
            rbDDR2.Name = "rbDDR2";
            rbDDR2.Size = new Size(54, 19);
            rbDDR2.TabIndex = 6;
            rbDDR2.TabStop = true;
            rbDDR2.Text = "DDR2";
            rbDDR2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 127);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 2;
            label5.Text = "Speed";
            // 
            // rbDDR5
            // 
            rbDDR5.AutoSize = true;
            rbDDR5.Location = new Point(6, 37);
            rbDDR5.Name = "rbDDR5";
            rbDDR5.Size = new Size(54, 19);
            rbDDR5.TabIndex = 5;
            rbDDR5.TabStop = true;
            rbDDR5.Text = "DDR5";
            rbDDR5.UseVisualStyleBackColor = true;
            // 
            // rbDDR3
            // 
            rbDDR3.AutoSize = true;
            rbDDR3.Location = new Point(100, 37);
            rbDDR3.Name = "rbDDR3";
            rbDDR3.Size = new Size(54, 19);
            rbDDR3.TabIndex = 4;
            rbDDR3.TabStop = true;
            rbDDR3.Text = "DDR3";
            rbDDR3.UseVisualStyleBackColor = true;
            // 
            // rbDDR4
            // 
            rbDDR4.AutoSize = true;
            rbDDR4.Location = new Point(6, 61);
            rbDDR4.Name = "rbDDR4";
            rbDDR4.Size = new Size(54, 19);
            rbDDR4.TabIndex = 3;
            rbDDR4.TabStop = true;
            rbDDR4.Text = "DDR4";
            rbDDR4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 1;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 0;
            label3.Text = "Generation";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkSATA);
            groupBox3.Controls.Add(chkM2SATA);
            groupBox3.Controls.Add(chkM2NVME);
            groupBox3.Location = new Point(224, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Drives";
            // 
            // chkSATA
            // 
            chkSATA.AutoSize = true;
            chkSATA.Location = new Point(6, 62);
            chkSATA.Name = "chkSATA";
            chkSATA.Size = new Size(53, 19);
            chkSATA.TabIndex = 2;
            chkSATA.Text = "SATA";
            chkSATA.UseVisualStyleBackColor = true;
            // 
            // chkM2SATA
            // 
            chkM2SATA.AutoSize = true;
            chkM2SATA.Location = new Point(6, 39);
            chkM2SATA.Name = "chkM2SATA";
            chkM2SATA.Size = new Size(76, 19);
            chkM2SATA.TabIndex = 1;
            chkM2SATA.Text = "M.2 SATA";
            chkM2SATA.UseVisualStyleBackColor = true;
            // 
            // chkM2NVME
            // 
            chkM2NVME.AutoSize = true;
            chkM2NVME.Location = new Point(6, 18);
            chkM2NVME.Name = "chkM2NVME";
            chkM2NVME.Size = new Size(82, 19);
            chkM2NVME.TabIndex = 0;
            chkM2NVME.Text = "M.2 NVME";
            chkM2NVME.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbMINIITX);
            groupBox5.Controls.Add(rbATX);
            groupBox5.Controls.Add(rbMicroATX);
            groupBox5.Location = new Point(224, 119);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 100);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Form Factor";
            // 
            // rbMINIITX
            // 
            rbMINIITX.AutoSize = true;
            rbMINIITX.Location = new Point(6, 22);
            rbMINIITX.Name = "rbMINIITX";
            rbMINIITX.Size = new Size(71, 19);
            rbMINIITX.TabIndex = 8;
            rbMINIITX.TabStop = true;
            rbMINIITX.Text = "Mini-ITX";
            rbMINIITX.UseVisualStyleBackColor = true;
            // 
            // rbATX
            // 
            rbATX.AutoSize = true;
            rbATX.Location = new Point(6, 47);
            rbATX.Name = "rbATX";
            rbATX.Size = new Size(46, 19);
            rbATX.TabIndex = 10;
            rbATX.TabStop = true;
            rbATX.Text = "ATX";
            rbATX.UseVisualStyleBackColor = true;
            // 
            // rbMicroATX
            // 
            rbMicroATX.AutoSize = true;
            rbMicroATX.Location = new Point(83, 22);
            rbMicroATX.Name = "rbMicroATX";
            rbMicroATX.Size = new Size(82, 19);
            rbMicroATX.TabIndex = 9;
            rbMicroATX.TabStop = true;
            rbMicroATX.Text = "Micro-ATX";
            rbMicroATX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(356, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(275, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdminAddNewMotherboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminAddNewMotherboard";
            Text = "FormFactor - Add New Motherboard";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtChipset;
        private Label label2;
        private Label label1;
        private TextBox txtSocketType;
        private Label label4;
        private Label label3;
        private GroupBox groupBox5;
        private Label label5;
        private RadioButton rbDDR5;
        private RadioButton rbDDR3;
        private RadioButton rbDDR4;
        private RadioButton radioButton8;
        private RadioButton rbATX;
        private RadioButton rbMicroATX;
        private RadioButton rbMINIITX;
        private NumericUpDown numCapacity;
        private RadioButton rbDDR2;
        private RadioButton rbSODIMM;
        private RadioButton rbDIMM;
        private TextBox txtSpeed;
        private GroupBox groupBox6;
        private CheckBox chkSATA;
        private CheckBox chkM2SATA;
        private CheckBox chkM2NVME;
        private Button button1;
        private Button button2;
    }
}