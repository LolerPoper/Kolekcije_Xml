using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_Vozila_xml
{
    internal class Vozilo
    {
        string model;
        int godProiz, kotaci;

        public string Model { get => model; set => model = value; }
        public int GodProiz { get => godProiz; set => godProiz = value; }
        public int Kotaci { get => kotaci; set => kotaci = value; }

        public Vozilo() { }

        public Vozilo(string model, int godProiz, int kotaci)
        {
            Model= model;
            GodProiz = godProiz;
            Kotaci = kotaci;
        }
    }

    internal class Auto : Vozilo
    {
        public Auto() { }

        public Auto(string model, int godProiz, int kotaci)
        {
            Model = model;
            GodProiz = godProiz;
            Kotaci = kotaci;
        }
    }

    internal class Motor : Vozilo
    {
        public Motor() { }

        public Motor(string model, int godProiz, int kotaci)
        {
            Model = model;
            GodProiz = godProiz;
            Kotaci = kotaci;
        }
    }

    internal class Kamion: Vozilo
    {
        public Kamion() { }

        public Kamion(string model, int godProiz, int kotaci)
        {
            Model = model;
            GodProiz = godProiz;
            Kotaci = kotaci;
        }
    }
}
