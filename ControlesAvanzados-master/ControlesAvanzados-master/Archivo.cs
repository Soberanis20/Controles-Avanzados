using ControlesAvanzados.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesAvanzados
{
    public partial class Archivo : Form
    {
        List<Venta> ventas = new List<Venta>();
        public Archivo()
        {
            InitializeComponent();
            agregarVentas();
            mostrarVentas();
            inicializarListBox();
            inicializarComboBoxAnios();
            inicializarComboBoxMeses();

            comboBoxAnios.SelectedIndexChanged += comboBoxAnios_SelectedIndexChanged;
            comboBoxMeses.SelectedIndexChanged += comboBoxMeses_SelectedIndexChanged;

        }

        private void agregarVentas()
        {
            
            ventas.Add(new Venta(2024, 1, "Guatemala", 100000));
            ventas.Add(new Venta(2024, 2, "Guatemala", 80000));
            ventas.Add(new Venta(2024, 3, "Guatemala", 95000));
            ventas.Add(new Venta(2024, 4, "Guatemala", 120000));
            ventas.Add(new Venta(2024, 5, "Guatemala", 100000));
            ventas.Add(new Venta(2024, 6, "Guatemala", 110000));
            ventas.Add(new Venta(2024, 1, "Jutiapa", 50000));
            ventas.Add(new Venta(2024, 2, "Jutiapa", 80000));
            ventas.Add(new Venta(2024, 3, "Jutiapa", 67000));
            ventas.Add(new Venta(2024, 4, "Jutiapa", 55000));
            ventas.Add(new Venta(2024, 5, "Jutiapa", 67000));
            ventas.Add(new Venta(2024, 6, "Jutiapa", 45000));
            ventas.Add(new Venta(2024, 1, "Chiquimula", 43000));
            ventas.Add(new Venta(2024, 2, "Chiquimula", 55000));
            ventas.Add(new Venta(2024, 3, "Chiquimula", 23000));
            ventas.Add(new Venta(2024, 4, "Chiquimula", 34000));
            ventas.Add(new Venta(2024, 5, "Chiquimula", 56000));
            ventas.Add(new Venta(2024, 6, "Chiquimula", 78000));
            ventas.Add(new Venta(2024, 1, "Escuintla", 86000));
            ventas.Add(new Venta(2024, 2, "Escuintla", 75000));
            ventas.Add(new Venta(2024, 3, "Escuintla", 64000));
            ventas.Add(new Venta(2024, 4, "Escuintla", 78000));
            ventas.Add(new Venta(2024, 5, "Escuintla", 79000));
            ventas.Add(new Venta(2024, 6, "Escuintla", 90000));
            ventas.Add(new Venta(2024, 6, "Zacapa", 10000));
        }

        private void mostrarVentas()
        {
            listadoVentas.Controls.Clear();
            
            string departamentoSeleccionado = selectorDepartamento.SelectedItems.Count > 0 ? selectorDepartamento.SelectedItem.ToString() : null;
            int anioSeleccionado = comboBoxAnios.SelectedItem != null && comboBoxAnios.SelectedItem.ToString() != "Todos" ? (int)comboBoxAnios.SelectedItem : 0;
            string mesSeleccionado = comboBoxMeses.SelectedItem != null && comboBoxMeses.SelectedItem.ToString() != "Todos" ? comboBoxMeses.SelectedItem.ToString()
        : null;

            foreach (Venta venta in ventas)
            {
                string nombreMesVenta = obtenerNombreMesPorNumero(venta.Mes);

                if ((departamentoSeleccionado == null || departamentoSeleccionado == venta.Departamento) &&
                    (anioSeleccionado == 0 || anioSeleccionado == venta.Anio) &&
                    (mesSeleccionado == null || mesSeleccionado == nombreMesVenta))
                {
                    Label labelVenta = crearEqituetaVenta(venta);
                    listadoVentas.Controls.Add(labelVenta);
                    
                }
            }

        }

        private void inicializarListBox()
        {
            List<string> departamentos = new List<string>();
            foreach (Venta venta in ventas)
            {
                if (!departamentos.Contains(venta.Departamento))
                {
                    departamentos.Add(venta.Departamento);
                }
            }
            foreach (string departamento in departamentos)
            {
                selectorDepartamento.Items.Add(departamento);
            }
        }

        private void inicializarComboBoxAnios()
        {
            comboBoxAnios.Items.Clear();

            comboBoxAnios.Items.Add("Todos");
            List<int> anios = new List<int>();
            foreach (Venta venta in ventas)
            {
                if (!anios.Contains(venta.Anio))
                {
                    anios.Add(venta.Anio);
                }
            }
            foreach (int anio in anios)
            {
                comboBoxAnios.Items.Add(anio);
            }

            comboBoxAnios.SelectedIndex = 0;
        }

        private void inicializarComboBoxMeses()
        {
            comboBoxMeses.Items.Clear();

            comboBoxMeses.Items.Add("Todos");

            List<string> meses = new List<string>();
            foreach (Venta venta in ventas)
            {
                string nombreMes = obtenerNombreMesPorNumero(venta.Mes);
                if (!meses.Contains(nombreMes))
                {
                    meses.Add(nombreMes);
                }
            }
            foreach (string mes in meses)
            {
                comboBoxMeses.Items.Add(mes);
            }

            comboBoxMeses.SelectedIndex = 0;
        }

        private string obtenerNombreMesPorNumero(int numeroMes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[numeroMes - 1];
        }

        private Label crearEqituetaVenta(Venta venta)
        {
            Label labelVenta = new Label();
            labelVenta.Text = $"Año: {venta.Anio} \n Mes: {obtenerNombreMesPorNumero(venta.Mes)} \n Departamento: {venta.Departamento} \n Ventas: Q.{(venta.Ventas).ToString("N", new CultureInfo("es-GT"))}";
            labelVenta.AutoSize = true;
            labelVenta.Font = new Font("Arial", 10, FontStyle.Bold);
            labelVenta.Padding = new Padding(10);
            labelVenta.BorderStyle = BorderStyle.FixedSingle;
            labelVenta.Margin = new Padding(10);
            labelVenta.BackColor = Color.LightGray;
            labelVenta.AutoSize = false;
            labelVenta.Width = 247;
            labelVenta.Height = 95;
            return labelVenta;
        }

        private void selectorDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            mostrarVentas();

        }
        private void comboBoxAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarVentas();
        }

        private void comboBoxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarVentas();
        }

        private void panelAdd(object sender, ControlEventArgs e)
        {
            
        }
    }
}