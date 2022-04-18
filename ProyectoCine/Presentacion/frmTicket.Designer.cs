
namespace Presentacion
{
    partial class frmTicket
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumGeneral = new System.Windows.Forms.NumericUpDown();
            this.txtnumNiños = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSgt = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumNiños)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAL: (S/20.00)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIÑOS: (S/10.00)";
            // 
            // txtnumGeneral
            // 
            this.txtnumGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtnumGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumGeneral.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumGeneral.ForeColor = System.Drawing.Color.White;
            this.txtnumGeneral.Location = new System.Drawing.Point(341, 219);
            this.txtnumGeneral.Name = "txtnumGeneral";
            this.txtnumGeneral.Size = new System.Drawing.Size(120, 29);
            this.txtnumGeneral.TabIndex = 4;
            this.txtnumGeneral.ValueChanged += new System.EventHandler(this.txtnumGeneral_ValueChanged);
            // 
            // txtnumNiños
            // 
            this.txtnumNiños.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtnumNiños.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumNiños.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumNiños.ForeColor = System.Drawing.Color.White;
            this.txtnumNiños.Location = new System.Drawing.Point(341, 260);
            this.txtnumNiños.Name = "txtnumNiños";
            this.txtnumNiños.Size = new System.Drawing.Size(120, 29);
            this.txtnumNiños.TabIndex = 5;
            this.txtnumNiños.ValueChanged += new System.EventHandler(this.txtnumNiños_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(372, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "...";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 108);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnSgt
            // 
            this.btnSgt.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnSgt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnSgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSgt.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSgt.ForeColor = System.Drawing.Color.White;
            this.btnSgt.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnSgt.IconColor = System.Drawing.Color.White;
            this.btnSgt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSgt.IconSize = 150;
            this.btnSgt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSgt.Location = new System.Drawing.Point(191, 545);
            this.btnSgt.Name = "btnSgt";
            this.btnSgt.Size = new System.Drawing.Size(310, 192);
            this.btnSgt.TabIndex = 10;
            this.btnSgt.Text = "SIGUIENTE";
            this.btnSgt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSgt.UseVisualStyleBackColor = true;
            this.btnSgt.Click += new System.EventHandler(this.btnSgt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "S/";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(659, 1031);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSgt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtnumNiños);
            this.Controls.Add(this.txtnumGeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumNiños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtnumGeneral;
        private System.Windows.Forms.NumericUpDown txtnumNiños;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnSgt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}