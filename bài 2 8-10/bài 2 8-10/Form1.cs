namespace bài_2_8_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = Image.FromFile(openFileDialog1.FileName);
                    picError.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var id = txtTicketId.Text.Trim();
            var requester = txtRequester.Text.Trim();
            var date = dtpDate.Value.ToString("g");

            string priority = "";
            if (rdbLow.Checked) priority = "Thấp";
            else if (rdbMedium.Checked) priority = "Trung bình";
            else if (rdbHigh.Checked) priority = "Khẩn cấp";

            var issueType = cmbIssueType.SelectedItem?.ToString() ?? "(chưa chọn)";

            var devices = new System.Collections.Generic.List<string>();
            if (chkDesktop.Checked) devices.Add("Máy tính bàn");
            if (chkLaptop.Checked) devices.Add("Laptop");
            if (chkPrinter.Checked) devices.Add("Máy in");
            if (chkPhone.Checked) devices.Add("Điện thoại");
            var devicesText = devices.Count > 0 ? string.Join(", ", devices) : "(không có)";

            var hasImage = picError.Image != null ? "Yes" : "No";

            var summary = new System.Text.StringBuilder();
            summary.AppendLine("--- Tóm tắt phiếu yêu cầu ---");
            summary.AppendLine($"Mã phiếu: {id}");
            summary.AppendLine($"Người yêu cầu: {requester}");
            summary.AppendLine($"Ngày ghi nhận: {date}");
            summary.AppendLine($"Mức độ ưu tiên: {priority}");
            summary.AppendLine($"Loại sự cố: {issueType}");
            summary.AppendLine($"Thiết bị ảnh hưởng: {devicesText}");
            summary.AppendLine($"Ảnh lỗi đính kèm: {hasImage}");

            MessageBox.Show(summary.ToString(), "Phiếu yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Clear();
            txtRequester.Clear();
            dtpDate.Value = DateTime.Now;
            rdbLow.Checked = false;
            rdbMedium.Checked = false;
            rdbHigh.Checked = false;
            cmbIssueType.SelectedIndex = -1;
            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;
            if (picError.Image != null)
            {
                picError.Image.Dispose();
                picError.Image = null;
            }
        }
    }
}
