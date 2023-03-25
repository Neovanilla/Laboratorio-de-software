using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinterface
{
    internal class Empleado {

        private string nombre;
        private string apellido;
        private int edad;
        private string direccion;
        private string dni;
        private int antiguedad;
        private string telefono;
        private double  salario;
        private Supervisor supervisor;


        public Empleado(string nombre, string apellido, int edad, string direccion,
            string dni, int antiguedad, string telefono, int salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.direccion = direccion;
            this.dni = dni;
            this.antiguedad = antiguedad;
            this.telefono = telefono;
            this.salario = salario;
        }

        public virtual string presentarse()
        {
             string supervisorNombre = "";

            if(this.supervisor == null)
            {
                supervisorNombre = "No tengo supervisor";
            }
            else
            {
                supervisorNombre = this.supervisor.getNombre();
            }

              return (this.GetType().Name+ ": " +
                 this.getNombre() + ", " +
                 this.getApellido() + ", salario:  " +
                 (int)Math.Round(this.getSalario())+ ".\nMi supervisor es: " +
                 supervisorNombre +"\n");
        }

        public virtual void aumentarSalario()
        {
            this.salario *= 1.1;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public double getSalario()
        {
            return this.salario;
        }

        protected void setSalario(double salario)
        {
            this.salario = salario;
        }

        public void cambiarSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
        }

     

    }
    
}
