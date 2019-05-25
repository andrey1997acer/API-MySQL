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
    public partial class frmProcedimientos : Form
    {
        #region [INSTANCIAS]
        Gestiones logica;
        ToolTip tt = new ToolTip();
        bool activaEvento = false;

        public Gestiones Logica { get => logica; set => logica = value; }

        #endregion

        #region [CONSTRUCT]

        public frmProcedimientos(Gestiones log)
        {
            this.Logica = log;
            InitializeComponent();
        }
        #endregion

        #region [Eventos]
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDataGrid();
        }

        private void FrmProcedimientos_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EjecutarSQL();

        }


        private void DgvParametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dgvParametros.Rows.Remove(dgvParametros.CurrentRow);
            }
        }




        private void TxtValorParam_KeyPress(object sender, KeyPressEventArgs e)
        {

            string[] tipoDato = cmbNombreParam.Text.Split(' ');
            switch (tipoDato[1].ToUpper())
            {
                case "INT":
                    if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {

                        e.Handled = true;
                        return;
                    }

                    break;
                case "DOUBLE":
                    if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != Convert.ToChar("."))
                    {

                        e.Handled = true;
                        return;
                    }
                    break;


            }


        }

        private void LblParametros_Click(object sender, EventArgs e)
        {


        }

        private void TxtValorParam_MouseMove(object sender, MouseEventArgs e)
        {
            TooltipSHOW();
        }


        private void CmbNombreParam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void DgvParametros_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cmbNombreParam.Items.Count > dgvParametros.Rows.Count)
            {
                btnEjecutar.Enabled = false;
            }
            else
            {
                btnEjecutar.Enabled = true;
            }
        }

        private void DgvParametros_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dgvParametros.Rows.Remove(dgvParametros.CurrentRow);
            }
        }

        private void DgvParametros_MouseMove(object sender, MouseEventArgs e)
        {
            if (cmbNombreParam.Items.Count > dgvParametros.Rows.Count)
            {
                btnEjecutar.Enabled = false;
            }
            else
            {
                btnEjecutar.Enabled = true;
            }
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarComboTipo();
        }

        private void CmbRoutines1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiaComboRoutine();

        }
        #endregion

        #region [Metodos]

        private void CambiarComboTipo()
        {
            
            if (cmbTipo.Text.ToUpper() == "PROCEDIMIENTO")
            {
                DataTable datos = Logica.GetListProcedures();
                   
                        cmbRoutines1.DataSource = datos;
                        cmbRoutines1.DisplayMember = "SPECIFIC_NAME";

                        cmbRoutines1.Text = "";
                    
            }
            else if (cmbTipo.Text.ToUpper() == "FUNCION")
            {
                
                    DataTable datos = Logica.GetListFunction();

                    
                        cmbRoutines1.DataSource = datos;
                        cmbRoutines1.DisplayMember = "SPECIFIC_NAME";

                        cmbRoutines1.Text = "";
                    
                
            }
           
        }

        private void AgregarDataGrid()
        {
            if (txtValorParam.Text != "")
            {
                if (cmbNombreParam.Items.Count != dgvParametros.Rows.Count)
                {
                    string[] dta = cmbNombreParam.Text.Split(' ');
                    dgvParametros.Rows.Add(dta[0], txtValorParam.Text, dta[1], "Eliminar");
                    txtValorParam.Text = "";
                    cmbNombreParam.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("No se puede insertar mas parametros, verifique en la lista los datos.", "Aviso de sobrecarga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor.", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }

        private void CambiaComboRoutine()
        {
            if (cmbTipo.Text.ToUpper() == "PROCEDIMIENTO")
            {
                MetodoListarProcedimientos();
            }
            else
            {
                MetodoListarFunciones();
            }
            btnEjecutar.Enabled = false;
        }

        private void MetodoListarFunciones()
        {
            dgvParametros.Rows.Clear();

            dgvResultado.DataSource = null;
            dgvResultado.Rows.Clear();
            try
            {
                lblParametros.Text = "";
                if (activaEvento != false)   //Esta condicion es por que el envia un valor null y produce una  excepcion incoherente.
                {
                    try
                    {
                        DataTable data = Logica.GetFunctionParameters(cmbRoutines1.Text);

                        #region EXTRAER TODO EL METODO PARA DESCOMPONER EN "com"
                        ComboBox com = new ComboBox();
                        com.Name = "cmbcom";
                        com.DropDownStyle = ComboBoxStyle.DropDownList;
                        com.DataSource = data;

                        com.DisplayMember = "Create Function";
                        Controls.Add(com);
                        com.Visible = false;
                        #endregion



                        string[] key1 = com.Text.Split(')'); //Tomo lo que esta despues del parametro
                        string[] key2 = key1[0].Split('('); //Tomo los parametros del metodo
                        string[] parametros = key2[1].Split(',');
                        string[] nombreParam = parametros; //para inciarlizarlo con la misma cantidad de parametros
                        cmbNombreParam.Items.Clear();
                        for (int i = 0; i < (parametros.Length); i++)
                        {
                            parametros[i] = parametros[i].Trim();
                            nombreParam = parametros[i].Split(' ');


                            cmbNombreParam.Items.Add(nombreParam[0] + " " + nombreParam[1]);
                            lblParametros.Text += parametros[i] + " , ";
                        }
                        txtValorParam.Enabled = true;
                        btnAgregar.Enabled = true;

                    }
                    catch (IndexOutOfRangeException e)
                    {
                       MessageBox.Show("No existe parametros para esta funcion.","Mensaje Informativo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtValorParam.Enabled = false;
                        btnAgregar.Enabled = false;
                    }

                }
                else
                {
                    activaEvento = true;

                }
            }
            catch (Exception)

            {

            }
        }

       
        private void MetodoListarProcedimientos()
        {
            dgvParametros.Rows.Clear();

            dgvResultado.DataSource = null;
            dgvResultado.Rows.Clear();
            try
            {
                lblParametros.Text = "";
                if (activaEvento != false)   //Esta condicion es por que el envia un valor null y produce una  excepcion incoherente.
                {
                    try
                    {
                        DataTable data = Logica.GetProceduralParameters(cmbRoutines1.Text);

                        #region EXTRAER TODO EL METODO PARA DESCOMPONER EN "com"
                        ComboBox com = new ComboBox();
                        com.Name = "cmbcom";
                        com.DropDownStyle = ComboBoxStyle.DropDownList;
                        com.DataSource = data;

                        com.DisplayMember = "Create Procedure";
                        Controls.Add(com);
                        com.Visible = false;
                        #endregion



                        string[] key1 = com.Text.Split(')'); //Tomo lo que esta despues del parametro
                        string[] key2 = key1[0].Split('('); //Tomo los parametros del metodo
                        string[] parametros = key2[1].Split(',');
                        string[] nombreParam = parametros; //para inciarlizarlo con la misma cantidad de parametros
                        cmbNombreParam.Items.Clear();
                        for (int i = 0; i < (parametros.Length); i++)
                        {
                            parametros[i] = parametros[i].Trim();
                            nombreParam = parametros[i].Split(' ');


                            cmbNombreParam.Items.Add(nombreParam[1] + " " + nombreParam[2]);
                            lblParametros.Text += parametros[i] + " , ";
                        }
                        txtValorParam.Enabled = true;
                        btnAgregar.Enabled = true;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("No existe parametros para esta procedimiento..","Mensaje Informativo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtValorParam.Enabled = false;
                        btnAgregar.Enabled = false;
                    }
                }
                else
                {
                    activaEvento = true;

                }
            }
            catch (Exception)

            {

            }
        }
        private void EjecutarSQL()
        {

            #region [ Insertar datos del grid a vectores de datos ]
            string[] column0Array = new string[dgvParametros.Rows.Count];
            string[] column1Array = new string[dgvParametros.Rows.Count];
            string[] column2Array = new string[dgvParametros.Rows.Count];
            int i = 0;


            foreach (DataGridViewRow row in dgvParametros.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    column0Array[i] = row.Cells[0].Value != null ?
                    row.Cells[0].Value.ToString() : string.Empty;


                    column1Array[i] = row.Cells[1].Value != null ?
                    row.Cells[1].Value.ToString() : string.Empty;

                    column2Array[i] = row.Cells[2].Value != null ?
                   row.Cells[2].Value.ToString() : string.Empty;


                    if (i <= column0Array.Length) { i++; }//No me toma el ultimo valor del grid que es null

                }

            }



            #endregion


            //Procedo que no hayan repetidos en los parametros
            bool pares = column0Array.Distinct().Count() == column0Array.Length;
            if (pares == true)
            {
                try
                {
                    DataSet datos = Logica.GetFunctionAndProcedures(cmbTipo.Text, cmbRoutines1.Text, column0Array, column1Array, column2Array);

                    dgvResultado.DataSource = datos.Tables[0];


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Procesado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("El procedimiento no rertona ningun valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
            }
            else
            {
                MessageBox.Show("Tienes parametros repetidos en la lista.", "Aviso de sobrecarga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void TooltipSHOW()
        {
            tt.SetToolTip(txtValorParam, "No puede ser un valor nulo.");
            tt.SetToolTip(lblOligatorio, "No puede ser un valor nulo.");
            if (txtValorParam.Text == "")
            {
                tt.SetToolTip(btnAgregar, "Por favor ingresar un valor");
            }
            tt.SetToolTip(lbltitulo, "Aqui se gestiona todos los procedimiendo y funciones que estan guardada en la base de datos conectada\r\n" +
                ", puedes ejecutar funciones y procedimientos de la forma mas dinamica posible con un manejo de errores muy alto y inteligente.");

        }



        #endregion

    }
}
