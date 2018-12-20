namespace ParkingManager.GUI.Setting
{
    partial class FrmSetting
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
            this.gbTurn = new System.Windows.Forms.GroupBox();
            this.gbTerm = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBike = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbEbike = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbMotorBike = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbTriCycle = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbBikeT = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbMotorBikeT = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbTriCycleT = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tbEbikeT = new System.Windows.Forms.TextBox();
            this.btnAllowEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbTurn.SuspendLayout();
            this.gbTerm.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTurn
            // 
            this.gbTurn.Controls.Add(this.groupBox4);
            this.gbTurn.Controls.Add(this.groupBox6);
            this.gbTurn.Controls.Add(this.groupBox5);
            this.gbTurn.Controls.Add(this.groupBox3);
            this.gbTurn.ForeColor = System.Drawing.SystemColors.Control;
            this.gbTurn.Location = new System.Drawing.Point(39, 39);
            this.gbTurn.Name = "gbTurn";
            this.gbTurn.Size = new System.Drawing.Size(876, 179);
            this.gbTurn.TabIndex = 0;
            this.gbTurn.TabStop = false;
            this.gbTurn.Text = "Giá Vé lượt";
            // 
            // gbTerm
            // 
            this.gbTerm.Controls.Add(this.groupBox10);
            this.gbTerm.Controls.Add(this.groupBox7);
            this.gbTerm.Controls.Add(this.groupBox9);
            this.gbTerm.Controls.Add(this.groupBox8);
            this.gbTerm.ForeColor = System.Drawing.SystemColors.Control;
            this.gbTerm.Location = new System.Drawing.Point(39, 263);
            this.gbTerm.Name = "gbTerm";
            this.gbTerm.Size = new System.Drawing.Size(876, 179);
            this.gbTerm.TabIndex = 0;
            this.gbTerm.TabStop = false;
            this.gbTerm.Text = "Giá Vé tháng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBike);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(66, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 45);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xe đạp";
            // 
            // tbBike
            // 
            this.tbBike.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBike.Enabled = false;
            this.tbBike.Location = new System.Drawing.Point(3, 22);
            this.tbBike.Name = "tbBike";
            this.tbBike.Size = new System.Drawing.Size(266, 20);
            this.tbBike.TabIndex = 0;
            this.tbBike.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbEbike);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(457, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 45);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xe đạp điện/Xe máy điện";
            // 
            // tbEbike
            // 
            this.tbEbike.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbEbike.Enabled = false;
            this.tbEbike.Location = new System.Drawing.Point(3, 22);
            this.tbEbike.Name = "tbEbike";
            this.tbEbike.Size = new System.Drawing.Size(266, 20);
            this.tbEbike.TabIndex = 0;
            this.tbEbike.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbMotorBike);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(66, 110);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 45);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Xe máy";
            // 
            // tbMotorBike
            // 
            this.tbMotorBike.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMotorBike.Enabled = false;
            this.tbMotorBike.Location = new System.Drawing.Point(3, 22);
            this.tbMotorBike.Name = "tbMotorBike";
            this.tbMotorBike.Size = new System.Drawing.Size(266, 20);
            this.tbMotorBike.TabIndex = 0;
            this.tbMotorBike.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbTriCycle);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(457, 110);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 45);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Xe ba bánh";
            // 
            // tbTriCycle
            // 
            this.tbTriCycle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTriCycle.Enabled = false;
            this.tbTriCycle.Location = new System.Drawing.Point(3, 22);
            this.tbTriCycle.Name = "tbTriCycle";
            this.tbTriCycle.Size = new System.Drawing.Size(266, 20);
            this.tbTriCycle.TabIndex = 0;
            this.tbTriCycle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbBikeT);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Location = new System.Drawing.Point(66, 39);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(272, 45);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Xe đạp";
            // 
            // tbBikeT
            // 
            this.tbBikeT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBikeT.Enabled = false;
            this.tbBikeT.Location = new System.Drawing.Point(3, 22);
            this.tbBikeT.Name = "tbBikeT";
            this.tbBikeT.Size = new System.Drawing.Size(266, 20);
            this.tbBikeT.TabIndex = 0;
            this.tbBikeT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbMotorBikeT);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Location = new System.Drawing.Point(66, 120);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(272, 45);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Xe máy";
            // 
            // tbMotorBikeT
            // 
            this.tbMotorBikeT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMotorBikeT.Enabled = false;
            this.tbMotorBikeT.Location = new System.Drawing.Point(3, 22);
            this.tbMotorBikeT.Name = "tbMotorBikeT";
            this.tbMotorBikeT.Size = new System.Drawing.Size(266, 20);
            this.tbMotorBikeT.TabIndex = 0;
            this.tbMotorBikeT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbTriCycleT);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox9.Location = new System.Drawing.Point(457, 120);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(272, 45);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Xe ba bánh";
            // 
            // tbTriCycleT
            // 
            this.tbTriCycleT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTriCycleT.Enabled = false;
            this.tbTriCycleT.Location = new System.Drawing.Point(3, 22);
            this.tbTriCycleT.Name = "tbTriCycleT";
            this.tbTriCycleT.Size = new System.Drawing.Size(266, 20);
            this.tbTriCycleT.TabIndex = 0;
            this.tbTriCycleT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tbEbikeT);
            this.groupBox10.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox10.Location = new System.Drawing.Point(457, 39);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(272, 45);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Xe đạp điện/Xe máy điện";
            // 
            // tbEbikeT
            // 
            this.tbEbikeT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbEbikeT.Enabled = false;
            this.tbEbikeT.Location = new System.Drawing.Point(3, 22);
            this.tbEbikeT.Name = "tbEbikeT";
            this.tbEbikeT.Size = new System.Drawing.Size(266, 20);
            this.tbEbikeT.TabIndex = 0;
            this.tbEbikeT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBike_KeyPress);
            // 
            // btnAllowEdit
            // 
            this.btnAllowEdit.Location = new System.Drawing.Point(54, 10);
            this.btnAllowEdit.Name = "btnAllowEdit";
            this.btnAllowEdit.Size = new System.Drawing.Size(75, 23);
            this.btnAllowEdit.TabIndex = 1;
            this.btnAllowEdit.Text = "Sửa";
            this.btnAllowEdit.UseVisualStyleBackColor = true;
            this.btnAllowEdit.Click += new System.EventHandler(this.btnAllowEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(135, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(987, 468);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAllowEdit);
            this.Controls.Add(this.gbTerm);
            this.Controls.Add(this.gbTurn);
            this.Name = "FrmSetting";
            this.Text = "FrmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.gbTurn.ResumeLayout(false);
            this.gbTerm.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTurn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbEbike;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbTriCycle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbMotorBike;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBike;
        private System.Windows.Forms.GroupBox gbTerm;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox tbEbikeT;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbBikeT;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbTriCycleT;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbMotorBikeT;
        private System.Windows.Forms.Button btnAllowEdit;
        private System.Windows.Forms.Button btnSave;
    }
}