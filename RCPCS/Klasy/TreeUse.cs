using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPCS.RCPTableAdapters;
using System.Data;
using System.Data.SqlClient;

namespace RCPCS
{
    class TreeUse
    {
        private TreeView DrzewoDep { get; set; }
        private ImageList Ikonki { get; set; }
        Lista_DepartamentyTableAdapter dept;
        UsersDepartamentyTableAdapter users;
        
        public TreeUse(TreeView Drzewo,ImageList Ikonki)
        {
            this.DrzewoDep = Drzewo;
            this.Ikonki = Ikonki;
            dept = new Lista_DepartamentyTableAdapter();
            users = new UsersDepartamentyTableAdapter();
            
        }
        public void WypelnijDrzewo()
        {
            DataTable dt = dept.GetData();
            TreeNode parentNode;
            foreach(DataRow row in dt.Rows)
            {
                parentNode = DrzewoDep.Nodes.Add(row["Name"].ToString());
                parentNode.Tag = "Department";
                parentNode.SelectedImageIndex = 0;
                DodajPracownika(Convert.ToInt32((row["Id_Department"]).ToString()), parentNode);//Jeśli istnieje user z id departamentu to dodaje go do drzewka
                
            }
            DrzewoDep.ImageList = Ikonki;
            
            DrzewoDep.SelectedImageIndex = 0;
            DrzewoDep.ExpandAll();
        }
        private void DodajPracownika(int parentId, TreeNode parentNode)
        {
            DataTable dt = users.GetData(parentId);
            TreeNode childNode;
            foreach(DataRow dr in dt.Rows)
            {
                var active = Convert.ToBoolean(dr["Active"].ToString());
                if (active)
                {
                    childNode = parentNode.Nodes.Add(dr["Name"].ToString() + " " + dr["Surname"].ToString());
                    childNode.Tag = dr["Id_User"].ToString();
                    childNode.SelectedImageIndex = 1;
                    childNode.ImageIndex = 1;
                }
            }
        }

    }
}
