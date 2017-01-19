using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPCS.RCPTableAdapters;
using System.Data;

namespace RCPCS
{
    //Klasa helper potrzebna jest do zadań typu odświerz główny formularz, drzewo, DGV itd. 
    //Przydaje się też do wrzucania zadań nie pasujących nigdzie indziej.
    class Helper
    {
        private TreeView treeView;
        private ImageList Ikonki;
        private frmSchemat Schemat;
        private string CzasDeflt = "00:00";
        public struct Podsumowania
        {
            public string   Odczytane { get; set; }
            public string Norma { get; set; }
            public string Braki { get; set; }
            public string Nadgodziny { get; set; }
        }
        public Helper(frmSchemat Schemat)
        {
            this.Schemat = Schemat;
        }
        public void UstawieniaFormularza()
        {

        }
        public Helper(TreeView Drz,ImageList Ikonki)
        {
            this.treeView = Drz;
            this.Ikonki = Ikonki;
        }
        public void Odswierz()
        {
           treeView.Nodes.Clear();
           TreeUse drzewo = new TreeUse(treeView,Ikonki);
           drzewo.WypelnijDrzewo();
        }
        public void OdswierzHarmo(DataGridView Harmo,int UserId)
        {
            HarmoUserShowTableAdapter tt = new HarmoUserShowTableAdapter();
            Harmo.DataSource= tt.GetData(UserId);
        }
        public List<Podsumowania> Test(int Id,string Start,string Stop)
        {
            RcpPodsumowaniaTableAdapter rcpta = new RcpPodsumowaniaTableAdapter();
            return rcpta.GetData(Id, Start, Stop).Rows.Cast<DataRow>().Select(row =>
                new Podsumowania()
                {
                    Norma = Convert.ToString(row["Norma"]),
                    Odczytane = Convert.ToString(row["Odczytane"]),
                    Nadgodziny = Convert.ToString(row["Nadgodziny"]),
                    Braki = Convert.ToString(row["Braki"]),
                    //City = (string)row["miasto"],
                }).ToList();
        }
        public void PrzeliczDaneRCP(DataGridView Rcp,Label norma,Label odczyty,Label Nadgodziny,Label Braki,int Id,string Start,string Stop)
        {
        
        Rcp.DataSource = null;
            Rcp.Update();
            Rcp.Refresh();
            PokazDaneRcpTableAdapter ta = new PokazDaneRcpTableAdapter();
            RcpPodsumowaniaTableAdapter rcpta = new RcpPodsumowaniaTableAdapter();
            Rcp.DataSource = ta.GetData(Id, Start, Stop);
            List<Podsumowania> test = Test(Id, Start, Stop);
            norma.Text=test[0].Norma.ToString();
            odczyty.Text = test[0].Odczytane.ToString();
            Nadgodziny.Text = test[0].Nadgodziny.ToString();
            Braki.Text = test[0].Braki.ToString();


            //       test=  rcpta.GetData(Id, Start, Stop).Rows.Cast<DataRow>().Select(row =>
            //new Podsumowania()
            //{
            //    Norma = Convert.ToString(row["Norma"]),
            //    Odczytane = Convert.ToString(row["Odczytane"]),
            //    Nadgodziny = Convert.ToString(row["Nadgodziny"]),
            //    Braki = Convert.ToString(row["Braki"]),
            //    //City = (string)row["miasto"],
            //        }).ToList();
            // p.IdUser=
            //test = ta.GetData(Id, Start, Stop);
            // test  = ta.Podsumowania(Id, Start, Stop);


        }
        public string PokazNorme(int Id, string Start, string Stop)
        {
          //  PokazDaneRcpTableAdapter ta = new
            NormaOkresTableAdapter norma = new NormaOkresTableAdapter();
            string test = norma.GetData(Id, Start, Stop).Rows[0][0].ToString();
            if (test != string.Empty)
            {
                string[] tmp = test.Split(':');
                return tmp[0] + ":" + tmp[1];
            }
            else return CzasDeflt;
        }
        public string PokazOczyty(int Id, string Start, string Stop)
        {
            NormaOkresTableAdapter norma = new NormaOkresTableAdapter();
            //
            string test = norma.Odczyt(Id, Start, Stop).Rows[0][1].ToString();
            if (test != string.Empty)
            {
                string[] tmp = test.Split(':');
                return tmp[0] + ":" + tmp[1];
            }
            else return CzasDeflt;
            //return norma.Odczyt(Id, Start, Stop).Rows[0][1].ToString();
        }
        public string PokazBraki(int Id, string Start, string Stop)
        {
            NormaOkresTableAdapter norma = new NormaOkresTableAdapter();
            string test = norma.Braki(Id, Start, Stop).Rows[0][1].ToString();
            if (test != string.Empty)
            {
                // return norma.Braki(Id, Start, Stop).Rows[0][1].ToString();
                string[] tmp = test.Split(':');
                return tmp[0] + ":" + tmp[1];
            }
            else return CzasDeflt;
        }
        public string PokazNadgodz(int Id, string Start, string Stop)
        {
            NormaOkresTableAdapter norma = new NormaOkresTableAdapter();
            string test = norma.Nadgodz(Id, Start, Stop).Rows[0][1].ToString();
            if (test != string.Empty)
            {
                string[] tmp = test.Split(':');
                return tmp[0] + ":" + tmp[1];
            }
            else return CzasDeflt;
            //return norma.Nadgodz(Id, Start, Stop).Rows[0][1].ToString();
        }
    }
}
