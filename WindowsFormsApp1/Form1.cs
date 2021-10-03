using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        usuario objUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objUsuario = new usuario();

            objUsuario.nombre = "luka06";
            objUsuario.contraseña = "messi10";
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            if ((objUsuario.nombre == "luka06") && (objUsuario.contraseña == "messi10"))
            {
                MessageBox.Show("Bienvenido " + objUsuario.nombre);
            } 
            else if ((objUsuario.nombre == "Luka06") && (objUsuario.contraseña != "messi10"))
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((objUsuario.nombre != "Luka06") && (objUsuario.contraseña == "messi10"))
            {
                MessageBox.Show("Nombre de usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((objUsuario.nombre != "Luka06") && (objUsuario.contraseña != "messi10"))
            {
                MessageBox.Show("Nombre de usuario y contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class usuario
    {
        public string nombre, contraseña;
    }
}
