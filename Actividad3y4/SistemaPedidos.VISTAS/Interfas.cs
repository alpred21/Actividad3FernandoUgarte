using SistemaPedidos.VISTAS.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos.VISTAS
{
    public partial class Interfas : Form
    {
        public Interfas()
        {
            InitializeComponent();
        }

        private Form formactivo = null;
        private void abrirform(Form formhijo)
        {
            if (formactivo != null)
                formactivo.Close();
            formactivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panelcargarform.Controls.Add(formhijo);
            panelcargarform.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonpersona_Click(object sender, EventArgs e)
        {
            abrirform(new ClienteListarVista());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
