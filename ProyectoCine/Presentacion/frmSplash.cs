﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Presentacion
{
    public partial class frmSplash : Form
    {
        int count;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSpalsh_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "" + clsEmpleado.nombre + " " + clsEmpleado.apellido + "";
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            count += 1;

            if (count == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
            }
        }
    }
}
