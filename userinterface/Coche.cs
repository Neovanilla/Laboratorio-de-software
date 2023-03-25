using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinterface
{
    internal class Coche
    {
        private string matricula;
        private string marca;
        private string modelo;

        public Coche (string matricula, string marca, string modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string getmatricula()
        {
            return matricula;
        }
        public string getmarca() { 
                return marca;
        }    

        public string getmodelo()
        {
            return modelo;
        }

        public string mostrarDatos()
        {
            return (  this.getmatricula() + ", " + this.getmarca() + " " + this.getmodelo());
        }


    }
}
