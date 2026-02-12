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
        public MainForm()
        {
            Text = "MAXChipReade v1.0 TEST";
            Width = 600;
            Height = 350;
            StartPosition = FormStartPosition.CenterScreen;

            var lbl = new Label()
            {
                Text = "MAXChipReade đang chạy trên Windows",
                AutoSize = true,
                Left = 150,
                Top = 120,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            Controls.Add(lbl);
        }
    }
}
