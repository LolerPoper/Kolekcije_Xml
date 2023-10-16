using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kolekcije_Vozila_xml
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();

            for(int i = 1900; i <= DateTime.Now.Year; i++)
            {
                CmbGod.Items.Add(i);
            }
        }

        private void BtnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo vozilo = new Vozilo(TxtMod.Text, Convert.ToInt16(CmbGod.Text), Convert.ToInt16(CmbKot.Text));
                voziloList.Add(vozilo);
                TxtMod.Clear();
                CmbGod.Text = null;
                CmbKot.Text = null;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Greška " + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnObrada_Click(object sender, EventArgs e)
        {
            foreach (Vozilo v in voziloList) 
            {
                if(v.Kotaci == 2)
                {
                    v.Kategorija = "Motor";
                }

                if (v.Kotaci == 4)
                {
                    v.Kategorija = "Auto";
                }

                if (v.Kotaci > 4)
                {
                    v.Kategorija = "Kamion";
                }
            }
        }

        private void BtnIspis_Click(object sender, EventArgs e)
        {
            TxtIspis.Clear();

            foreach (Vozilo v in voziloList)
            {
                TxtIspis.AppendText(v.ToString());
            }
        }
    }
}
