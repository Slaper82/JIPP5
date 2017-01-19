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
    public partial class frmSchemat : Form
    { 

        public frmSchemat()
        {
            InitializeComponent();
        }

        private void frmSchemat_Load(object sender, EventArgs e)
        {
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
            

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = sender as TextBox;
            try
            {
                box.Text = String.Format("{00:00}");
            }
            catch
            {
                box.Text = "00:00";
            }
        }

        private void chbWto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {   
            Klasy.Schema schema = new Klasy.Schema();
            int IdSchematu = schema.NumerSchematu();
            if (txtNazwaSchematu.Text != String.Empty)
            {
                schema.ZapiszNazweSchematu(IdSchematu+1, txtNazwaSchematu.Text);
                if (chbPon.Checked) schema.DodajSchemat(IdSchematu + 1, 2, TimeSpan.Parse(mtxtPonStart.Text), TimeSpan.Parse(mtxtPonStop.Text), txtNazwaSchematu.Text);
                else schema.DodajSchemat(IdSchematu + 1, 2, null, null, txtNazwaSchematu.Text);
                if (chbWto.Checked) schema.DodajSchemat(IdSchematu+1, 3, TimeSpan.Parse(mtxtWtoStart.Text), TimeSpan.Parse(mtxtWtoStop.Text), txtNazwaSchematu.Text);
                else schema.DodajSchemat(IdSchematu + 1, 3, null, null, txtNazwaSchematu.Text);
                if (chbSro.Checked) schema.DodajSchemat(IdSchematu+1, 4, TimeSpan.Parse(mtxtSroStart.Text), TimeSpan.Parse(mtxtSroStop.Text), txtNazwaSchematu.Text);
                else schema.DodajSchemat(IdSchematu + 1, 4, null, null, txtNazwaSchematu.Text);
                if (chbCzw.Checked) schema.DodajSchemat(IdSchematu+1, 5, TimeSpan.Parse(mtxtCzwStart.Text), TimeSpan.Parse(mtxtCzwStop.Text), txtNazwaSchematu.Text);
                else schema.DodajSchemat(IdSchematu + 1, 5, null, null, txtNazwaSchematu.Text);
                if (chbPia.Checked) schema.DodajSchemat(IdSchematu+1, 6, TimeSpan.Parse(mtxtPiaStart.Text), TimeSpan.Parse(mtxtPiaStop.Text), txtNazwaSchematu.Text);
                else schema.DodajSchemat(IdSchematu + 1, 6, null, null, txtNazwaSchematu.Text);
                if (chbSob.Checked) schema.DodajSchemat(IdSchematu+1, 7, TimeSpan.Parse(mtxtSobStart.Text), TimeSpan.Parse(mtxtSobStop.Text), txtNazwaSchematu.Text);
                else schema.DodajSchemat(IdSchematu + 1, 7, null, null, txtNazwaSchematu.Text);
                if (chbNie.Checked) schema.DodajSchemat(IdSchematu+1, 1, TimeSpan.Parse(mtxtNieStart.Text), TimeSpan.Parse(mtxtNieStop.Text), txtNazwaSchematu.Text);
                else schema.DodajSchemat(IdSchematu + 1, 1, null, null, txtNazwaSchematu.Text);
            }
            this.Close();
        }

        private  void chbPon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb =(CheckBox)sender;
            
            if(chb.Checked)
            {
                if(chb.Name.Contains("Pon"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("PonSta")) ctr.Text = "08:00";
                        if (ctr.Name.Contains("PonSto")) ctr.Text = "16:00";
                    }
                else if(chb.Name.Contains("Wto"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("WtoSta")) ctr.Text = "08:00";
                        if (ctr.Name.Contains("WtoSto")) ctr.Text = "16:00";
                    }
                else if (chb.Name.Contains("Sro"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("SroSta")) ctr.Text = "08:00";
                        if (ctr.Name.Contains("SroSto")) ctr.Text = "16:00";
                    }
                else if (chb.Name.Contains("Czw"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("CzwSta")) ctr.Text = "08:00";
                        if (ctr.Name.Contains("CzwSto")) ctr.Text = "16:00";
                    }
                else if (chb.Name.Contains("Pia"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("PiaSta")) ctr.Text = "08:00";
                        if (ctr.Name.Contains("PiaSto")) ctr.Text = "16:00";
                    }
                else if (chb.Name.Contains("Sob"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("SobSta")) ctr.Text = "08:00";
                        if (ctr.Name.Contains("SobSto")) ctr.Text = "16:00";
                    }
                else if (chb.Name.Contains("Nie"))
                    foreach (var ctr in this.Controls.OfType<MaskedTextBox>())
                    {
                        if (ctr.Name.Contains("NieSta")) ctr.Text = "08:00";
                        if (ctr.Name.Contains("NieSto")) ctr.Text = "16:00";
                    }
            }
            
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
