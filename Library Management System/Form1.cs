using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += MainForm_Paint;
            panelLogin.Paint += PanelLogin_Paint;

        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 240, 250, 255), // لون علوي فاتح
                Color.FromArgb(255, 250, 255, 255), // لون سفلي أبيض مقارب
                0f)) // زاوية التدرج (0 = أيسر ليمين)
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // يمكنك إضافة تأثيرات ناعمة إضافية (super light)
            using (LinearGradientBrush topGlow = new LinearGradientBrush(
                new Rectangle(0, 0, rect.Width, 120),
                Color.FromArgb(120, 200, 245, 255),
                Color.FromArgb(0, Color.White),
                90f))
            {
                e.Graphics.FillRectangle(topGlow, new Rectangle(0, 0, rect.Width, 120));
            }
        }

        // رسم الظل وزوايا منحنية للـ panelLogin
        private void PanelLogin_Paint(object sender, PaintEventArgs e)
        {
            Control ctrl = sender as Control;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int cornerRadius = 16;
            Rectangle rect = ctrl.ClientRectangle;

            // رسم ظل خفيف (بمقدار إزاحة صغيرة)
            Rectangle shadowRect = new Rectangle(rect.X + 6, rect.Y + 6, rect.Width - 1, rect.Height - 1);
            using (GraphicsPath gpShadow = RoundedRect(shadowRect, cornerRadius))
            using (SolidBrush sb = new SolidBrush(Color.FromArgb(35, 0, 0, 0)))
            {
                e.Graphics.FillPath(sb, gpShadow);
            }

            // رسم خلفية الـ panel نفسها بزاوية منحنية
            using (GraphicsPath gp = RoundedRect(rect, cornerRadius))
            using (SolidBrush b = new SolidBrush(Color.White))
            {
                e.Graphics.FillPath(b, gp);
            }
        }

        // دالة مساعدة لعمل مسار بمستطيل بزوايا منحنية
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            // أعلى يسار
            path.AddArc(arc, 180, 90);

            // أعلى يمين
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // أسفل يمين
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // أسفل يسار
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TextBox: إزالة الحدود الافتراضية وجعلها تبدو كحقل عصري
            txtEmail.BorderStyle = BorderStyle.None;
            txtPassword.BorderStyle = BorderStyle.None;

            // إضافة خطوط تحت الحقول (line) باستخدام Panel صغير
            Panel lineEmail = new Panel
            {
                Height = 1,
                Width = txtEmail.Width,
                BackColor = Color.LightGray,
                Location = new Point(txtEmail.Left, txtEmail.Bottom + 6)
            };
            panelLogin.Controls.Add(lineEmail);

            Panel linePass = new Panel
            {
                Height = 1,
                Width = txtPassword.Width,
                BackColor = Color.LightGray,
                Location = new Point(txtPassword.Left, txtPassword.Bottom + 6)
            };
            panelLogin.Controls.Add(linePass);

            // زر تسجيل دخول
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(22, 35, 64); // نفسجي/كحلي داكن
            btnLogin.ForeColor = Color.White;
            btnLogin.Height = 40;
            btnLogin.Width = 300;
            btnLogin.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void bictureIllustration_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
