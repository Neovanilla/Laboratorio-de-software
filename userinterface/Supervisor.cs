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
      
        private List<Empleado> empleados = new List<Empleado>();

        public Supervisor(string nombre, string apellido, int edad, string direccion, string dni, int antiguedad, string telefono, int salario, int anioNacimiento, string despacho, Coche coche , Secretario secretario) 
            : base(nombre,
                   apellido,
                   edad,
                   direccion,
                   dni,
                   antiguedad,
                   telefono,
                   salario,
                   anioNacimiento)
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
            var por = (this.getAntiguedad() * 0.01);
            this.salario *=  (1 + por);
            Console.WriteLine(this.salario);
      
            this.salario *= 1.2;
            Console.WriteLine(this.salario);
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

        public void agregarEmpleados(Empleado empleado)
        {
            this.empleados.Add(empleado);
        }


    }

}
