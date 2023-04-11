using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using CapaEntidades;

namespace Capa_Presentación
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            
        }
        private void frm_closing(object sender, FormClosingEventArgs e){
            this.Show();
            clave.Text = "";
            usuarioDoc.Text = "";
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<usuarios> TEST = new usuario_CN().Listar();

            usuarios ousuario = new usuario_CN().Listar().Where(u => u.id_usuario ==  Convert.ToInt32(usuarioDoc.Text) &&  u.clave == clave.Text).FirstOrDefault();


            if (ousuario != null)
            {
                Inicio form = new Inicio();
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

            }
            else
            {
                MessageBox.Show("No se encontro el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
