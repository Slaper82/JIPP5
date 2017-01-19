using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCPCS.RCPTableAdapters;

namespace RCPCS.Klasy
{
    class Department
    {
        public int Dept_Id { get; set; }
        public string Nazwa { get; set; }

        Lista_DepartamentyTableAdapter ListAdapter;
        PrivTableAdapter DelAdapter;
        public Department()
        {
            ListAdapter = new Lista_DepartamentyTableAdapter();
            DelAdapter = new PrivTableAdapter();
        }
        public Department(int Id,string Name)
        {
            this.Dept_Id = Id;
            this.Nazwa = Name;
        }
         
        public void ZmianaNazwy(int Id,string Name)
        {
            ListAdapter.DepartmentRename(Id, Name);
        }
        public void Usuwanie(int Id)
        {
            DelAdapter.DepartmentDel(Id);
        }
    }
    
}
