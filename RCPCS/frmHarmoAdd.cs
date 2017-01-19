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
    public partial class frmHarmoAdd : Form
    {       
        public event OdswierzDataGridView Dodano;
        Klasy.Harmonogram Harmo;
        public int UserId { get; set; }
        public DataGridView HarmoTab { get; set; }

        public frmHarmoAdd(DataGridView HarmoTab,int UserId)
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Now;
            dtpStop.Value = dtpStart.Value.AddMonths(6);
            Harmo= new Klasy.Harmonogram();
            this.UserId = UserId;
            this.HarmoTab = HarmoTab;
        }
        private void frmHarmoAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rCP.rcpSchemaName' table. You can move, or remove it, as needed.
            this.rcpSchemaNameTableAdapter.Fill(this.rCP.rcpSchemaName);
        }
        
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string Start = dtpStart.Value.Date.ToString();
            Start = Start.Replace("-", "");
            string Stop = dtpStop.Value.Date.ToString();
            Stop = Stop.Replace("-", "");
            Harmo.DodajHarmonogram(UserId, Convert.ToInt32(cmbNazwa.SelectedValue) ,Start, Stop);           
            Dodano(HarmoTab,UserId);
            this.Close();
        }
    }
}
