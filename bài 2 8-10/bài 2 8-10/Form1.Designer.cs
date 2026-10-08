namespace bài_2_8_10
{
    partial class Form1
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
            lblTicketId = new Label();
            txtTicketId = new TextBox();
            lblRequester = new Label();
            txtRequester = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            grpPriority = new GroupBox();
            rdbLow = new RadioButton();
            rdbMedium = new RadioButton();
            rdbHigh = new RadioButton();
            lblIssueType = new Label();
            cmbIssueType = new ComboBox();
            grpDevices = new GroupBox();
            chkPhone = new CheckBox();
            chkPrinter = new CheckBox();
            chkLaptop = new CheckBox();
            chkDesktop = new CheckBox();
            picError = new PictureBox();
            btnLoadImage = new Button();
            btnSend = new Button();
            btnReset = new Button();
            openFileDialog1 = new OpenFileDialog();
            grpPriority.SuspendLayout();
            grpDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picError).BeginInit();
            SuspendLayout();
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(12, 15);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(71, 20);
            lblTicketId.TabIndex = 0;
            lblTicketId.Text = "Mã phiếu";
            // 
            // txtTicketId
            // 
            txtTicketId.Location = new Point(110, 12);
            txtTicketId.Name = "txtTicketId";
            txtTicketId.Size = new Size(200, 27);
            txtTicketId.TabIndex = 1;
            // 
            // lblRequester
            // 
            lblRequester.AutoSize = true;
            lblRequester.Location = new Point(12, 50);
            lblRequester.Name = "lblRequester";
            lblRequester.Size = new Size(105, 20);
            lblRequester.TabIndex = 2;
            lblRequester.Text = "Người yêu cầu";
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(110, 47);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(200, 27);
            txtRequester.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 85);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(105, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Ngày ghi nhận";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(110, 80);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 27);
            dtpDate.TabIndex = 5;
            // 
            // grpPriority
            // 
            grpPriority.Controls.Add(rdbLow);
            grpPriority.Controls.Add(rdbMedium);
            grpPriority.Controls.Add(rdbHigh);
            grpPriority.Location = new Point(12, 115);
            grpPriority.Name = "grpPriority";
            grpPriority.Size = new Size(298, 60);
            grpPriority.TabIndex = 6;
            grpPriority.TabStop = false;
            grpPriority.Text = "Mức độ ưu tiên";
            // 
            // rdbLow
            // 
            rdbLow.AutoSize = true;
            rdbLow.Location = new Point(10, 25);
            rdbLow.Name = "rdbLow";
            rdbLow.Size = new Size(63, 24);
            rdbLow.TabIndex = 0;
            rdbLow.TabStop = true;
            rdbLow.Text = "Thấp";
            rdbLow.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            rdbMedium.AutoSize = true;
            rdbMedium.Location = new Point(110, 25);
            rdbMedium.Name = "rdbMedium";
            rdbMedium.Size = new Size(100, 24);
            rdbMedium.TabIndex = 1;
            rdbMedium.TabStop = true;
            rdbMedium.Text = "Trung bình";
            rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbHigh
            // 
            rdbHigh.AutoSize = true;
            rdbHigh.Location = new Point(210, 25);
            rdbHigh.Name = "rdbHigh";
            rdbHigh.Size = new Size(91, 24);
            rdbHigh.TabIndex = 2;
            rdbHigh.TabStop = true;
            rdbHigh.Text = "Khẩn cấp";
            rdbHigh.UseVisualStyleBackColor = true;
            // 
            // lblIssueType
            // 
            lblIssueType.AutoSize = true;
            lblIssueType.Location = new Point(12, 190);
            lblIssueType.Name = "lblIssueType";
            lblIssueType.Size = new Size(76, 20);
            lblIssueType.TabIndex = 7;
            lblIssueType.Text = "Loại sự cố";
            // 
            // cmbIssueType
            // 
            cmbIssueType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIssueType.FormattingEnabled = true;
            cmbIssueType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cmbIssueType.Location = new Point(110, 187);
            cmbIssueType.Name = "cmbIssueType";
            cmbIssueType.Size = new Size(200, 28);
            cmbIssueType.TabIndex = 8;
            // 
            // grpDevices
            // 
            grpDevices.Controls.Add(chkPhone);
            grpDevices.Controls.Add(chkPrinter);
            grpDevices.Controls.Add(chkLaptop);
            grpDevices.Controls.Add(chkDesktop);
            grpDevices.Location = new Point(12, 225);
            grpDevices.Name = "grpDevices";
            grpDevices.Size = new Size(298, 90);
            grpDevices.TabIndex = 9;
            grpDevices.TabStop = false;
            grpDevices.Text = "Thiết bị ảnh hưởng";
            // 
            // chkPhone
            // 
            chkPhone.AutoSize = true;
            chkPhone.Location = new Point(160, 55);
            chkPhone.Name = "chkPhone";
            chkPhone.Size = new Size(100, 24);
            chkPhone.TabIndex = 3;
            chkPhone.Text = "Điện thoại";
            chkPhone.UseVisualStyleBackColor = true;
            // 
            // chkPrinter
            // 
            chkPrinter.AutoSize = true;
            chkPrinter.Location = new Point(10, 55);
            chkPrinter.Name = "chkPrinter";
            chkPrinter.Size = new Size(75, 24);
            chkPrinter.TabIndex = 2;
            chkPrinter.Text = "Máy in";
            chkPrinter.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(160, 25);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 1;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkDesktop
            // 
            chkDesktop.AutoSize = true;
            chkDesktop.Location = new Point(10, 25);
            chkDesktop.Name = "chkDesktop";
            chkDesktop.Size = new Size(117, 24);
            chkDesktop.TabIndex = 0;
            chkDesktop.Text = "Máy tính bàn";
            chkDesktop.UseVisualStyleBackColor = true;
            // 
            // picError
            // 
            picError.BorderStyle = BorderStyle.FixedSingle;
            picError.Location = new Point(340, 12);
            picError.Name = "picError";
            picError.Size = new Size(440, 300);
            picError.SizeMode = PictureBoxSizeMode.StretchImage;
            picError.TabIndex = 10;
            picError.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(340, 325);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(120, 30);
            btnLoadImage.TabIndex = 11;
            btnLoadImage.Text = "Tải ảnh lỗi";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(660, 360);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(120, 30);
            btnSend.TabIndex = 12;
            btnSend.Text = "Gửi yêu cầu";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(520, 360);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 30);
            btnReset.TabIndex = 13;
            btnReset.Text = "Nhập lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnSend);
            Controls.Add(btnLoadImage);
            Controls.Add(picError);
            Controls.Add(grpDevices);
            Controls.Add(cmbIssueType);
            Controls.Add(lblIssueType);
            Controls.Add(grpPriority);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtRequester);
            Controls.Add(lblRequester);
            Controls.Add(txtTicketId);
            Controls.Add(lblTicketId);
            Name = "Form1";
            Text = "Tiếp nhận & Phân loại sự cố IT";
            grpPriority.ResumeLayout(false);
            grpPriority.PerformLayout();
            grpDevices.ResumeLayout(false);
            grpDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton rdbLow;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbHigh;
        private System.Windows.Forms.Label lblIssueType;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.GroupBox grpDevices;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        #endregion
    }
}
