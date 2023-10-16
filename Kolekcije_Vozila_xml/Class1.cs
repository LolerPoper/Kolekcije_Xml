using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_Vozila_xml
{
    internal class Vozilo
    {
        string model, kategorija;
        int godProiz, kotaci;

        public string Model { get => model; set => model = value; }
        public int GodProiz { get => godProiz; set => godProiz = value; }
        public int Kotaci { get => kotaci; set => kotaci = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }

        public Vozilo() { }

        public Vozilo(string model, int godProiz, int kotaci)
        {
            this.Model = model;
            this.GodProiz = godProiz;
            this.Kotaci = kotaci;
        }

        public override string ToString()
        {
            return "Model: " + this.Model + "\r\tGodina proizvodnje: " + this.GodProiz + "\r\tKategorija: " + this.Kategorija + "\r\n";
        }
    }
}
