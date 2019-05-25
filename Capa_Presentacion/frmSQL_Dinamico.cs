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
    public partial class frmSQL_Dinamico : Form
    {
        #region [INSTANCIAS]
        ToolTip tt = new ToolTip();
        Gestiones logica;
        public Gestiones Logica { get => logica; set => logica = value; }
        #endregion

        #region [CONSTRUCT]
        public frmSQL_Dinamico(Gestiones logc)
        {
            this.Logica =  logc;
            InitializeComponent();
        }
        #endregion

        #region [EVENTOS]
        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            EjecutarScriptSQL();

        }
        private void FrmSQL_Dinamico_Load(object sender, EventArgs e)
        {
            lblConsulta.Enabled = false;
            cmbTipoComando.SelectedIndex = 0;
        }
        private void LblConsulta_Click(object sender, EventArgs e)
        {
            txtComando.Text = lblConsulta.Text;
            lblConsulta.Text = "";
            lblConsulta.Enabled = false;
        }
        private void CmbTipoComando_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiaComboTipoComando();
        }
        private void TxtComando_TextChanged(object sender, EventArgs e)
        {
            if(txtComando.Text  == "")
            {
                cmbTipoComando.SelectedIndex = 0;
            }
        }
        private void BtnCommit_MouseMove(object sender, MouseEventArgs e)
        {
            tt.SetToolTip(btnCommit,"COMMIT");
            tt.SetToolTip(btnRollback, "ROLLBACK");
            if(cmbTipoComando.Text.ToLower() == "comando")
            {
                tt.SetToolTip(cmbTipoComando, "Sentencias del SQL que se utilizan para manejar los datos de la base de datos (select, insert, update, delete, etc).");
            }
            else if (cmbTipoComando.Text.ToLower() == "funcion")
            {
                tt.SetToolTip(cmbTipoComando, "Ejecuta solo transacciones de tipo Funcion.");
            }
            else if (cmbTipoComando.Text.ToLower() == "procedimiento")
            {
                tt.SetToolTip(cmbTipoComando, "Ejecuta solo transacciones de tipo procedimiento.");
            }
        }
        private void BtnCommit_Click(object sender, EventArgs e)
        {

            COMMIT();

        }
        private void BtnRollback_Click(object sender, EventArgs e)
        {
            ROLLBACK();
        }
        #endregion


        #region [METODOS]
        private void EjecutarScriptSQL()
        {


            string[] comandos = txtComando.Text.Split(';');


            if ((cmbTipoComando.Text.ToLower() == "funcion" || cmbTipoComando.Text.ToLower() == "procedimiento"))
            {
                string info = Logica.SetQuery(txtComando.Text);
                if (info.ToLower() == "sentecia exitosa")
                {
                    MessageBox.Show(info, "Mensaje Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblConsulta.Enabled = true;
                    lblConsulta.Text = txtComando.Text;
                    txtComando.Text = "";
                }
                else
                {
                    MessageBox.Show(info, "Mensaje Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (cmbTipoComando.Text.ToLower() == "comando")
            {
                for (int i = 0; i < comandos.Length - 1; i++)
                {
                    comandos[i] = comandos[i].TrimStart();



                    string[] variable = comandos[i].Split(' ');
                    if (variable[0].ToUpper() == "SELECT" || variable[0].ToUpper() == "SHOW")
                    {
                        if (Logica.GetQuery(comandos[i]) != null)
                        {
                            DataSet datos = Logica.GetQuery(comandos[i]);
                            dtvResultado.DataSource = datos.Tables[0];
                            lblConsulta.Enabled = true;
                            lblConsulta.Text = txtComando.Text;
                            txtComando.Text = "";
                        }
                        else
                        {
                            Console.WriteLine("consulta mala");
                        }

                    }
                    else
                    {
                        MessageBox.Show(Logica.SetQuery(comandos[i]), "Mensaje Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lblConsulta.Enabled = true;
                        lblConsulta.Text = txtComando.Text;
                        txtComando.Text = "";

                    }

                }
            }


        }
        private void CambiaComboTipoComando()
        {
            dtvResultado.DataSource = null;
            dtvResultado.Rows.Clear();
            if (cmbTipoComando.Text.ToLower() != "comando")
            {
                if (cmbTipoComando.Text.ToLower() == "funcion")
                {
                    txtComando.Text = Logica.GetFunctionStructure();


                }
                if (cmbTipoComando.Text.ToLower() == "procedimiento")
                {
                    txtComando.Text = Logica.GetProceduresStructure();

                }

            }
            else
            {
                txtComando.Text = "";
            }
        }
        private void ROLLBACK()
        {
            Logica.SetQuery("ROLLBACK;");
            MessageBox.Show("Transaccion REVERTIDA correctamente.");
        }
        private void COMMIT()
        {
            Logica.SetQuery("COMMIT;");
            MessageBox.Show("Transaccion APLICADA correctamente");
        }

        #endregion
    }
}
