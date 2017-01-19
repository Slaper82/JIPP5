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
    public partial class frmZmiana : Form
    {
        public event Clicked Zmieniono;
        public event Zapisano Zapisz;
        private TextBox txtDoZmiany;
        public frmZmiana(TextBox txtChange)
        {
            InitializeComponent();
            this.txtDoZmiany = txtChange;
        }

        private void btnWybierz_Click(object sender, EventArgs e)
        {
            txtDoZmiany.Text = cmbWybor.Text;
            Zmieniono();
           if(Zapisz!=null) Zapisz(this,e);
            this.Close();
        }
    }
}
