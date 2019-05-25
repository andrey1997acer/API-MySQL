namespace Capa_Presentacion
{
    partial class frmPrincipal
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
            System.Windows.Forms.Panel pnBar;
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnFormularios = new System.Windows.Forms.Panel();
            this.pnImagenLOGO = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSqlDinamico = new System.Windows.Forms.Button();
            this.btnProcedimientos = new System.Windows.Forms.Button();
            this.btnStringConexion = new System.Windows.Forms.Button();
            this.btnDatosGenerales = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            pnBar = new System.Windows.Forms.Panel();
            pnBar.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnFormularios.SuspendLayout();
            this.pnImagenLOGO.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBar
            // 
            pnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            pnBar.Controls.Add(this.btnMaximizar);
            pnBar.Controls.Add(this.btnMinimizar);
            pnBar.Controls.Add(this.btnRestaurar);
            pnBar.Controls.Add(this.btnSalir);
            pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnBar.Location = new System.Drawing.Point(0, 0);
            pnBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnBar.Name = "pnBar";
            pnBar.Size = new System.Drawing.Size(1034, 63);
            pnBar.TabIndex = 0;
            pnBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnBar_MouseMove);
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Controls.Add(this.btnSqlDinamico);
            this.pnMenu.Controls.Add(this.btnProcedimientos);
            this.pnMenu.Controls.Add(this.btnStringConexion);
            this.pnMenu.Controls.Add(this.btnDatosGenerales);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(267, 689);
            this.pnMenu.TabIndex = 1;
            // 
            // pnFormularios
            // 
            this.pnFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFormularios.BackColor = System.Drawing.Color.White;
            this.pnFormularios.Controls.Add(this.pnImagenLOGO);
            this.pnFormularios.ForeColor = System.Drawing.Color.Black;
            this.pnFormularios.Location = new System.Drawing.Point(275, 69);
            this.pnFormularios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnFormularios.Name = "pnFormularios";
            this.pnFormularios.Size = new System.Drawing.Size(759, 603);
            this.pnFormularios.TabIndex = 2;
            // 
            // pnImagenLOGO
            // 
            this.pnImagenLOGO.BackgroundImage = global::Capa_Presentacion.Properties.Resources.dolphin1;
            this.pnImagenLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImagenLOGO.Controls.Add(this.label2);
            this.pnImagenLOGO.Location = new System.Drawing.Point(82, 41);
            this.pnImagenLOGO.Name = "pnImagenLOGO";
            this.pnImagenLOGO.Size = new System.Drawing.Size(560, 475);
            this.pnImagenLOGO.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(118, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "API MYSQL";
            // 
            // pnLogo
            // 
            this.pnLogo.BackgroundImage = global::Capa_Presentacion.Properties.Resources.dolphin1;
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Location = new System.Drawing.Point(12, 12);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(127, 89);
            this.pnLogo.TabIndex = 4;
            this.pnLogo.Click += new System.EventHandler(this.PnLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "API MYSQL";
            // 
            // btnSqlDinamico
            // 
            this.btnSqlDinamico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnSqlDinamico.FlatAppearance.BorderSize = 0;
            this.btnSqlDinamico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSqlDinamico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSqlDinamico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlDinamico.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlDinamico.ForeColor = System.Drawing.Color.White;
            this.btnSqlDinamico.Image = global::Capa_Presentacion.Properties.Resources.appbar_database_sql;
            this.btnSqlDinamico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSqlDinamico.Location = new System.Drawing.Point(13, 378);
            this.btnSqlDinamico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSqlDinamico.Name = "btnSqlDinamico";
            this.btnSqlDinamico.Size = new System.Drawing.Size(247, 55);
            this.btnSqlDinamico.TabIndex = 3;
            this.btnSqlDinamico.Text = "SQL DINÁMICO";
            this.btnSqlDinamico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSqlDinamico.UseVisualStyleBackColor = false;
            this.btnSqlDinamico.Click += new System.EventHandler(this.BtnSqlDinamico_Click);
            // 
            // btnProcedimientos
            // 
            this.btnProcedimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnProcedimientos.FlatAppearance.BorderSize = 0;
            this.btnProcedimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnProcedimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnProcedimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcedimientos.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcedimientos.ForeColor = System.Drawing.Color.White;
            this.btnProcedimientos.Image = global::Capa_Presentacion.Properties.Resources.appbar_hardware_cpu;
            this.btnProcedimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcedimientos.Location = new System.Drawing.Point(13, 306);
            this.btnProcedimientos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcedimientos.Name = "btnProcedimientos";
            this.btnProcedimientos.Size = new System.Drawing.Size(247, 55);
            this.btnProcedimientos.TabIndex = 2;
            this.btnProcedimientos.Text = "PROCEDIMIENTOS";
            this.btnProcedimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcedimientos.UseVisualStyleBackColor = false;
            this.btnProcedimientos.Click += new System.EventHandler(this.BtnProcedimientos_Click);
            // 
            // btnStringConexion
            // 
            this.btnStringConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnStringConexion.FlatAppearance.BorderSize = 0;
            this.btnStringConexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnStringConexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnStringConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStringConexion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStringConexion.ForeColor = System.Drawing.Color.White;
            this.btnStringConexion.Image = global::Capa_Presentacion.Properties.Resources.appbar_diagram;
            this.btnStringConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStringConexion.Location = new System.Drawing.Point(13, 160);
            this.btnStringConexion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStringConexion.Name = "btnStringConexion";
            this.btnStringConexion.Size = new System.Drawing.Size(247, 55);
            this.btnStringConexion.TabIndex = 1;
            this.btnStringConexion.Text = "STRING CONEXIÓN";
            this.btnStringConexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStringConexion.UseVisualStyleBackColor = false;
            this.btnStringConexion.Click += new System.EventHandler(this.BtnStringConexion_Click);
            // 
            // btnDatosGenerales
            // 
            this.btnDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnDatosGenerales.FlatAppearance.BorderSize = 0;
            this.btnDatosGenerales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnDatosGenerales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosGenerales.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosGenerales.ForeColor = System.Drawing.Color.White;
            this.btnDatosGenerales.Image = global::Capa_Presentacion.Properties.Resources.appbar_user_tie;
            this.btnDatosGenerales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosGenerales.Location = new System.Drawing.Point(13, 233);
            this.btnDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDatosGenerales.Name = "btnDatosGenerales";
            this.btnDatosGenerales.Size = new System.Drawing.Size(247, 55);
            this.btnDatosGenerales.TabIndex = 0;
            this.btnDatosGenerales.Text = "DATOS GENERALES";
            this.btnDatosGenerales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatosGenerales.UseVisualStyleBackColor = false;
            this.btnDatosGenerales.Click += new System.EventHandler(this.BtnDatosGenerales_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.appbar_window_maximize;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(941, 14);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(36, 31);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.appbar_window_minimize;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(941, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 31);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnRestaurar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.appbar_window_restore;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(897, 14);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(36, 31);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnSalir.BackgroundImage = global::Capa_Presentacion.Properties.Resources.appbar_close;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(985, 14);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSalir.Size = new System.Drawing.Size(36, 31);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 689);
            this.Controls.Add(this.pnFormularios);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(pnBar);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            pnBar.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnFormularios.ResumeLayout(false);
            this.pnImagenLOGO.ResumeLayout(false);
            this.pnImagenLOGO.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnSqlDinamico;
        private System.Windows.Forms.Button btnProcedimientos;
        private System.Windows.Forms.Button btnStringConexion;
        private System.Windows.Forms.Button btnDatosGenerales;
        private System.Windows.Forms.Panel pnFormularios;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnImagenLOGO;
        private System.Windows.Forms.Label label2;
    }
}