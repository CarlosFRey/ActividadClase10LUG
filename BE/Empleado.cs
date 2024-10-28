using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Empleado
    {
        public string ApellidoNombre {  get; set; }
        public int DNI {  get; set; }
        public double SueldoBruto { get; set; }

        public double CalcularSueldoNeto(Empleado empleado)
        {
            return empleado.SueldoBruto * 0.87;
        }
    }
}
