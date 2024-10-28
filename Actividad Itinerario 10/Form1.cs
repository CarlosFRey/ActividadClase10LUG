using BLL;
using BE;

namespace Actividad_Itinerario_10
{
    public partial class Form1 : Form
    {
        EmpleadoBLL empleadoBLL = new EmpleadoBLL();
        List<Empleado> lstEmpleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado newEmpleado = new Empleado();
                newEmpleado.ApellidoNombre = txtApellido.Text + ", " + txtNombre.Text;
                newEmpleado.DNI = Convert.ToInt32(txtDNI.Text);
                newEmpleado.SueldoBruto = Convert.ToDouble(txtSueldo.Text);
                lstEmpleados.Add(newEmpleado);
                txtCantidadEmpleadosLista.Text = lstEmpleados.Count.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { txtApellido.Clear(); txtDNI.Clear(); txtNombre.Clear(); txtSueldo.Clear(); }

        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                empleadoBLL.agregarEmpleados(lstEmpleados);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { lstEmpleados.Clear(); Listar(); txtCantidadEmpleadosLista.Text = lstEmpleados.Count.ToString(); }
           
        }
        private void Listar()
        {
            dgvEmpleados.DataSource = null;
            List<Empleado> lstEmpleados = new List<Empleado>();
            lstEmpleados = empleadoBLL.getEmpleados();
            dgvEmpleados.DataSource = lstEmpleados;
        }
    }
}
