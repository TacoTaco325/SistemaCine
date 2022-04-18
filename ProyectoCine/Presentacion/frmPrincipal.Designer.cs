
namespace Presentacion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconPictureBox();
            this.holaaaaaaaaaaaa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.ptbCargo = new System.Windows.Forms.PictureBox();
            this.btnDatos = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subpnlMant = new System.Windows.Forms.Panel();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnFuncion = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPelicula = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnProducto = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnMantenimiento = new FontAwesome.Sharp.IconButton();
            this.btnCine = new FontAwesome.Sharp.IconButton();
            this.btnConfiteria = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlPadre = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDatos)).BeginInit();
            this.subpnlMant.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(1, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Controls.Add(this.btnMinizar);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1920, 25);
            this.panel3.TabIndex = 2;
            // 
            // btnMinizar
            // 
            this.btnMinizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar.Image = global::Presentacion.Properties.Resources.minimizar;
            this.btnMinizar.Location = new System.Drawing.Point(1871, 3);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinizar.TabIndex = 1;
            this.btnMinizar.TabStop = false;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1897, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.holaaaaaaaaaaaa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.ptbCargo);
            this.panel1.Controls.Add(this.btnDatos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.subpnlMant);
            this.panel1.Controls.Add(this.btnMantenimiento);
            this.panel1.Controls.Add(this.btnCine);
            this.panel1.Controls.Add(this.btnConfiteria);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1055);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 90;
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 793);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(107, 90);
            this.btnCerrarSesion.TabIndex = 38;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // holaaaaaaaaaaaa
            // 
            this.holaaaaaaaaaaaa.AutoSize = true;
            this.holaaaaaaaaaaaa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holaaaaaaaaaaaa.ForeColor = System.Drawing.Color.White;
            this.holaaaaaaaaaaaa.Location = new System.Drawing.Point(116, 823);
            this.holaaaaaaaaaaaa.Name = "holaaaaaaaaaaaa";
            this.holaaaaaaaaaaaa.Size = new System.Drawing.Size(128, 22);
            this.holaaaaaaaaaaaa.TabIndex = 37;
            this.holaaaaaaaaaaaa.Text = "Cerrar Sesion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(133, 1025);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "DNI:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.LightGray;
            this.lblDNI.Location = new System.Drawing.Point(170, 1025);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(36, 20);
            this.lblDNI.TabIndex = 34;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombre.Location = new System.Drawing.Point(134, 990);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.LightGray;
            this.lblCargo.Location = new System.Drawing.Point(134, 955);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 32;
            this.lblCargo.Text = "Cargo";
            // 
            // ptbCargo
            // 
            this.ptbCargo.Location = new System.Drawing.Point(0, 889);
            this.ptbCargo.Name = "ptbCargo";
            this.ptbCargo.Size = new System.Drawing.Size(128, 166);
            this.ptbCargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCargo.TabIndex = 31;
            this.ptbCargo.TabStop = false;
            // 
            // btnDatos
            // 
            this.btnDatos.Image = global::Presentacion.Properties.Resources.LogoPNG;
            this.btnDatos.Location = new System.Drawing.Point(3, 72);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(227, 187);
            this.btnDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDatos.TabIndex = 30;
            this.btnDatos.TabStop = false;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(52, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 66);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cine\r\nEl Quijote";
            // 
            // subpnlMant
            // 
            this.subpnlMant.Controls.Add(this.btnEmpleado);
            this.subpnlMant.Controls.Add(this.panel8);
            this.subpnlMant.Controls.Add(this.btnFuncion);
            this.subpnlMant.Controls.Add(this.panel7);
            this.subpnlMant.Controls.Add(this.btnPelicula);
            this.subpnlMant.Controls.Add(this.panel10);
            this.subpnlMant.Controls.Add(this.btnProducto);
            this.subpnlMant.Controls.Add(this.panel9);
            this.subpnlMant.Location = new System.Drawing.Point(50, 518);
            this.subpnlMant.Name = "subpnlMant";
            this.subpnlMant.Size = new System.Drawing.Size(200, 149);
            this.subpnlMant.TabIndex = 27;
            this.subpnlMant.Visible = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnEmpleado.IconColor = System.Drawing.Color.White;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.IconSize = 34;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(8, 106);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(192, 32);
            this.btnEmpleado.TabIndex = 10;
            this.btnEmpleado.Text = "EMPLEADO";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(1, 106);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(11, 32);
            this.panel8.TabIndex = 28;
            // 
            // btnFuncion
            // 
            this.btnFuncion.FlatAppearance.BorderSize = 0;
            this.btnFuncion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncion.ForeColor = System.Drawing.Color.LightGray;
            this.btnFuncion.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.btnFuncion.IconColor = System.Drawing.Color.White;
            this.btnFuncion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFuncion.IconSize = 40;
            this.btnFuncion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncion.Location = new System.Drawing.Point(8, 70);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(192, 32);
            this.btnFuncion.TabIndex = 27;
            this.btnFuncion.Text = "FUNCION";
            this.btnFuncion.UseVisualStyleBackColor = true;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(1, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(11, 32);
            this.panel7.TabIndex = 26;
            // 
            // btnPelicula
            // 
            this.btnPelicula.FlatAppearance.BorderSize = 0;
            this.btnPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelicula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelicula.ForeColor = System.Drawing.Color.LightGray;
            this.btnPelicula.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnPelicula.IconColor = System.Drawing.Color.White;
            this.btnPelicula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPelicula.IconSize = 40;
            this.btnPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelicula.Location = new System.Drawing.Point(8, 37);
            this.btnPelicula.Name = "btnPelicula";
            this.btnPelicula.Size = new System.Drawing.Size(192, 32);
            this.btnPelicula.TabIndex = 25;
            this.btnPelicula.Text = "CINE";
            this.btnPelicula.UseVisualStyleBackColor = true;
            this.btnPelicula.Click += new System.EventHandler(this.btnPelicula_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(1, 37);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(11, 32);
            this.panel10.TabIndex = 24;
            // 
            // btnProducto
            // 
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.LightGray;
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnProducto.IconColor = System.Drawing.Color.White;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.IconSize = 40;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(8, 3);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(192, 32);
            this.btnProducto.TabIndex = 23;
            this.btnProducto.Text = "CONFITERIA";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(1, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 32);
            this.panel9.TabIndex = 16;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.LightGray;
            this.btnMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnMantenimiento.IconColor = System.Drawing.Color.White;
            this.btnMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimiento.IconSize = 40;
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.Location = new System.Drawing.Point(9, 482);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(238, 32);
            this.btnMantenimiento.TabIndex = 24;
            this.btnMantenimiento.Text = "MANTENIMIENTO";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnCine
            // 
            this.btnCine.FlatAppearance.BorderSize = 0;
            this.btnCine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCine.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCine.ForeColor = System.Drawing.Color.LightGray;
            this.btnCine.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnCine.IconColor = System.Drawing.Color.White;
            this.btnCine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCine.IconSize = 40;
            this.btnCine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCine.Location = new System.Drawing.Point(9, 444);
            this.btnCine.Name = "btnCine";
            this.btnCine.Size = new System.Drawing.Size(238, 32);
            this.btnCine.TabIndex = 23;
            this.btnCine.Text = "CINE";
            this.btnCine.UseVisualStyleBackColor = true;
            this.btnCine.Click += new System.EventHandler(this.btnCine_Click);
            // 
            // btnConfiteria
            // 
            this.btnConfiteria.FlatAppearance.BorderSize = 0;
            this.btnConfiteria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnConfiteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiteria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiteria.ForeColor = System.Drawing.Color.LightGray;
            this.btnConfiteria.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnConfiteria.IconColor = System.Drawing.Color.White;
            this.btnConfiteria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiteria.IconSize = 40;
            this.btnConfiteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiteria.Location = new System.Drawing.Point(9, 406);
            this.btnConfiteria.Name = "btnConfiteria";
            this.btnConfiteria.Size = new System.Drawing.Size(238, 32);
            this.btnConfiteria.TabIndex = 22;
            this.btnConfiteria.Text = "CONFITERIA";
            this.btnConfiteria.UseVisualStyleBackColor = true;
            this.btnConfiteria.Click += new System.EventHandler(this.btnConfiteria_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(1, 482);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(1, 444);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 17;
            // 
            // pnlPadre
            // 
            this.pnlPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.Location = new System.Drawing.Point(250, 25);
            this.pnlPadre.Name = "pnlPadre";
            this.pnlPadre.Size = new System.Drawing.Size(1670, 1055);
            this.pnlPadre.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlPadre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDatos)).EndInit();
            this.subpnlMant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMantenimiento;
        private FontAwesome.Sharp.IconButton btnCine;
        private FontAwesome.Sharp.IconButton btnConfiteria;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel subpnlMant;
        private FontAwesome.Sharp.IconButton btnPelicula;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton btnProducto;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox btnMinizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlPadre;
        private FontAwesome.Sharp.IconButton btnFuncion;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox btnCerrarSesion;
        private System.Windows.Forms.Label holaaaaaaaaaaaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox ptbCargo;
        private System.Windows.Forms.PictureBox btnDatos;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private System.Windows.Forms.Panel panel8;
    }
}