using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kategorijaVozila
{
    class Vozila
    {
        public string model;
        public int god_proivodnje;
        public int br_kotaca;

        public string Model { get => model; set => model = value; }
        public int God_proivodnje { get => god_proivodnje; set => god_proivodnje = value; }
        public int Br_kotaca { get => br_kotaca; set => br_kotaca = value; }

        public Vozila(string model, int god_proivodnje, int br_kotaca)
        {
            this.model = model;
            this.god_proivodnje = god_proivodnje;
            this.br_kotaca = br_kotaca;
        }



        public override string ToString()
        {
            return "model: " + this.model
                + "\ngod proizvodnje: " + this.god_proivodnje
                + "\nbroj kotaca: " + this.br_kotaca;
        }
    }

    class Moticikl : Vozila
    {
        string kategorija = "Motocikl";
        public Moticikl(string model, int god_proizvodnje, int br_kotaca) : base(model, god_proizvodnje, br_kotaca)
        {
        }
            public override string ToString()
            {
                return kategorija;
            }
    }

    class Automobil : Vozila
    {
        string kategorija = "Automobil";
        public Automobil(string model, int god_proizvodnje, int br_kotaca) : base(model, god_proizvodnje, br_kotaca)
        {
            model = this.model;
        }
        public override string ToString()
        {
            return "model: " + this.model
                + "\ngod proizvodnje: " + this.god_proivodnje
                + "\nbroj kotaca: " + this.br_kotaca
                + "\nkategorija:" + kategorija;
        }
    }

    class Kamion : Vozila
    {
        string kategorija = "Kamion";
        public Kamion(string model, int god_proizvodnje, int br_kotaca) : base(model, god_proizvodnje, br_kotaca)
        {
        }
        public override string ToString()
        {
            return kategorija;
        }
    }
}
