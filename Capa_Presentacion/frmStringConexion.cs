using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;


namespace Capa_Presentacion
{
    public partial class frmStringConexion : Form
    {
        #region [INSTANCIAS]
        Gestiones logica;

        public Gestiones Logica { get => logica; set => logica = value; }
        #endregion

        #region [CONSTRUCT]
        public frmStringConexion(Gestiones log)
        {
            this.Logica = log;
            InitializeComponent();
        }
        #endregion

        #region [EVENTOS]
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnConexion_Click(object sender, EventArgs e)
        {
            if (txtBD.Text != "" && txtPass.Text != "" && txtPort.Text != "" && txtSever.Text != "" && txtUser.Text != "")
            {

                VerificarConexion();
            }
            else
            {
                MessageBox.Show("Falta parametros que rellenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            GererarConexionDB();
        }
        private void LblStatus_Click(object sender, EventArgs e)
        {
            desConectarBaseDatos();
        }


        #endregion

        #region [METODOS]
        private void VerificarConexion()
        {
            // MessageBox.Show(Logica.GenerarStringConexion(), "SCRIPT DE CONEXION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (btnConexion.Text != "Desconectar")
            {



                if (Logica.SetConnection(txtSever.Text, txtPort.Text, txtBD.Text, txtUser.Text, txtPass.Text) != false)
                {
                    MessageBox.Show("Se puede reealizar una conexion a " + txtBD.Text, "ESTADO DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener conexion, porfavor verifique bien los parametros.", "ESTADO DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGenerar.Enabled = false;
                }
            }
            else
            {
                desConectarBaseDatos();
            }
        }
        private void GererarConexionDB()
        {
            if (Logica.GetStatusConnection() != true)
            {
                Logica.ConnectMySql();
                MessageBox.Show("Conexion exitosa a " + txtBD.Text, "ESTADO DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnConexion.Image = Capa_Presentacion.Properties.Resources.appbar_disconnect;
                btnConexion.Text = "Desconectar";
            }
        }
        private void conectarBaseDatos()
        {
            Logica.ConnectMySql();
        }
        private void desConectarBaseDatos()
        {
            DialogResult cerrar = new DialogResult();
            if (Logica.GetStatusConnection() != false)
            {

                cerrar = MessageBox.Show("¿Desea cerrar la conexión a la base de datos?", "Estado de la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (cerrar == DialogResult.Yes)
                {
                    Logica.DisconnectMySql();
                    
                    btnConexion.Text = "Conectar";
                    btnConexion.Image = Capa_Presentacion.Properties.Resources.appbar_connect;
                }
            }
            else
            {
            }
            
        }
        #endregion
    }
}
