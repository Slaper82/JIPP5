using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCPCS.RCPTableAdapters;
using System.Windows.Forms;
using System.Data;

namespace RCPCS
{
    //Obsługa pracownika. Przypisywanie danych, tworzenie i edycja.
    class Pracownik
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool CzyKobieta { get; set; }
        public bool Active { get; set; }
        public int IdDept { get; set; }
        public string DeptName { get; set; }
        public int IdPriv { get; set; }
        public string PrivName { get; set; }

        private Main form;
        User_DataTableAdapter adapter;
        Department_NameTableAdapter department;
        User_addTableAdapter dodaj;
        HarmoUserShowTableAdapter harmonogram;
        User_ShowIdTableAdapter userid;
        LoginCheckTableAdapter login;

        public Pracownik()
        {
            adapter = new User_DataTableAdapter();
            department = new Department_NameTableAdapter();
            dodaj = new User_addTableAdapter();
            userid = new User_ShowIdTableAdapter();
            login = new LoginCheckTableAdapter();
        }
        public Pracownik(Main form)
        {
            adapter = new User_DataTableAdapter();
            department = new Department_NameTableAdapter();
            dodaj = new User_addTableAdapter();
            harmonogram = new HarmoUserShowTableAdapter();
            this.form = form;
        }

        public Pracownik(int IdUser,string Name,string Surname,bool CzyKobieta,bool Active,int IdDept,int IdPriv):this()
        {
            this.IdUser = IdUser;
            this.Name = Name;
            this.Surname = Surname;
            this.CzyKobieta = CzyKobieta;
            this.Active = Active;
            this.IdDept = IdDept;
            this.IdPriv = IdPriv;
        }
        public void PokazDaneUzytkownika(int IdUser)
        {
            this.CzyKobieta = true;
            DataTable dt=adapter.GetData(IdUser);
            DataTable dp = department.GetData(IdUser);
            this.IdUser= Convert.ToInt32(dt.Rows[0]["Id_User"].ToString());
            this.Name = dt.Rows[0]["Name"].ToString();
            this.Surname = dt.Rows[0]["Surname"].ToString();
            this.DeptName = dp.Rows[0]["Name"].ToString();
            this.PrivName = dp.Rows[0]["Nazwa"].ToString();
            this.CzyKobieta = Convert.ToBoolean(dp.Rows[0]["Kobieta"].ToString());          
        }
        public void PrzypiszDaneFormularzu()
        {
            form.txtDepartament.Text = this.DeptName;
            form.txtFunkcja.Text = this.PrivName;
            form.txtId.Text = this.IdUser.ToString();
            form.txtImie.Text = this.Name;
            form.txtNazwisko.Text = this.Surname;
            form.dgvHarmonogram.DataSource = harmonogram.GetData(IdUser);
            
            if (CzyKobieta)
            {
                form.rdbFemale.Checked = true;
                form.rdbMale.Checked = false;
            }
            else
            {
                form.rdbMale.Checked = true;
                form.rdbFemale.Checked = false;
            }
        }
        [Obsolete("Test czy działa")]
        public void WyczyscDaneFormularza()
        {
            form.txtDepartament.Text = "";
            form.txtFunkcja.Text = "";
            form.txtImie.Text = "";
            form.txtNazwisko.Text = "";
            form.txtId.Text = "";
            form.rdbFemale.Checked = false;
            form.rdbMale.Checked = false;
        }
        public void DodajPracownika(string Imie,string Nazwisko,bool Czykobieta,bool Active,int IdDept,int IdPriv,string login,string pass)
        {
            try
            {
               // bool Dod = false;
                DodajLogin(Imie, Nazwisko, login, pass);
                 dodaj.Insert(Imie, Nazwisko, Czykobieta, Active, IdDept, IdPriv);
                //return Dod;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
               // return false;
               
            }
        }
        public void AktualizujDanePracownika( int IdUser,string Name, string Surname,bool IsWoman, bool Active, string IdDept,string IdPriv)
        {   
                try
                {
                    adapter.UserUpdateData(
                        IdUser,
                        Name,
                        Surname,
                        IsWoman,
                        Active,
                        IdDept,
                        IdPriv
                        );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }
        public void UsunPracownika(int Id)
        {
           DialogResult Test= MessageBox.Show("Czy na pewno usunąć wybranego pracownika?","Uwaga",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (Test == DialogResult.Yes)
            {
                try
                {
                    userid.DeleteLogin(Id);
                    adapter.UserDelete(Id);
                    MessageBox.Show("Pracownik został usunięty");
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            
        }
        public bool SprawdzLogin(string Login)
        {

            if (login.GetData (Login).Rows.Count > 0) return false;
            else return true;
        }
        private void DodajLogin(string Name, string Surname,string Login, string Pass)
        {
            this.IdUser = OdczytajIdPracownika(Name, Surname);

            if (IdUser > 0)
            {
                if (SprawdzLogin(Login))
                {
                    try
                    {
                        adapter.LoginAdd(IdUser, Login, Pass);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else MessageBox.Show("Podany login już istnieje. Prosze podać inny login");
            }
        }
        private int OdczytajIdPracownika(string Name,string Surname)
        {
           
          //  string x = login.GetData(Name, Surname).Rows.Count.ToString();
           // string dupa= login.GetData(Name, Surname).Rows[0][0].ToString();
            int Id;
            if (userid.GetData(Name, Surname).Rows.Count > 0)
            {
                Id = Convert.ToInt32(userid.GetData(Name, Surname).Rows[0][0].ToString());
                return Id;
            }
            else return -1;
        }
        public void NadpiszLogin(int Id,string Login,string Pass)
        {
            try
            {
                userid.UpdateLogin(Login, Pass, Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
