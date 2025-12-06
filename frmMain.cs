using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void عارةكتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // فتح واجهة الإعارة عند النقر
            frmBorrowing borrowingForm = new frmBorrowing();
            borrowingForm.Show();
        }

        private void إدارةالكتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lec 03 & 04: عرض نموذج جديد
            frmBooks booksForm = new frmBooks();

            // لإظهار النموذج بشكل مستقل عن النموذج الرئيسي
            booksForm.Show();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إدارةالأعضاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            {
                // فتح واجهة الأعضاء عند النقر
                frmMembers membersForm = new frmMembers();
                membersForm.Show();
            }
        }
    }
}
