using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPCS.Klasy
{
    public partial class frmHarmoEdit : Form
    {
        private DataGridView Harmo;
        public int UserId { get; set; }
        public string Nazwa { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }

        public int HarmoId { get; set; }

        Klasy.Harmonogram Dodaj;
        public event OdswierzDataGridView Dodano;
        public frmHarmoEdit(int UserId,string Nazwa,string Start,string Stop,DataGridView Harmo,int HarmoId)

        {
            InitializeComponent();
            this.UserId = UserId;
            this.Nazwa = Nazwa;
            this.Start = Start;
            this.Stop = Stop;
            this.Start=DataToString(dtpStart.Value);
            this.Stop= DataToString(dtpStop.Value);
            this.Harmo = Harmo;
            this.HarmoId = HarmoId;
        }
        private string DataToString(DateTime dtp)
        {
            string conv = dtp.Date.ToString();
            conv= conv.Replace("-", "");
            conv = conv.Substring(0, 8);
            return conv;
        }
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Dodaj = new Harmonogram();
            this.Start = DataToString(dtpStart.Value);
            this.Stop = DataToString(dtpStop.Value);
            try
            {
                Dodaj.EdytujHarmonogram(HarmoId, Start, Stop);
                Dodano(Harmo, UserId);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
