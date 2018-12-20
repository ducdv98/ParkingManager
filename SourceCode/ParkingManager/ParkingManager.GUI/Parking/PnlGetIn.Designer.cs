namespace ParkingManager.GUI.Parking
{
    partial class PnlGetIn
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
            this.btnGenTicketId = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnOption = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbDate = new System.Windows.Forms.TextBox();
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbTicketIdGen = new System.Windows.Forms.TextBox();
            this.pnCustomerInfo = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBlock = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExtendTerm = new System.Windows.Forms.Button();
            this.btnRegisterMember = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModeTurn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTicketIdInput = new System.Windows.Forms.TextBox();
            this.pnIn.SuspendLayout();
            this.pnOption.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.pnCustomerInfo.SuspendLayout();
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
            this.pnIn.Controls.Add(this.btnGenTicketId);
            this.pnIn.Controls.Add(this.btnSubmit);
            this.pnIn.Controls.Add(this.pnOption);
            this.pnIn.Controls.Add(this.groupBox9);
            this.pnIn.Controls.Add(this.pnCustomerInfo);
            this.pnIn.Controls.Add(this.panel2);
            this.pnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnIn.Location = new System.Drawing.Point(0, 0);
            this.pnIn.Name = "pnIn";
            this.pnIn.Size = new System.Drawing.Size(771, 429);
            this.pnIn.TabIndex = 1;
            // 
            // btnGenTicketId
            // 
            this.btnGenTicketId.Enabled = false;
            this.btnGenTicketId.Location = new System.Drawing.Point(379, 370);
            this.btnGenTicketId.Name = "btnGenTicketId";
            this.btnGenTicketId.Size = new System.Drawing.Size(75, 38);
            this.btnGenTicketId.TabIndex = 5;
            this.btnGenTicketId.Text = "Lấy thẻ xe";
            this.btnGenTicketId.UseVisualStyleBackColor = true;
            this.btnGenTicketId.Click += new System.EventHandler(this.btnGenTicketId_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(659, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 53);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "VÀO BẾN";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnOption
            // 
            this.pnOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnOption.Controls.Add(this.groupBox8);
            this.pnOption.Controls.Add(this.groupBox7);
            this.pnOption.Controls.Add(this.groupBox4);
            this.pnOption.Controls.Add(this.groupBox6);
            this.pnOption.Controls.Add(this.groupBox5);
            this.pnOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnOption.Enabled = false;
            this.pnOption.Location = new System.Drawing.Point(0, 166);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(771, 163);
            this.pnOption.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbTime);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox8.Location = new System.Drawing.Point(273, 103);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(145, 38);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Giờ";
            // 
            // tbTime
            // 
            this.tbTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTime.Enabled = false;
            this.tbTime.Location = new System.Drawing.Point(3, 15);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(139, 20);
            this.tbTime.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbDate);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(49, 103);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(198, 38);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ngày";
            // 
            // tbDate
            // 
            this.tbDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbDate.Enabled = false;
            this.tbDate.Location = new System.Drawing.Point(3, 15);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(192, 20);
            this.tbDate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbLicensePlate);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(49, 6);
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
            this.tbLicensePlate.Enabled = false;
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
            this.groupBox6.Location = new System.Drawing.Point(468, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 98);
            this.groupBox6.TabIndex = 0;
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
            this.lbWarning.Size = new System.Drawing.Size(178, 13);
            this.lbWarning.TabIndex = 3;
            this.lbWarning.Text = "Chú ý: Khu vực dành cho gửi tháng!";
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
            this.groupBox5.Location = new System.Drawing.Point(49, 54);
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbTicketIdGen);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox9.Location = new System.Drawing.Point(49, 349);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(312, 68);
            this.groupBox9.TabIndex = 0;
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
            // pnCustomerInfo
            // 
            this.pnCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCustomerInfo.Controls.Add(this.groupBox10);
            this.pnCustomerInfo.Controls.Add(this.groupBox3);
            this.pnCustomerInfo.Controls.Add(this.groupBox2);
            this.pnCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCustomerInfo.Enabled = false;
            this.pnCustomerInfo.Location = new System.Drawing.Point(0, 57);
            this.pnCustomerInfo.Name = "pnCustomerInfo";
            this.pnCustomerInfo.Size = new System.Drawing.Size(771, 109);
            this.pnCustomerInfo.TabIndex = 2;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbStatus);
            this.groupBox10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox10.Location = new System.Drawing.Point(454, 65);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(192, 38);
            this.groupBox10.TabIndex = 0;
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
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(46, 38);
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExtendTerm);
            this.panel2.Controls.Add(this.btnRegisterMember);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnModeTurn);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 57);
            this.panel2.TabIndex = 1;
            // 
            // btnExtendTerm
            // 
            this.btnExtendTerm.Location = new System.Drawing.Point(356, 25);
            this.btnExtendTerm.Name = "btnExtendTerm";
            this.btnExtendTerm.Size = new System.Drawing.Size(75, 23);
            this.btnExtendTerm.TabIndex = 1;
            this.btnExtendTerm.Text = "Gia hạn";
            this.btnExtendTerm.UseVisualStyleBackColor = true;
            this.btnExtendTerm.Visible = false;
            this.btnExtendTerm.Click += new System.EventHandler(this.btnExtendTerm_Click);
            // 
            // btnRegisterMember
            // 
            this.btnRegisterMember.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegisterMember.Location = new System.Drawing.Point(590, 25);
            this.btnRegisterMember.Name = "btnRegisterMember";
            this.btnRegisterMember.Size = new System.Drawing.Size(95, 23);
            this.btnRegisterMember.TabIndex = 2;
            this.btnRegisterMember.Text = "Mua vé tháng";
            this.btnRegisterMember.UseVisualStyleBackColor = true;
            this.btnRegisterMember.Click += new System.EventHandler(this.btnRegisterMember_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Location = new System.Drawing.Point(691, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModeTurn
            // 
            this.btnModeTurn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModeTurn.Location = new System.Drawing.Point(509, 25);
            this.btnModeTurn.Name = "btnModeTurn";
            this.btnModeTurn.Size = new System.Drawing.Size(75, 23);
            this.btnModeTurn.TabIndex = 1;
            this.btnModeTurn.Text = "Gửi lượt";
            this.btnModeTurn.UseVisualStyleBackColor = true;
            this.btnModeTurn.Click += new System.EventHandler(this.btnModeTurn_Click);
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
            // PnlIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 429);
            this.ControlBox = false;
            this.Controls.Add(this.pnIn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PnlIn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmTurn";
            this.pnIn.ResumeLayout(false);
            this.pnOption.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.pnCustomerInfo.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnOption;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbTicketIdGen;
        private System.Windows.Forms.Panel pnCustomerInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBlock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbLicensePlate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegisterMember;
        private System.Windows.Forms.Button btnModeTurn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTicketIdInput;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGenTicketId;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Button btnExtendTerm;
    }
}