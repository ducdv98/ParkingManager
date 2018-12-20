namespace ParkingManager.GUI.Parking
{
    partial class FrmSignUp
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBlock = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbLicensePlate = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbAvailable = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnGenTicketId = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbTicketIdGen = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIdCard = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBlock);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(444, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 38);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toà";
            // 
            // tbBlock
            // 
            this.tbBlock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBlock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBlock.Location = new System.Drawing.Point(3, 15);
            this.tbBlock.Name = "tbBlock";
            this.tbBlock.Size = new System.Drawing.Size(186, 20);
            this.tbBlock.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCustomerName);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(42, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 38);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Họ và tên";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCustomerName.Location = new System.Drawing.Point(3, 15);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(306, 20);
            this.tbCustomerName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbLicensePlate);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(42, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 38);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Biển kiểm soát";
            // 
            // tbLicensePlate
            // 
            this.tbLicensePlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLicensePlate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLicensePlate.Location = new System.Drawing.Point(3, 15);
            this.tbLicensePlate.Name = "tbLicensePlate";
            this.tbLicensePlate.Size = new System.Drawing.Size(306, 20);
            this.tbLicensePlate.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbWarning);
            this.groupBox6.Controls.Add(this.lbAvailable);
            this.groupBox6.Controls.Add(this.lbTotal);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.cbArea);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(441, 171);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 98);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Khu vực gửi";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lbWarning.Location = new System.Drawing.Point(10, 55);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(168, 13);
            this.lbWarning.TabIndex = 3;
            this.lbWarning.Text = "Chú ý: Khu vực dành cho gửi lượt!";
            this.lbWarning.Visible = false;
            // 
            // lbAvailable
            // 
            this.lbAvailable.AutoSize = true;
            this.lbAvailable.Location = new System.Drawing.Point(184, 25);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(13, 13);
            this.lbAvailable.TabIndex = 2;
            this.lbAvailable.Text = "0";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(49, 24);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(13, 13);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Còn trống:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng:";
            // 
            // cbArea
            // 
            this.cbArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Khu Xe đạp - Lượt",
            "Khu Xe đạp - Tháng",
            "Khu Xe đạp điện - Lượt",
            "Khu Xe đạp điện - Tháng",
            "Khu Xe máy - Lượt",
            "Khu Xe máy - Tháng",
            "Khu Xe ba bánh - Lượt",
            "Khu Xe ba bánh - Tháng"});
            this.cbArea.Location = new System.Drawing.Point(3, 74);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(260, 21);
            this.cbArea.TabIndex = 0;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbType);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(42, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 38);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Loại xe";
            // 
            // cbType
            // 
            this.cbType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe đạp điện/Xe máy điện",
            "Xe máy",
            "Xe ba bánh"});
            this.cbType.Location = new System.Drawing.Point(3, 14);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(245, 21);
            this.cbType.TabIndex = 0;
            // 
            // btnGenTicketId
            // 
            this.btnGenTicketId.Location = new System.Drawing.Point(392, 330);
            this.btnGenTicketId.Name = "btnGenTicketId";
            this.btnGenTicketId.Size = new System.Drawing.Size(75, 38);
            this.btnGenTicketId.TabIndex = 7;
            this.btnGenTicketId.Text = "Lấy thẻ xe";
            this.btnGenTicketId.UseVisualStyleBackColor = true;
            this.btnGenTicketId.Click += new System.EventHandler(this.btnGenTicketId_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbTicketIdGen);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox9.Location = new System.Drawing.Point(42, 301);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(312, 68);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Mã vé";
            // 
            // tbTicketIdGen
            // 
            this.tbTicketIdGen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTicketIdGen.Enabled = false;
            this.tbTicketIdGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTicketIdGen.Location = new System.Drawing.Point(3, 21);
            this.tbTicketIdGen.Name = "tbTicketIdGen";
            this.tbTicketIdGen.Size = new System.Drawing.Size(306, 44);
            this.tbTicketIdGen.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(598, 338);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIdCard);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(42, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số CMND";
            // 
            // tbIdCard
            // 
            this.tbIdCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIdCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbIdCard.Location = new System.Drawing.Point(3, 15);
            this.tbIdCard.Name = "tbIdCard";
            this.tbIdCard.Size = new System.Drawing.Size(269, 20);
            this.tbIdCard.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbPhoneNum);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(441, 101);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 38);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Số điện thoại";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPhoneNum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPhoneNum.Location = new System.Drawing.Point(3, 15);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(244, 20);
            this.tbPhoneNum.TabIndex = 0;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(735, 393);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnGenTicketId);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký giữ xe tháng";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBlock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbLicensePlate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnGenTicketId;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbTicketIdGen;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIdCard;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbPhoneNum;
    }
}