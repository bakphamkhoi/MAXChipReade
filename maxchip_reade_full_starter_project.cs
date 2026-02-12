// MAXChipReade – Full Starter WinForms Project with Basic Kiosk UI
// .NET 8 – Build là chạy được EXE

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MAXChipReade
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private Label lblTitle;
        private Label lblStatus;
        private Button btnTest;

        public MainForm()
        {
            Text = "MAXChipReade v1.0 TEST";
            Width = 600;
            Height = 350;
            StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label()
            {
                Text = "MAXChipReade – Hệ thống quét CCCD",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Left = 80,
                Top = 40
            };

            lblStatus = new Label()
            {
                Text = "Sẵn sàng hoạt động",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Left = 220,
                Top = 120
            };

            btnTest = new Button()
            {
                Text = "Test chạy EXE",
                Width = 140,
                Height = 40,
                Left = 220,
                Top = 180
            };

            btnTest.Click += (s, e) =>
            {
                MessageBox.Show("MAXChipReade đang hoạt động bình thường!", "Thông báo");
            };

            Controls.Add(lblTitle);
            Controls.Add(lblStatus);
            Controls.Add(btnTest);
        }
    }
}