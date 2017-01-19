using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPCS
{
    public partial class frmLoginMod : Form
    {
        public int UserId { get; set; }
        public frmLoginMod(int Id)
        {
            InitializeComponent();
            this.UserId = Id;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Pracownik nowy = new Pracownik();
            if (nowy.SprawdzLogin(txtLogin.Text) && txtPass.Text == txtPass2.Text)
            {
                nowy.NadpiszLogin(UserId, txtLogin.Text, txtPass.Text);
                this.Close();
            }
            else MessageBox.Show("Login już istnieje lub hasła się nie zgadzają");
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
