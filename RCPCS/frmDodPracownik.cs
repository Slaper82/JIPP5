using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPCS.RCPTableAdapters;

namespace RCPCS
{

    public partial class frmDodPracownik : Form
    {
        public event Clicked Dodano;
        public frmDodPracownik()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Pracownik nowy = new Pracownik();
            if ( txtLogin.Text!=String.Empty && txtPass.Text!=String.Empty)
            {
                if (txtPass.Text == txtPass2.Text)
                {
                    if (nowy.SprawdzLogin(txtLogin.Text))
                    {
                        nowy.DodajPracownika(txtImie.Text, txtNazwisko.Text, rdbFemale.Checked, true, Convert.ToInt32(cmbDepartment.SelectedValue), Convert.ToInt32(cmbUprawnienia.SelectedValue), txtLogin.Text, txtPass.Text);
                        Dodano();
                        this.Close();

                    }
                    else MessageBox.Show("Podany login już istnieje. Prosze podać inny login.");
                }
                else MessageBox.Show("Hasła sie nie zgadzają. Proszę wpisać takie same hasła");
            }
            else MessageBox.Show("Pole login i hasło nie mogą być puste");
            
        }

        private void frmDodPracownik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uprawnieniaDataSet.Uprawnienia_Lista' table. You can move, or remove it, as needed.
            this.uprawnienia_ListaTableAdapter.Fill(this.uprawnieniaDataSet.Uprawnienia_Lista);
            // TODO: This line of code loads data into the 'rCP.Lista_Departamenty' table. You can move, or remove it, as needed.
            this.lista_DepartamentyTableAdapter.Fill(this.rCP.Lista_Departamenty);
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
