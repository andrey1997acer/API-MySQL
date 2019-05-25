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

    public partial class frmPrincipal : Form
    {
        #region [INSTANCIAS]
        Gestiones logica = new Gestiones();
        frmStringConexion stringConecction;
        frmSQL_Dinamico sqlDinamico;
        frmDatos_Generales datosGenerales;
        frmProcedimientos procedimientos;


        //PASO 1: declarar como globales
        public int xClick = 0, yClick = 0;

        public Gestiones Logica { get => logica; set => logica = value; }
        #endregion

        #region [CONSTRUCT]
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region [EVENTOS]
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMinimizar.Visible = true;
            btnMaximizar.Visible = false;
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void BtnDatosGenerales_Click(object sender, EventArgs e)
        {
            if (Logica.GetStatusConnection())
            {
                AbrirFormulario(datosGenerales,btnDatosGenerales);
            }
            else
            {
                DialogResult form = MessageBox.Show("No esta activa la base de datos.", "Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (form == DialogResult.OK)
                {
                    AbrirFormulario(stringConecction,btnStringConexion);
                }

            }
           
           
        }
        private void BtnStringConexion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(stringConecction,btnStringConexion);
        }
        private void PnBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }

        }
        private void BtnSqlDinamico_Click(object sender, EventArgs e)
        {
            if (Logica.GetStatusConnection())
            {
                AbrirFormulario(sqlDinamico,btnSqlDinamico);
            }
            else
            {
                DialogResult form = MessageBox.Show("No esta activa la base de datos.", "Connection",
                    MessageBoxButtons.OK,MessageBoxIcon.Hand);
                if(form == DialogResult.OK)
                {
                    AbrirFormulario(stringConecction,btnStringConexion);
                }

            }

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            stringConecction = new frmStringConexion(Logica);
            sqlDinamico = new frmSQL_Dinamico(Logica);
            datosGenerales = new frmDatos_Generales(this,Logica,sqlDinamico,btnSqlDinamico);
            procedimientos = new frmProcedimientos(Logica);
         


        }
        private void BtnProcedimientos_Click(object sender, EventArgs e)
        {
            
            
            if (Logica.GetStatusConnection())
            {
                AbrirFormulario(procedimientos,btnProcedimientos);
            }
            else
            {
                DialogResult form = MessageBox.Show("No esta activa la base de datos.", "Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (form == DialogResult.OK)
                {
                    AbrirFormulario(stringConecction,btnStringConexion);
                }

            }
        }
        private void PnLogo_Click(object sender, EventArgs e)
        {
            if (this.pnFormularios.Controls.Count > 0)
                this.pnFormularios.Controls.RemoveAt(0);
            this.pnFormularios.Controls.Add(pnImagenLOGO);
            //btnStringConexion.FlatAppearance.BorderSize = 0;
            btnStringConexion.Width = 247;
            btnStringConexion.BackColor = Color.FromArgb(70, 70, 69);
            // btnDatosGenerales.FlatAppearance.BorderSize = 0;
            btnDatosGenerales.Width = 247;
            btnDatosGenerales.BackColor = Color.FromArgb(70, 70, 69);
            // btnProcedimientos.FlatAppearance.BorderSize = 0;
            btnProcedimientos.Width = 247;
            btnProcedimientos.BackColor = Color.FromArgb(70, 70, 69);
            // btnSqlDinamico.FlatAppearance.BorderSize = 0;
            btnSqlDinamico.Width = 247;
            btnSqlDinamico.BackColor = Color.FromArgb(70, 70, 69);
            // boton.FlatAppearance.BorderSize = 1;
        }
        #endregion

        #region [METODOS]
        public void AbrirFormulario(Object obj, Button boton)        //Abrir Formularios de forma dinamica
        {
            Form hijo1 = obj as Form;
            if (this.pnFormularios.Controls.Count > 0)
                this.pnFormularios.Controls.RemoveAt(0);
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnFormularios.Controls.Add(hijo1);
            this.pnFormularios.Tag = hijo1;
            hijo1.Show();

            //btnStringConexion.FlatAppearance.BorderSize = 0;
            btnStringConexion.Width = 247;
            btnStringConexion.BackColor = Color.FromArgb(70, 70, 69);
           // btnDatosGenerales.FlatAppearance.BorderSize = 0;
            btnDatosGenerales.Width = 247;
            btnDatosGenerales.BackColor = Color.FromArgb(70, 70, 69);
           // btnProcedimientos.FlatAppearance.BorderSize = 0;
            btnProcedimientos.Width = 247;
            btnProcedimientos.BackColor = Color.FromArgb(70, 70, 69);
           // btnSqlDinamico.FlatAppearance.BorderSize = 0;
            btnSqlDinamico.Width = 247;
            btnSqlDinamico.BackColor = Color.FromArgb(70, 70, 69);
           // boton.FlatAppearance.BorderSize = 1;
            boton.Width = 211;
            boton.BackColor = Color.FromArgb(24, 24, 25);
           
            
        }
        #endregion
    }

}
