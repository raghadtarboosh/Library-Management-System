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


namespace LibraryManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
       

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }



        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(45, 90, 160);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(30, 70, 130);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


        }
       

       
        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmlogin2_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;

            // خلفية البانيل
            p.BackColor = Color.White;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // EXTENDED SOFT SHADOW (FLOAT EFFECT)
            for (int i = 1; i <= 12; i++)
            {
                int alpha = 40 - (i * 3); // تخفيف الظل كل ما ابتعد
                if (alpha < 1) alpha = 1;

                using (SolidBrush b = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(b,
                        new Rectangle(p.Left - i, p.Top - i, p.Width + (i * 2), p.Height + (i * 2)));
                }
            }


        }
    }

       
    
}
