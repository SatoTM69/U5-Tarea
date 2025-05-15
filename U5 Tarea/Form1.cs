using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Tarea
{
    public partial class Form1 : Form
    {
        private string rutaBusqueda = @"C:\Users\abner\source\repos\U5 Tarea\U5 Tarea\nia";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBoxArchivos.Items.Clear();
            richTextBoxContenido.Clear();

            string textoBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor escribe una parte del nombre del archivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(rutaBusqueda))
            {
                MessageBox.Show("La carpeta especificada no existe: " + rutaBusqueda, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] archivos = Directory.GetFiles(rutaBusqueda, $"{textoBusqueda}*.txt");

            if (archivos.Length == 0)
            {
                MessageBox.Show("No se encontraron archivos que coincidan.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (string archivo in archivos)
            {
                listBoxArchivos.Items.Add(Path.GetFileName(archivo));
            }
        }

        private void listBoxArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArchivos.SelectedItem == null) return;

            string archivoSeleccionado = listBoxArchivos.SelectedItem.ToString();
            string rutaCompleta = Path.Combine(rutaBusqueda, archivoSeleccionado);

            try
            {
                string contenido = File.ReadAllText(rutaCompleta);
                richTextBoxContenido.Text = contenido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
