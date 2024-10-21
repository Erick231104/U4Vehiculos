using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo
{
    public partial class Form1 : Form
    {
        private GestionVehiculos gestionVehiculos = new GestionVehiculos();
        private AccionesVehiculos accionesVehiculo = new AccionesVehiculos();
        private Vehiculo vehiculoSeleccionado;

        public Form1()
        {
            InitializeComponent();
            // Configuración inicial de la interfaz.
            cmbTipoVehiculo.Items.AddRange(new string[] { "Auto", "Camión", "Motocicleta", "Vehículo Eléctrico" });
            // Oculta todos los campos inicialmente
            OcultarCampos();
            lstVehiculo.DataSource = new BindingList<Vehiculo>(gestionVehiculos.OntenerVehiculo());
            lstVehiculo.DisplayMember = "Marca"; // Cambiar si necesitas mostrar más información
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarCampos(); // Oculta todos los campos primero
            switch (cmbTipoVehiculo.SelectedItem.ToString())
            {
                case "Camión":
                    txtCapacidadCarga.Visible = true; // Muestra el campo de capacidad de carga
                    break;
                case "Vehículo Eléctrico":
                    txtCapacidadBateria.Visible = true; // Muestra el campo de capacidad de batería
                    break;
                case "Auto":
                case "Motocicleta":
                    // No se necesita mostrar más campos, solo marca y modelo
                    break;
            }
        }

        private void OcultarCampos()
        {
            txtCapacidadCarga.Visible = false; // Oculta el campo de capacidad de carga
            txtCapacidadBateria.Visible = false; // Oculta el campo de capacidad de batería
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = null;

            if (cmbTipoVehiculo.SelectedItem.ToString() == "Auto")
            {
                nuevoVehiculo = new Auto { Marca = txtMarca.Text, Modelo = txtModelo.Text };
            }
            else if (cmbTipoVehiculo.SelectedItem.ToString() == "Camión")
            {
                nuevoVehiculo = new Camion
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    CapacidadCarga = int.Parse(txtCapacidadCarga.Text)
                };
            }
            else if (cmbTipoVehiculo.SelectedItem.ToString() == "Vehículo Eléctrico")
            {
                nuevoVehiculo = new VehiculoElectrico
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    CapacidadBateria = int.Parse(txtCapacidadBateria.Text)
                };
            }
            else // Motocicleta
            {
                nuevoVehiculo = new Motocicleta { Marca = txtMarca.Text, Modelo = txtModelo.Text };
            }

            gestionVehiculos.AgregarVehiculo(nuevoVehiculo);
            ActualizarListaVehiculos();
            MessageBox.Show("Vehículo agregado correctamente.");
        }

        private void ActualizarListaVehiculos()
        {
            lstVehiculo.DataSource = new BindingList<Vehiculo>(gestionVehiculos.OntenerVehiculo());
        }

        private void lstVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehiculoSeleccionado = lstVehiculo.SelectedItem as Vehiculo;
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                accionesVehiculo.MoverVehiculo(vehiculoSeleccionado);
                MessageBox.Show("Vehículo movido.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo.");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(vehiculoSeleccionado != null)
        {
                accionesVehiculo.IniciarVehiculo(vehiculoSeleccionado);
                MessageBox.Show("Vehículo iniciado.");
            }
        else
            {
                MessageBox.Show("Por favor, selecciona un vehículo.");
            }
        }

        private void btnDetner_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                accionesVehiculo.DetenerVehiculo(vehiculoSeleccionado);
                MessageBox.Show("Vehículo detenido.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo.");
            }
        }

        private void btnCargarBateria_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                try
                {
                    accionesVehiculo.CargarBateria(vehiculoSeleccionado);
                    MessageBox.Show("Batería cargada.");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo eléctrico.");
            }
        }
    }
    }
    
}
