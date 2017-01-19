using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCPCS.RCPTableAdapters;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace RCPCS.Klasy
{
    class Schema
    {
        [Description("Testowy opis tej wlasciwosci")]
        public int id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        PrivTableAdapter adapter;
        rcpSchemaDefTableAdapter NrAdapter;
        frmSchemat schema;
        frmSchemaEdit schemaEdit;
        List<List<Control>> DniTyg = new List<List<Control>>();
        public Schema()
        {
            adapter = new PrivTableAdapter();
            NrAdapter = new rcpSchemaDefTableAdapter();
        }
        public Schema(frmSchemat nowy)
        {
            this.schema = nowy;
        }
        public Schema(frmSchemaEdit nowy)
        {
            this.schemaEdit = nowy;
            adapter = new PrivTableAdapter();
            NrAdapter = new rcpSchemaDefTableAdapter();

        }
        public bool DodajSchemat(int Id,int Day, TimeSpan? CStart,TimeSpan? CStop,string Nazwa)
        {
            try
            {
                int spr = (int)NrAdapter.CzyIstnieje(Nazwa);
                if(spr==0) NrAdapter.InsertSchema(Id, Nazwa);
                adapter.SchemaAdd(Id, Day, CStart, CStop);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int NumerSchematu()
        {
            if ((int?)NrAdapter.PokazNr() != null)
            {
                int Id = (int)NrAdapter.PokazNr();
                return Id;
            }
            else return 1; 
        }
        public void ZapiszNazweSchematu(int id,string nazwa)
        {
            //jeśli istnieje taka nazwa schematu to dodaje
            try
            {
                adapter.NazwaSchematu(id, nazwa);
            }
            catch
            {

            }
        }
        public void ZapiszForm()
        {
            //Grupowanie kontrolek pod kątem dnia tygodnia i aktualizowanie ich grupami.
            
            int id = Convert.ToInt32(schemaEdit.lstSchema.SelectedValue);
            string name = schemaEdit.txtNazwaSchematu.Text;
            int wday=1;
            CheckBox active=null;
            TimeSpan? CStart;
            TimeSpan? CStop;
            var nie = new List<Control>() { { schemaEdit.chbNie }, { schemaEdit.mtxtNieStart }, { schemaEdit.mtxtNieStop } };
            var pon = new List<Control>() {{ schemaEdit.chbPon }, { schemaEdit.mtxtPonStart }, {schemaEdit.mtxtPonStop }};
            var wto= new List<Control>() { { schemaEdit.chbWto }, { schemaEdit.mtxtWtoStart }, { schemaEdit.mtxtWtoStop } };
            var sro = new List<Control>() { { schemaEdit.chbSro }, { schemaEdit.mtxtSroStart }, { schemaEdit.mtxtSroStop } };
            var czw = new List<Control>() { { schemaEdit.chbCzw }, { schemaEdit.mtxtCzwStart }, { schemaEdit.mtxtCzwStop } };
            var pia = new List<Control>() { { schemaEdit.chbPia }, { schemaEdit.mtxtPiaStart }, { schemaEdit.mtxtPiaStop } };
            var sob = new List<Control>() { { schemaEdit.chbSob }, { schemaEdit.mtxtSobStart }, { schemaEdit.mtxtSobStop } };
            
            DniTyg.Add(nie);
            DniTyg.Add(pon);
            DniTyg.Add(wto);
            DniTyg.Add(sro);
            DniTyg.Add(czw);
            DniTyg.Add(pia);
            DniTyg.Add(sob);
            
            foreach (List<Control> dzien in DniTyg)
            {
                if (dzien[0] is CheckBox) active = ((CheckBox)dzien[0]);
                if (active.Checked)
                    {
                        CStart = TimeSpan.Parse(dzien[1].Text);
                        CStop = TimeSpan.Parse(dzien[2].Text);
                        ZapiszZmiany(id, name, wday,(TimeSpan)CStart,(TimeSpan) CStop);
                    }
                else
                    {
                    CStart = null;
                    CStop = null;
                    ZapiszZmiany(id, name, wday,CStart, CStop);
                }
                
                wday++;
            }
            DniTyg.Clear();
           
        }
        private void ZapiszZmiany(int Id,string Name,int wday,TimeSpan? CStart,TimeSpan? CStop)
        {
            int test =Convert.ToInt32(NrAdapter.SchemaExists(Id,wday).ToString());
            if (test > 0) NrAdapter.SchemaEdit(Id, Name, wday, CStart, CStop);
            else adapter.SchemaAdd(Id, wday, CStart, CStop);
        }
        public void UsunZmiany(int Id,int wday)
        {
            try
            {
                NrAdapter.SchemaEditDel(Id, wday);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UsunSchemat(int Id)
        {
            try
            {
                NrAdapter.SchemaDel(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UzupelnijDane(int? id)
        {
            WyczyscForm();
            DataTable dt = NrAdapter.GetDataBy3(id);
            foreach (DataRow row in dt.Rows)
            {
                if (row["WDay"].ToString() == "2")
                {
                    if (row["CStart"].ToString() != string.Empty)
                    {
                        schemaEdit.mtxtPonStart.Enabled = true;
                        schemaEdit.mtxtPonStop.Enabled = true;
                        schemaEdit.mtxtPonStart.Text = row["CStart"].ToString();//.Remove(5,3);
                        schemaEdit.mtxtPonStop.Text = row["CStop"].ToString();//.Remove(5, 3);
                        schemaEdit.chbPon.Checked = true;
                    }
                    else
                    {
                        schemaEdit.mtxtSroStart.Enabled = false;
                        schemaEdit.mtxtSroStop.Enabled = false;
                        schemaEdit.chbSro.Checked = false;
                    }
                }
                else if (row["WDay"].ToString() == "3")
                {
                    if (row["CStart"].ToString() != string.Empty)
                    {
                        schemaEdit.mtxtWtoStart.Enabled = true;
                        schemaEdit.mtxtWtoStop.Enabled = true;
                        schemaEdit.mtxtWtoStart.Text = row["CStart"].ToString();//.Remove(5, 3);
                        schemaEdit.mtxtWtoStop.Text = row["CStop"].ToString();//.Remove(5, 3);
                        schemaEdit.chbWto.Checked = true;
                    }
                    else
                    {
                        schemaEdit.mtxtSroStart.Enabled = false;
                        schemaEdit.mtxtSroStop.Enabled = false;
                        schemaEdit.chbSro.Checked = false;
                    }
                }
                else if (row["WDay"].ToString() == "4")
                {
                    if (row["CStart"].ToString() != string.Empty)
                    {
                        schemaEdit.mtxtSroStart.Enabled = true;
                        schemaEdit.mtxtSroStop.Enabled = true;
                        schemaEdit.mtxtSroStart.Text = row["CStart"].ToString();//.Remove(5, 3);
                        schemaEdit.mtxtSroStop.Text = row["CStop"].ToString();//.Remove(5, 3);
                        schemaEdit.chbSro.Checked = true;
                    }
                    else
                    {
                        schemaEdit.mtxtSroStart.Enabled = false;
                        schemaEdit.mtxtSroStop.Enabled = false;
                        schemaEdit.chbSro.Checked = false;
                    }
                }
                else if (row["WDay"].ToString() == "5")
                {
                    if (row["CStart"].ToString() != string.Empty)
                    {
                        schemaEdit.mtxtCzwStart.Enabled = true;
                        schemaEdit.mtxtCzwStop.Enabled = true;
                        schemaEdit.mtxtCzwStart.Text = row["CStart"].ToString();//.Remove(5, 3);
                        schemaEdit.mtxtCzwStop.Text = row["CStop"].ToString();//.Remove(5, 3);
                        schemaEdit.chbCzw.Checked = true;
                    }
                    else
                    {
                        schemaEdit.mtxtSroStart.Enabled = false;
                        schemaEdit.mtxtSroStop.Enabled = false;
                        schemaEdit.chbSro.Checked = false;
                    }
                }
                else if (row["WDay"].ToString() == "6")
                {
                    if (row["CStart"].ToString() != string.Empty)
                    {
                        schemaEdit.mtxtPiaStart.Enabled = true;
                        schemaEdit.mtxtPiaStop.Enabled = true;
                        schemaEdit.mtxtPiaStart.Text = row["CStart"].ToString();// Remove(5, 3);
                        schemaEdit.mtxtPiaStop.Text = row["CStop"].ToString();//.Remove(5, 3);
                        schemaEdit.chbPia.Checked = true;
                    }
                    else
                    {
                        schemaEdit.mtxtSroStart.Enabled = false;
                        schemaEdit.mtxtSroStop.Enabled = false;
                        schemaEdit.chbSro.Checked = false;
                    }
                }
                else if (row["WDay"].ToString() == "7")
                {
                    if (row["CStart"].ToString() != string.Empty)
                    {
                        schemaEdit.mtxtSobStart.Enabled = true;
                        schemaEdit.mtxtSobStop.Enabled = true;
                        schemaEdit.mtxtSobStart.Text = row["CStart"].ToString();//.Remove(5, 3);
                        schemaEdit.mtxtSobStop.Text = row["CStop"].ToString();//.Remove(5, 3);
                        schemaEdit.chbSob.Checked = true;
                    }
                    else
                    {
                        schemaEdit.mtxtSroStart.Enabled = false;
                        schemaEdit.mtxtSroStop.Enabled = false;
                        schemaEdit.chbSro.Checked = false;
                    }
                }
                else if (row["WDay"].ToString() == "1")
                {
                    if (row["CStart"].ToString() != string.Empty)
                    {
                        schemaEdit.mtxtNieStart.Enabled = true;
                        schemaEdit.mtxtNieStop.Enabled = true;
                        schemaEdit.mtxtNieStart.Text = row["CStart"].ToString();//.Remove(5, 3);
                        schemaEdit.mtxtNieStop.Text = row["CStop"].ToString();//.Remove(5, 3);
                        schemaEdit.chbNie.Checked = true;
                    }
                    else
                    {
                        schemaEdit.mtxtSroStart.Enabled = false;
                        schemaEdit.mtxtSroStop.Enabled = false;
                        schemaEdit.chbSro.Checked = false;
                    }
                }
            }

        }
        //Do może do helpera wywalę...
        private void WyczyscForm()
        {
            string def = "00:00";
            bool active = false;
            schemaEdit.mtxtPonStart.Text = def;
            schemaEdit.mtxtPonStop.Text = def;
            schemaEdit.mtxtWtoStart.Text = def;
            schemaEdit.mtxtWtoStop.Text = def;
            schemaEdit.mtxtSroStart.Text = def;
            schemaEdit.mtxtSroStop.Text = def;
            schemaEdit.mtxtCzwStart.Text = def;
            schemaEdit.mtxtCzwStop.Text = def;
            schemaEdit.mtxtPiaStart.Text = def;
            schemaEdit.mtxtPiaStop.Text = def;
            schemaEdit.mtxtSobStart.Text = def;
            schemaEdit.mtxtSobStop.Text = def;
            schemaEdit.mtxtNieStart.Text = def;
            schemaEdit.mtxtNieStop.Text = def;

            schemaEdit.mtxtPonStart.Enabled = active;
            schemaEdit.mtxtPonStop.Enabled = active;
            schemaEdit.mtxtWtoStart.Enabled = active;
            schemaEdit.mtxtWtoStop.Enabled = active;
            schemaEdit.mtxtSroStart.Enabled = active;
            schemaEdit.mtxtSroStop.Enabled = active;
            schemaEdit.mtxtCzwStart.Enabled = active;
            schemaEdit.mtxtCzwStop.Enabled = active;
            schemaEdit.mtxtPiaStart.Enabled = active;
            schemaEdit.mtxtPiaStop.Enabled = active;
            schemaEdit.mtxtSobStart.Enabled = active;
            schemaEdit.mtxtSobStop.Enabled = active;
            schemaEdit.mtxtNieStart.Enabled = active;
            schemaEdit.mtxtNieStop.Enabled = active;

            schemaEdit.chbPon.Checked = active;
            schemaEdit.chbWto.Checked = active;
            schemaEdit.chbSro.Checked = active;
            schemaEdit.chbCzw.Checked = active;
            schemaEdit.chbPia.Checked = active;
            schemaEdit.chbSob.Checked = active;
            schemaEdit.chbNie.Checked = active;
        }
    }
}
