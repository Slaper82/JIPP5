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
using RCPCS.Klasy;

namespace RCPCS
{
    public partial class frmZmianaDept : Form
    {
        PrivTableAdapter adapter;
        public event Clicked Aktualizuj;
        public frmZmianaDept()
        {
            InitializeComponent();
            adapter = new PrivTableAdapter();

        }

        private void frmZmianaDept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rCP.Lista_Departamenty' table. You can move, or remove it, as needed.
            this.lista_DepartamentyTableAdapter.Fill(this.rCP.Lista_Departamenty);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int Id = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            string Name = senderGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            Department zmiana = new Department();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex==3)
            {
                zmiana.Usuwanie(Id);
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 2)
            {
                frmZmianaNazw nowy = new frmZmianaNazw(Id,Name);
                nowy.ShowDialog();
            }
            Aktualizuj();
            frmZmianaDept_Load(this, e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
