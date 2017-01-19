using RCPCS.Klasy;
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
    public partial class frmSchemaEdit : Form
    {
        Schema lista;
        List<CheckBox> checkBoxy = new List<CheckBox>();
        public frmSchemaEdit()
        {
            InitializeComponent();
            lista = new Schema(this);
            this.Shown += new EventHandler(frmSchemaEdit_Shown);
        }

        private void frmSchemaEdit_Shown(object sender, EventArgs e)
        {
           if(lstSchema.Items.Count>0) lstSchema.SelectedIndex = 0;
            int id = Convert.ToInt32(lstSchema.SelectedValue);
            lista.UzupelnijDane(id);
        }

        private void Przeladuj()
        {
            
        }

        private void frmSchemaEdit_Load(object sender, EventArgs e)
        {

            this.rcpSchemaNameTableAdapter.Fill(this.rCP.rcpSchemaName);
            //Ustawienie formatu dla maskedtextbox start
            mtxtPonStart.Mask = "00:00";
            mtxtWtoStart.Mask = "00:00";
            mtxtSroStart.Mask = "00:00";
            mtxtCzwStart.Mask = "00:00";
            mtxtPiaStart.Mask = "00:00";
            mtxtSobStart.Mask = "00:00";
            mtxtNieStart.Mask = "00:00";
            //Ustawienie formatu dla maskedtextbox stop
            mtxtPonStop.Mask = "00:00";
            mtxtWtoStop.Mask = "00:00";
            mtxtSroStop.Mask = "00:00";
            mtxtCzwStop.Mask = "00:00";
            mtxtPiaStop.Mask = "00:00";
            mtxtSobStop.Mask = "00:00";
            mtxtNieStop.Mask = "00:00";
           if( lstSchema.Items.Count>0) lstSchema.SelectedIndex = 0;
            foreach (var ctr in this.Controls.OfType<CheckBox>())
            {
                checkBoxy.Add(ctr);
            }

        }

        private void lstBSchema_Click(object sender, EventArgs e)
        {
            btnUsun.Enabled = true;
            btnZapisz.Enabled = true;
            int id = Convert.ToInt32(lstSchema.SelectedValue);
            lista.UzupelnijDane(id);
        }

        private void chbPon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            string dd=chb.Name;

            if (chb.Checked)
            {
                if (chb.Name.Contains("Pon"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("PonSta"))
                        {
                            ctr.Text = "08:00";
                            ctr.Enabled = true;
                        }
                        if (ctr.Name.Contains("PonSto"))
                        {
                            ctr.Text = "16:00";
                            ctr.Enabled = true;
                        }

                    }
                else if (chb.Name.Contains("Wto"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("WtoSta"))
                        {
                            ctr.Text = "08:00";
                            ctr.Enabled = true;
                        }
                        if (ctr.Name.Contains("WtoSto"))
                        {
                            ctr.Text = "16:00";
                            ctr.Enabled = true;
                        }
                    }
                else if (chb.Name.Contains("Sro"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("SroSta"))
                        {
                            ctr.Text = "08:00";
                            ctr.Enabled = true;
                        }
                        if (ctr.Name.Contains("SroSto"))
                        {
                            ctr.Text = "16:00";
                            ctr.Enabled = true;
                        }
                    }
                else if (chb.Name.Contains("Czw"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("CzwSta"))
                        {
                            ctr.Text = "08:00";
                            ctr.Enabled = true;
                        }
                        if (ctr.Name.Contains("CzwSto"))
                        {
                            ctr.Text = "16:00";
                            ctr.Enabled = true;
                        }
                    }
                else if (chb.Name.Contains("Pia"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("PiaSta"))
                        {
                            ctr.Text = "08:00";
                            ctr.Enabled = true;
                        }
                        if (ctr.Name.Contains("PiaSto"))
                        {
                            ctr.Text = "16:00";
                            ctr.Enabled = true;
                        }
                    }
                else if (chb.Name.Contains("Sob"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("SobSta"))
                        {
                            ctr.Text = "08:00";
                            ctr.Enabled = true;
                        }
                        if (ctr.Name.Contains("SobSto"))
                        {
                            ctr.Text = "16:00";
                            ctr.Enabled = true;
                        }
                    }
                else if (chb.Name.Contains("Nie"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("NieSta"))
                        {
                            ctr.Text = "08:00";
                            ctr.Enabled = true;
                        }
                        if (ctr.Name.Contains("NieSto"))
                        {
                            ctr.Text = "16:00";
                            ctr.Enabled = true;
                        }
                    }

            }
            else
            {
                if (chb.Name.Contains("Pon"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("PonSta")) ctr.Enabled = false;
                        if (ctr.Name.Contains("PonSto")) ctr.Enabled = false;
                    }
                else if (chb.Name.Contains("Wto"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("WtoSta")) ctr.Enabled = false;
                        if (ctr.Name.Contains("WtoSto")) ctr.Enabled = false;
                    }
                else if (chb.Name.Contains("Sro"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("SroSta")) ctr.Enabled = false;
                        if (ctr.Name.Contains("SroSto")) ctr.Enabled = false;
                    }
                else if (chb.Name.Contains("Czw"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("CzwSta")) ctr.Enabled = false;
                        if (ctr.Name.Contains("CzwSto")) ctr.Enabled = false;
                    }
                else if (chb.Name.Contains("Pia"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("PiaSta")) ctr.Enabled = false;
                        if (ctr.Name.Contains("PiaSto")) ctr.Enabled = false;
                    }
                else if (chb.Name.Contains("Sob"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("SobSta")) ctr.Enabled = false;
                        if (ctr.Name.Contains("SobSto")) ctr.Enabled = false;
                    }
                else if (chb.Name.Contains("Nie"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("NieSta")) ctr.Enabled = false;
                        if (ctr.Name.Contains("NieSto")) ctr.Enabled = false;
                    }
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

            lista.ZapiszForm();
            frmSchemaEdit_Load(this, e);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lstSchema.SelectedValue);
            lista.UsunSchemat(id);
            frmSchemaEdit_Load(this, e);
        }
    }
}
