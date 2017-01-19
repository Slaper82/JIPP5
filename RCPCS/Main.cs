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
using RCPCS.UprawnieniaDataSetTableAdapters;

namespace RCPCS
{
    public delegate void Clicked();
    public delegate void OdswierzDataGridView(DataGridView Harmo, int UserId);
    public delegate void Zapisano(object sender, EventArgs e);
    public partial class Main : Form
    {
        public event Clicked Zapisz;
        public int SelectedUser { get; set; }
        public string SelectedHarmo { get; set; }
        public string CStart { get; set; }
        public string CStop { get; set; }
        public int SelectedHarmoId { get; set; }
        TreeUse drzewo;
        Helper pomocnik;
        public Main()
        {
            InitializeComponent();
            drzewo = new TreeUse(treeView1,imageList1);
            drzewo.WypelnijDrzewo();
            pomocnik = new Helper(this.treeView1, imageList1);
            
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Pracownik usr = new Pracownik(this);
            dgvRaport.DataSource = null;
            dgvRaport.Update();
            dgvRaport.Refresh();
            string selectedNode = e.Node.Tag.ToString();
            int Id;
            bool IsUser = int.TryParse(selectedNode, out Id);
            SelectedUser = Id;
            if (IsUser)
            {
                usr.PokazDaneUzytkownika(Id);
                usr.PrzypiszDaneFormularzu();                    
            }
            else
            {
                usr.WyczyscDaneFormularza();
            }
        }
        private void dodajPracownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodPracownik nowy = new frmDodPracownik();
            nowy.Dodano += pomocnik.Odswierz;
            nowy.ShowDialog();
        }
        private void btnZapiszZmiany_Click(object sender, EventArgs e)
        {
            if (txtId.Text != String.Empty)
            {
                Pracownik aktual = new Pracownik();
                aktual.AktualizujDanePracownika(SelectedUser, txtImie.Text, txtNazwisko.Text, rdbFemale.Checked, true, txtDepartament.Text, txtFunkcja.Text);
                pomocnik.Odswierz();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rCP.rcpUserHarmo' table. You can move, or remove it, as needed.
            this.rcpUserHarmoTableAdapter.Fill(this.rCP.rcpUserHarmo);
            // TODO: This line of code loads data into the 'rCP.rcpSchemaName' table. You can move, or remove it, as needed.
            this.rcpSchemaNameTableAdapter.Fill(this.rCP.rcpSchemaName);
            // TODO: This line of code loads data into the 'uprawnieniaDataSet.Uprawnienia_Lista' table. You can move, or remove it, as needed.
            this.uprawnienia_ListaTableAdapter.Fill(this.uprawnieniaDataSet.Uprawnienia_Lista);
            // TODO: This line of code loads data into the 'rCP.Lista_Departamenty' table. You can move, or remove it, as needed.
            this.lista_DepartamentyTableAdapter.Fill(this.rCP.Lista_Departamenty);
        }

        private void btnZmienDept_Click(object sender, EventArgs e)
        {
            Lista_DepartamentyTableAdapter deptList = new Lista_DepartamentyTableAdapter();
            frmZmiana dept = new frmZmiana(this.txtDepartament);
            dept.Zmieniono += pomocnik.Odswierz;
            dept.Zapisz += btnZapiszZmiany_Click;
            dept.cmbWybor.DataSource = deptList.GetData();
            dept.cmbWybor.DisplayMember = "Name";
            dept.ShowDialog();
        }

        private void btnZmienPriv_Click(object sender, EventArgs e)
        {
            Uprawnienia_ListaTableAdapter privList = new Uprawnienia_ListaTableAdapter();
            frmZmiana priv = new frmZmiana(this.txtFunkcja);
            priv.Zmieniono += pomocnik.Odswierz;
            priv.cmbWybor.DataSource = privList.GetData();
            priv.cmbWybor.DisplayMember = "Nazwa";
            priv.ShowDialog();
        }

        private void zarządzajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZmianaDept zarz = new frmZmianaDept();
            zarz.Aktualizuj += pomocnik.Odswierz;
            zarz.ShowDialog();
            }

        private void btnUsunPrac_Click(object sender, EventArgs e)
        {
            if (txtId.Text != String.Empty)
            {
                int Id = Convert.ToInt32(txtId.Text);
                Pracownik usun = new Pracownik();
                usun.UsunPracownika(Id);
                txtDepartament.Text = String.Empty;
                txtImie.Text = String.Empty;
                txtNazwisko.Text = String.Empty;
                txtId.Text = String.Empty;
                txtFunkcja.Text = String.Empty;
                pomocnik.Odswierz();
            }
        }

        private void nowyDepartamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZmianaNazw nowy = new frmZmianaNazw("Dodaj nowy departament","Wpisz nazwę departamentu");
            nowy.ShowDialog();
            pomocnik.Odswierz();
        }
        private void dodajPracownikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDodPracownik nowy = new frmDodPracownik();
            nowy.Dodano += pomocnik.Odswierz;
            nowy.ShowDialog();
        }
        private void nowySchematToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSchemat nowy = new frmSchemat();
            nowy.ShowDialog();
        }

        private void listaSchematowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchemaEdit nowy = new frmSchemaEdit();
            
            nowy.ShowDialog();
        }
        private void btnHarmo_Click(object sender, EventArgs e)
        {
            frmHarmoAdd nowy = new frmHarmoAdd(dgvHarmonogram, SelectedUser);
            nowy.Dodano += pomocnik.OdswierzHarmo;
            nowy.ShowDialog();
        }
        private void dgvHarmonogram_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHarmonogram.CurrentCell!=null&&dgvHarmonogram.CurrentCell.RowIndex >= 0)
            {
              SelectedHarmo  = dgvHarmonogram.CurrentCell.Value.ToString();
              CStart = dgvHarmonogram.CurrentRow.Cells[1].Value.ToString();
              CStop = dgvHarmonogram.CurrentRow.Cells[2].Value.ToString();
              SelectedHarmoId= Convert.ToInt32(dgvHarmonogram.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void btnEdycja_Click(object sender, EventArgs e)
        {
           Klasy.frmHarmoEdit nowy = new Klasy.frmHarmoEdit(SelectedUser, SelectedHarmo,CStart,CStop,dgvHarmonogram,SelectedHarmoId);
            nowy.Dodano += pomocnik.OdswierzHarmo;
            nowy.ShowDialog();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Klasy.Harmonogram usun = new Klasy.Harmonogram();
            usun.UsunHarmonogram(SelectedUser, SelectedHarmo);
            pomocnik.OdswierzHarmo(dgvHarmonogram, SelectedUser);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpStop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            lblNorma.Text = "__:__";
            string start = dtpStart.Value.ToShortDateString();
            string stop = dtpStop.Value.ToShortDateString();
            start = start.Replace("-", "");
            stop = stop.Replace("-", "");
            pomocnik.PrzeliczDaneRCP(dgvRaport,lblNorma,lblOdczyty,lblNadgodz,lblBraki, SelectedUser, start, stop);
           // lblNorma.Text= pomocnik.PokazNorme(SelectedUser, start, stop);
            //lblOdczyty.Text = pomocnik.PokazOczyty(SelectedUser, start, stop);
            //lblBraki.Text = pomocnik.PokazBraki(SelectedUser, start, stop);
            //lblNadgodz.Text=pomocnik.PokazNadgodz(SelectedUser, start, stop);

        }

        private void btnLoginChange_Click(object sender, EventArgs e)
        {
            frmLoginMod nowy = new frmLoginMod(this.SelectedUser);
            nowy.ShowDialog();
        }
    }
}
