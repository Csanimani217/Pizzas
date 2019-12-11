using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasEgyTabla.model
{
    class Futar
    {
        private int futarID;
        private string futarNev;
        private int futarTelefonszam;
        //konstruktor
        public Futar(int id, string name, int telszam)
        {
            this.futarID = id;
            this.futarNev = name;
            this.futarTelefonszam = telszam;
        }

        //set
        public void setID(int id)
        {
            this.futarID = id;
        }
        public void setName(string name)
        {
            this.futarNev = name;
        }
        public void setPrice(int price)
        {
            this.futarTelefonszam = price;
        }

        //get
        public int getId()
        {
            return futarID;
        }
        public string getNeme()
        {
            return futarNev;
        }
        public int getPrice()
        {
            return futarTelefonszam;
        }

        //public Futar(int futarID, string futarNev, int futarTelefonszam)
        {

        }
    }
}
