using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCPCS.RCPTableAdapters;
using System.Windows.Forms;

namespace RCPCS.Klasy
{
    class Harmonogram
    {
        public int UserId { get; set; }
        public int SchemaId { get; set; }


        rcpUserHarmoTableAdapter adapter;

        public Harmonogram()
        {
            adapter = new rcpUserHarmoTableAdapter();
        }
        public void DodajHarmonogram(int UserId,int SchemaId,string Start,string Stop)
        {
            try
            {
                adapter.HarmoUserAdd(UserId, SchemaId, Start, Stop);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void EdytujHarmonogram(int IdHarmo,string Start,string Stop)
        {
            try
            {
                adapter.HarmoUserEdit( Start, Stop, IdHarmo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void UsunHarmonogram(int Id,string NazwaSchematu)
        {
            try
            {
                adapter.HarmoUserDelete(Id, NazwaSchematu);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
