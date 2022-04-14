using Enlace.conexion;
using Enlace.principal;
using Entidades.seguridad;
using Inventario.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.principal
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            FuncionesGenerales fun = new FuncionesGenerales();
            txtUsuario.Text = FuncionesGenerales.Encriptar("sa");
            if (fun.leerDatosConexion())
            {
                Conectar obj = new Conectar(Globales.CADENA_CONEXION);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validaUsuario(FuncionesGenerales.Encriptar(txtUsuario.Text), FuncionesGenerales.Encriptar(txtClave.Text)) == true)
            {
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.ShowDialog();//comentario de prueba
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecto!!");
            }
        }
        private Boolean validaUsuario(string user, string clave)
        {
            InicioSesion obj = new InicioSesion();
            Usuario us = obj.validarUsuario(user, clave);
            if (us != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}