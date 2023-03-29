using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinterface
{
    internal class Empleado {

        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string direccion;
        protected string dni;
        protected int antiguedad;
        protected int anioNacimiento;
        protected string telefono;
        protected double  salario;
        protected Supervisor supervisor;


        public Empleado(string nombre, string apellido, int edad, string direccion,
            string dni, int antiguedad, string telefono, int salario ,int anioNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.direccion = direccion;
            this.dni = dni;
            this.antiguedad = antiguedad;
            this.telefono = telefono;
            this.salario = salario;
            this.anioNacimiento = anioNacimiento;
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

            var por = (this.antiguedad * 0.01); //año antiguedad

           this.salario *= 1.1; //incremento 10%

            if(por > 0) { 
           this.salario *= ( 1+  por);
            }

            if (this.anioNacimiento <= 1964)
            {
                this.salario *= 1.05; //si pasa el if aumenta un 5%

            }
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

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

     

    }
    
}
