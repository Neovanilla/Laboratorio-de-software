using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinterface
{
    internal class Secretario : Empleado
    {
        public Secretario(string nombre, string apellido, int edad, string direccion, string dni, int antiguedad, string telefono, int salario, int anioNacimiento) : 
            base(nombre, apellido, edad, direccion, dni, antiguedad, telefono, salario,anioNacimiento)
        {
        }
    }
}
