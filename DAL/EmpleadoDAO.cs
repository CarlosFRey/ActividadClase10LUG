using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class EmpleadoDAO
    {
        public List<Empleado> getEmpleados()
        {
            List<Empleado> lstEmpleados = new List<Empleado>();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBAccess.GetDBConnection())) 
                {
                    string query = "SELECT APELLIDONOMBRE, DNI, SUELDOBRUTO FROM EMPLEADO";
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleado empleado = new Empleado();
                                empleado.ApellidoNombre = reader.GetString(0);
                                empleado.DNI = Convert.ToInt32(reader.GetInt32(1));
                                empleado.SueldoBruto = Convert.ToDouble(reader.GetDouble(2));
                                lstEmpleados.Add(empleado);
                            }
                        }
                    }
                }
                return lstEmpleados;
            }
            catch (Exception ex) { throw; }
        }

        public void agregarEmpleados(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    connection.Open();
                    string query = "INSERT INTO EMPLEADO (APELLIDONOMBRE, DNI, SUELDOBRUTO) VALUES (@ApellidoNombre, @DNI, @SueldoBruto)";
                    /*foreach (Empleado empleado in lstEmpleados)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ApellidoNombre", empleado.ApellidoNombre);
                            cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                            cmd.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);
                            cmd.ExecuteNonQuery();
                        }
                    }*/
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApellidoNombre", empleado.ApellidoNombre);
                        cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                        cmd.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
