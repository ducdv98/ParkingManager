namespace ParkingManager.GUI.Parking
{
    partial class PnlGetOut
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
            this.pnIn = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbLicensePlate = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExtendTerm = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBlock = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTicketIdInput = new System.Windows.Forms.TextBox();
            this.pnIn.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnIn
            // 
            this.pnIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnIn.Controls.Add(this.btnSubmit);
            this.pnIn.Controls.Add(this.panel6);
            this.pnIn.Controls.Add(this.groupBox9);
            this.pnIn.Controls.Add(this.panel5);
            this.pnIn.Controls.Add(this.panel2);
            this.pnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnIn.Location = new System.Drawing.Point(0, 0);
            this.pnIn.Name = "pnIn";
            this.pnIn.Size = new System.Drawing.Size(771, 429);
            this.pnIn.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(623, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 53);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "XUẤT BẾN";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox6);
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(0, 191);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(771, 123);
            this.panel6.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbArea);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(454, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 38);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Khu vực gửi";
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
            this.cbArea.Location = new System.Drawing.Point(3, 14);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(260, 21);
            this.cbArea.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbType);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(46, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 38);
            this.groupBox5.TabIndex = 0;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbLicensePlate);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(46, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 38);
            this.groupBox4.TabIndex = 0;
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbFee);
            this.groupBox9.Enabled = false;
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox9.Location = new System.Drawing.Point(49, 335);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(371, 68);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Phí";
            // 
            // tbFee
            // 
            this.tbFee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFee.Location = new System.Drawing.Point(3, 21);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(365, 44);
            this.tbFee.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExtendTerm);
            this.panel5.Controls.Add(this.groupBox10);
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(771, 134);
            this.panel5.TabIndex = 2;
            // 
            // btnExtendTerm
            // 
            this.btnExtendTerm.Location = new System.Drawing.Point(662, 83);
            this.btnExtendTerm.Name = "btnExtendTerm";
            this.btnExtendTerm.Size = new System.Drawing.Size(75, 23);
            this.btnExtendTerm.TabIndex = 2;
            this.btnExtendTerm.Text = "Gia hạn";
            this.btnExtendTerm.UseVisualStyleBackColor = true;
            this.btnExtendTerm.Click += new System.EventHandler(this.btnExtendTerm_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbStatus);
            this.groupBox10.Enabled = false;
            this.groupBox10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox10.Location = new System.Drawing.Point(454, 71);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(192, 38);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Trạng thái";
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Hoạt động",
            "Hết hạn"});
            this.cbStatus.Location = new System.Drawing.Point(3, 14);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(186, 21);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBlock);
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(454, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 38);
            this.groupBox3.TabIndex = 0;
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
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(49, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 38);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Họ và tên";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCustomerName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCustomerName.Location = new System.Drawing.Point(3, 15);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(306, 20);
            this.tbCustomerName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 57);
            this.panel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(645, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTicketIdInput);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(49, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập mã vé xe";
            // 
            // tbTicketIdInput
            // 
            this.tbTicketIdInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTicketIdInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTicketIdInput.Location = new System.Drawing.Point(3, 20);
            this.tbTicketIdInput.Name = "tbTicketIdInput";
            this.tbTicketIdInput.Size = new System.Drawing.Size(248, 21);
            this.tbTicketIdInput.TabIndex = 0;
            this.tbTicketIdInput.TextChanged += new System.EventHandler(this.tbTicketIdInput_TextChanged);
            this.tbTicketIdInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTicketIdInput_KeyDown);
            // 
            // PnlOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 429);
            this.ControlBox = false;
            this.Controls.Add(this.pnIn);
            this.Name = "PnlOut";
            this.Text = "PnlOut";
            this.pnIn.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnIn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBlock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbLicensePlate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTicketIdInput;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExtendTerm;
    }
}