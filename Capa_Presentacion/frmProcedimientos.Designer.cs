namespace Capa_Presentacion
{
    partial class frmProcedimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtValorParam = new System.Windows.Forms.TextBox();
            this.dgvParametros = new System.Windows.Forms.DataGridView();
            this.Parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.cmbRoutines1 = new System.Windows.Forms.ComboBox();
            this.lblParametros = new System.Windows.Forms.Label();
            this.cmbNombreParam = new System.Windows.Forms.ComboBox();
            this.lblOligatorio = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(87, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(549, 42);
            this.lbltitulo.TabIndex = 23;
            this.lbltitulo.Text = "PROCEDIMIENTOS Y FUNCIONES";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtValorParam_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tipo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 13;
            this.cmbTipo.Items.AddRange(new object[] {
            "Funcion",
            "Procedimiento"});
            this.cmbTipo.Location = new System.Drawing.Point(65, 73);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 25;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre Función | Procedimiento:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Parametros:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "Valor:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(98, 286);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 31);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtValorParam
            // 
            this.txtValorParam.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParam.Location = new System.Drawing.Point(82, 241);
            this.txtValorParam.Name = "txtValorParam";
            this.txtValorParam.Size = new System.Drawing.Size(121, 26);
            this.txtValorParam.TabIndex = 4;
            this.txtValorParam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorParam_KeyPress);
            this.txtValorParam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtValorParam_MouseMove);
            // 
            // dgvParametros
            // 
            this.dgvParametros.AllowUserToAddRows = false;
            this.dgvParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParametros.BackgroundColor = System.Drawing.Color.White;
            this.dgvParametros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvParametros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParametros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parametro,
            this.Valor,
            this.Tipo,
            this.Eliminar});
            this.dgvParametros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvParametros.Location = new System.Drawing.Point(224, 178);
            this.dgvParametros.Name = "dgvParametros";
            this.dgvParametros.RowHeadersWidth = 20;
            this.dgvParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParametros.Size = new System.Drawing.Size(498, 150);
            this.dgvParametros.TabIndex = 34;
            this.dgvParametros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParametros_CellContentClick_1);
            this.dgvParametros.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvParametros_CellMouseMove);
            this.dgvParametros.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DgvParametros_MouseMove);
            // 
            // Parametro
            // 
            this.Parametro.DividerWidth = 2;
            this.Parametro.Frozen = true;
            this.Parametro.HeaderText = "Parametro";
            this.Parametro.Name = "Parametro";
            this.Parametro.ReadOnly = true;
            this.Parametro.Width = 80;
            // 
            // Valor
            // 
            this.Valor.Frozen = true;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 56;
            // 
            // Tipo
            // 
            this.Tipo.Frozen = true;
            this.Tipo.HeaderText = "Tipo_Dato";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 82;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Text = "";
            this.Eliminar.Width = 49;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "Resultados:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(112, 423);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(589, 124);
            this.dgvResultado.TabIndex = 37;
            // 
            // cmbRoutines1
            // 
            this.cmbRoutines1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoutines1.DropDownHeight = 70;
            this.cmbRoutines1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoutines1.FormattingEnabled = true;
            this.cmbRoutines1.IntegralHeight = false;
            this.cmbRoutines1.ItemHeight = 13;
            this.cmbRoutines1.Location = new System.Drawing.Point(396, 72);
            this.cmbRoutines1.Name = "cmbRoutines1";
            this.cmbRoutines1.Size = new System.Drawing.Size(305, 21);
            this.cmbRoutines1.TabIndex = 40;
            this.cmbRoutines1.SelectedIndexChanged += new System.EventHandler(this.CmbRoutines1_SelectedIndexChanged);
            // 
            // lblParametros
            // 
            this.lblParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParametros.ForeColor = System.Drawing.Color.Purple;
            this.lblParametros.Location = new System.Drawing.Point(99, 104);
            this.lblParametros.Name = "lblParametros";
            this.lblParametros.Size = new System.Drawing.Size(592, 33);
            this.lblParametros.TabIndex = 41;
            this.lblParametros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblParametros.Click += new System.EventHandler(this.LblParametros_Click);
            // 
            // cmbNombreParam
            // 
            this.cmbNombreParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreParam.FormattingEnabled = true;
            this.cmbNombreParam.ItemHeight = 13;
            this.cmbNombreParam.Location = new System.Drawing.Point(82, 205);
            this.cmbNombreParam.Name = "cmbNombreParam";
            this.cmbNombreParam.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreParam.TabIndex = 42;
            this.cmbNombreParam.SelectedIndexChanged += new System.EventHandler(this.CmbNombreParam_SelectedIndexChanged);
            // 
            // lblOligatorio
            // 
            this.lblOligatorio.AutoSize = true;
            this.lblOligatorio.BackColor = System.Drawing.Color.White;
            this.lblOligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblOligatorio.Location = new System.Drawing.Point(203, 244);
            this.lblOligatorio.Name = "lblOligatorio";
            this.lblOligatorio.Size = new System.Drawing.Size(15, 20);
            this.lblOligatorio.TabIndex = 43;
            this.lblOligatorio.Text = "*";
            this.lblOligatorio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtValorParam_MouseMove);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.Enabled = false;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutar.Location = new System.Drawing.Point(557, 357);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(144, 33);
            this.btnEjecutar.TabIndex = 6;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 570);
            this.Controls.Add(this.lblOligatorio);
            this.Controls.Add(this.cmbNombreParam);
            this.Controls.Add(this.lblParametros);
            this.Controls.Add(this.cmbRoutines1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgvParametros);
            this.Controls.Add(this.txtValorParam);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcedimientos";
            this.Text = "Procedimientos";
            this.Load += new System.EventHandler(this.FrmProcedimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtValorParam;
        private System.Windows.Forms.DataGridView dgvParametros;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.ComboBox cmbRoutines1;
        private System.Windows.Forms.Label lblParametros;
        private System.Windows.Forms.ComboBox cmbNombreParam;
        private System.Windows.Forms.Label lblOligatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}