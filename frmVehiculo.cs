using pryEtapa4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEtapa4
{
    public partial class frmVehiculo : Form
    {
        List<clsVehiculo> listaVehiculos = new List<clsVehiculo>();

        public frmVehiculo()
        {
            InitializeComponent();

            // Cargar imágenes de recursos
            Image imagenAuto = Resources.auto;
            Image imagenAvion = Resources.avion;
            Image imagenBarco = Resources.barco;

            // Crear vehículos y agregarlos a la lista
            listaVehiculos.Add(new clsVehiculo("Auto", "Terrestre", imagenAuto));
            listaVehiculos.Add(new clsVehiculo("Avión", "Aéreo", imagenAvion));
            listaVehiculos.Add(new clsVehiculo("Barco", "Marítimo", imagenBarco));

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            mostrarVehiculo(listaVehiculos[0]); // Mostrar información del auto
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            mostrarVehiculo(listaVehiculos[1]); // Mostrar información del avión
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            mostrarVehiculo(listaVehiculos[2]); // Mostrar información del barco
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarVehiculos();
        }

        // Método para mostrar la información de un vehículo
        private void mostrarVehiculo(clsVehiculo vehiculo)
        {
            lblNombreVehiculo.Text = vehiculo.nombreVehiculo;
            lblTipoVehiculo.Text = vehiculo.tipoVehiculo;
            pctVehiculo.Image = vehiculo.imagenVehiculo;
        }

        private void listarVehiculos()
        {
            // Limpiar la lista de elementos antes de mostrar la información actualizada
            lstVehiculos.Items.Clear();

            // Recorrer la lista de vehículos
            foreach (clsVehiculo vehiculo in listaVehiculos)
            {
                // Crear un nuevo elemento para la lista
                ListViewItem item = new ListViewItem(vehiculo.nombreVehiculo);
                // Establecer el índice de la imagen para el elemento
                // El índice de la imagen corresponde a la posición del vehículo en la lista
                item.ImageIndex = listaVehiculos.IndexOf(vehiculo);
                // Agregar el elemento a la lista de vehículos del formulario 
                lstVehiculos.Items.Add(item);
            }
        }
    }
}
