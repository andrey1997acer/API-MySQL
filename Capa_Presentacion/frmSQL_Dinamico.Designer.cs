namespace Capa_Presentacion
{
    partial class frmSQL_Dinamico
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtvResultado = new System.Windows.Forms.DataGridView();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cmbTipoComando = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Resultado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtvResultado
            // 
            this.dtvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dtvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvResultado.Location = new System.Drawing.Point(52, 334);
            this.dtvResultado.Name = "dtvResultado";
            this.dtvResultado.Size = new System.Drawing.Size(646, 179);
            this.dtvResultado.TabIndex = 16;
            // 
            // txtComando
            // 
            this.txtComando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComando.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComando.Location = new System.Drawing.Point(52, 71);
            this.txtComando.Multiline = true;
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(646, 157);
            this.txtComando.TabIndex = 2;
            this.txtComando.TextChanged += new System.EventHandler(this.TxtComando_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 42);
            this.label6.TabIndex = 23;
            this.label6.Text = "SQL DINAMICO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjecutar.AutoSize = true;
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutar.Location = new System.Drawing.Point(579, 234);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(121, 27);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsulta.BackColor = System.Drawing.Color.LightGray;
            this.lblConsulta.Location = new System.Drawing.Point(49, 234);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(523, 51);
            this.lblConsulta.TabIndex = 24;
            this.lblConsulta.Click += new System.EventHandler(this.LblConsulta_Click);
            // 
            // cmbTipoComando
            // 
            this.cmbTipoComando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComando.FormattingEnabled = true;
            this.cmbTipoComando.Items.AddRange(new object[] {
            "Comando",
            "Funcion",
            "Procedimiento"});
            this.cmbTipoComando.Location = new System.Drawing.Point(52, 44);
            this.cmbTipoComando.Name = "cmbTipoComando";
            this.cmbTipoComando.Size = new System.Drawing.Size(217, 21);
            this.cmbTipoComando.TabIndex = 1;
            this.cmbTipoComando.SelectedIndexChanged += new System.EventHandler(this.CmbTipoComando_SelectedIndexChanged);
            this.cmbTipoComando.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCommit_MouseMove);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label2.Location = new System.Drawing.Point(49, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tipo transaccion:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRollback
            // 
            this.btnRollback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRollback.BackColor = System.Drawing.Color.Transparent;
            this.btnRollback.BackgroundImage = global::Capa_Presentacion.Properties.Resources.icons8_cerrar_ventana_64;
            this.btnRollback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRollback.FlatAppearance.BorderSize = 0;
            this.btnRollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollback.Location = new System.Drawing.Point(704, 480);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(36, 33);
            this.btnRollback.TabIndex = 5;
            this.btnRollback.UseVisualStyleBackColor = false;
            this.btnRollback.Click += new System.EventHandler(this.BtnRollback_Click);
            this.btnRollback.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCommit_MouseMove);
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommit.BackColor = System.Drawing.Color.Transparent;
            this.btnCommit.BackgroundImage = global::Capa_Presentacion.Properties.Resources.icons8_marca_doble_64;
            this.btnCommit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCommit.FlatAppearance.BorderSize = 0;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Location = new System.Drawing.Point(704, 441);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(36, 33);
            this.btnCommit.TabIndex = 4;
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            this.btnCommit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCommit_MouseMove);
            // 
            // frmSQL_Dinamico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 534);
            this.Controls.Add(this.btnRollback);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoComando);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvResultado);
            this.Controls.Add(this.txtComando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSQL_Dinamico";
            this.Text = "frmSQL_Dinamico";
            this.Load += new System.EventHandler(this.FrmSQL_Dinamico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvResultado;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ComboBox cmbTipoComando;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnRollback;
    }
}