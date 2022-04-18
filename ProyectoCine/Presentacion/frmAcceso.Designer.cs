
namespace Presentacion
{
    partial class frmAcceso
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNoVer = new FontAwesome.Sharp.IconButton();
            this.btnVer = new FontAwesome.Sharp.IconButton();
            this.ptbError = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 310);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.LogoPNG;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(457, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "LOGIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcon
            // 
            this.txtcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon.ForeColor = System.Drawing.Color.DimGray;
            this.txtcon.Location = new System.Drawing.Point(305, 139);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(407, 27);
            this.txtcon.TabIndex = 17;
            this.txtcon.Text = "CONTRASEÑA";
            this.txtcon.Enter += new System.EventHandler(this.txtcon_Enter);
            this.txtcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcon_KeyPress);
            this.txtcon.Leave += new System.EventHandler(this.txtcon_Leave);
            // 
            // txtusu
            // 
            this.txtusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusu.ForeColor = System.Drawing.Color.DimGray;
            this.txtusu.Location = new System.Drawing.Point(304, 85);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(408, 27);
            this.txtusu.TabIndex = 16;
            this.txtusu.Text = "USUARIO";
            this.txtusu.Enter += new System.EventHandler(this.txtusu_Enter);
            this.txtusu.Leave += new System.EventHandler(this.txtusu_Leave);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkGray;
            this.lblError.Location = new System.Drawing.Point(326, 200);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(48, 17);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "lblError";
            this.lblError.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptar.Location = new System.Drawing.Point(305, 244);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(408, 40);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "ACCEDER";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNoVer
            // 
            this.btnNoVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnNoVer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNoVer.FlatAppearance.BorderSize = 0;
            this.btnNoVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNoVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoVer.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnNoVer.IconColor = System.Drawing.Color.White;
            this.btnNoVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNoVer.IconSize = 27;
            this.btnNoVer.Location = new System.Drawing.Point(691, 143);
            this.btnNoVer.Name = "btnNoVer";
            this.btnNoVer.Size = new System.Drawing.Size(20, 20);
            this.btnNoVer.TabIndex = 23;
            this.btnNoVer.UseVisualStyleBackColor = false;
            this.btnNoVer.Click += new System.EventHandler(this.btnNoVer_Click);
            // 
            // btnVer
            // 
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVer.IconColor = System.Drawing.Color.White;
            this.btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVer.IconSize = 27;
            this.btnVer.Location = new System.Drawing.Point(691, 143);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(20, 20);
            this.btnVer.TabIndex = 22;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Visible = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // ptbError
            // 
            this.ptbError.Location = new System.Drawing.Point(304, 200);
            this.ptbError.Name = "ptbError";
            this.ptbError.Size = new System.Drawing.Size(18, 18);
            this.ptbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbError.TabIndex = 19;
            this.ptbError.TabStop = false;
            this.ptbError.Visible = false;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 310);
            this.Controls.Add(this.btnNoVer);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.ptbError);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox ptbError;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnNoVer;
        private FontAwesome.Sharp.IconButton btnVer;
        private System.Windows.Forms.Timer timer1;
    }
}