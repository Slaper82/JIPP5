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
    public partial class frmZmianaNazw : Form
    {
        string Nazwa;
        int Id;
        PrivTableAdapter adapter;
        public frmZmianaNazw(string NazwaOkna,string Label)
        {
            InitializeComponent();
            this.Name = NazwaOkna;
            this.label1.Text = Label;
            adapter = new PrivTableAdapter();
        }
        public frmZmianaNazw(int Id,string Nazwa)
        {
            InitializeComponent();
            this.Nazwa = Nazwa;
            this.Id = Id;
            txtNazwa.Text = this.Nazwa;
            adapter = new PrivTableAdapter();
        }

        private void frmZmianaNazw_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.Name == "Dodaj nowy departament")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        adapter.DepartmentAdd(txtNazwa.Text);
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Nazwa = txtNazwa.Text;
                    adapter.DepartmentRename(Id, Nazwa);
                    this.Close();
                }
            }
        }

        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
