using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinterface
{


    internal class Supervisor:Empleado
    {
        
        private Secretario secretario;
        private string despacho;
        private Coche coche;

        public Supervisor(string nombre, string apellido, int edad, string direccion, string dni, int antiguedad, string telefono, int salario, string despacho, Coche coche , Secretario secretario) 
            : base(nombre,
                   apellido,
                   edad,
                   direccion,
                   dni,
                   antiguedad,
                   telefono,
                   salario)
        {
            this.coche = coche; 
            this.despacho = despacho;
            this.secretario = secretario;
        }

        public void cambiarCoche(Coche coche)
        {
            this.coche = coche;
        }

        public void cambiarSecretario(Secretario secretario)
        {
            this.secretario = secretario;
        }


        public override void aumentarSalario()
        {
            var sal = this.getSalario();
            var aumento = (sal *= 1.2); 
            this.setSalario(aumento);
        }

        public string nombreSupervisor()
        {
            return this.getNombre();
        }

        public override string presentarse()
        {
            string secretarioNombre = "";

            if (this.secretario == null)
            {
                secretarioNombre = "No tengo secretario";
            }
            else
            {
                secretarioNombre = this.secretario.getNombre();
            }

            return (this.GetType().Name + ": " +
                 this.getNombre() + " " +
                 this.getApellido() + ", salario: "+
                 this.getSalario() + ".\nCoche: "  + 
                this.coche.mostrarDatos() + ".\nMi secretario es:" +
                secretarioNombre + "\n");
        }
    }

}
