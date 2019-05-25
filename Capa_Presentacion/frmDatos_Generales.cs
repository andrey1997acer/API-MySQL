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
    public partial class frmDatos_Generales : Form
    {
        #region [INSTANCIAS]
        frmPrincipal principal;
        Gestiones logica;
        frmSQL_Dinamico sql;
        Button sqldinamico;
        public Gestiones Logica { get => logica; set => logica = value; }
        public frmPrincipal Principal { get => principal; set => principal = value; }
        public frmSQL_Dinamico Sql { get => sql; set => sql = value; }
        public Button Sqldinamico { get => sqldinamico; set => sqldinamico = value; }
        #endregion

        #region [CONSTRUCT]
        public frmDatos_Generales(frmPrincipal form, Gestiones log, frmSQL_Dinamico sql1,Button sqldinamico)
        {
            InitializeComponent();
            Principal = form;
            Logica = log;
            Sql= sql1;
            Sqldinamico = sqldinamico;
        }
        #endregion

        #region [EVENTOS]
        private void BtnConexion_Click(object sender, EventArgs e)
        {
            CreateTable(txtNombreEstudiante.Text,txtCedula.Text,txtCurso.Text);
        }
        private void FrmDatos_Generales_MouseMove(object sender, MouseEventArgs e)
        {
            if(txtCedula.Text !=""&&txtCurso.Text != "" && txtNombreEstudiante.Text != "")
            {
                btnEjecutar.Enabled = true;
            }
            else
            {
                btnEjecutar.Enabled = false;
            }
        }
        private void FrmDatos_Generales_Load(object sender, EventArgs e)
        {

        }
        #endregion


        #region[METODOS]
        private void CreateTable(string nombre, string cedula, string curso)
        {
            string cadena;
            cadena = "CREATE TABLE IF NOT EXISTS `Datos_General` \r\n" +
                    "(`ID_datoGeneral` INT NOT NULL AUTO_INCREMENT,\r\n" +
                    "`nombre` VARCHAR(50) NOT NULL,\r\n" +
                    "`cedula` VARCHAR(20) NOT NULL ,\r\n" +
                    "`curso` VARCHAR(30) NOT NULL,\r\n" +
                    "PRIMARY KEY(`ID_datoGeneral`))\r\n" +
                    "ENGINE = InnoDB; \r\n";
            string insert = "\r\n\r\n\r\nINSERT INTO Datos_General(nombre,cedula,curso)" +
                            "VALUES('" + nombre.ToUpperInvariant() + "','" + cedula + "','" + curso.ToUpperInvariant() + "');";

            Principal.AbrirFormulario(Sql, Sqldinamico);
            Sql.txtComando.Text = cadena + insert;
        }

        #endregion

    }
}
