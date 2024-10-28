using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BE;
using DAL;

namespace BLL
{
    public class EmpleadoBLL
    {
        EmpleadoDAO EmpleadoDAO = new EmpleadoDAO();
        public List<Empleado> getEmpleados()
        {
            return EmpleadoDAO.getEmpleados();
        }

        public void agregarEmpleados(List<Empleado> lista)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    int i = 0;
                    foreach (Empleado empleado in lista)
                    {
                        i++;
                        if (empleado.ApellidoNombre == string.Empty) { throw new Exception("el empleado número " + i + " a ingresar tiene un error en el Nombre o Apellido, no debe estar vacio"); }
                        if (empleado.DNI.ToString().Length != 8) { throw new Exception("el empleado número " + i + " a ingresar tiene un error en el DNI, debe tener 8 caracteres"); }
                        if (empleado.SueldoBruto < 100000) { throw new Exception("el empleado número " + i + " a ingresar tiene un error en el Sueldo Bruto, debe ser mayor a $100.000"); }
                        EmpleadoDAO.agregarEmpleados(empleado);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
