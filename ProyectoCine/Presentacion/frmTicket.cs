using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Presentacion
{
    public partial class frmTicket : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsCineMgr objCineMgr = new clsCineMgr();
        DataTable tbl = new DataTable();
        int numbutaca;
        decimal result;
        int Pelicula;
        string hora;
        int sala;

        public frmTicket()
        {
            InitializeComponent();
            
        }
        void calcular()
        {
            decimal niño = txtnumNiños.Value * 10;
            decimal general = txtnumGeneral.Value * 20;
            result = niño + general;
            lblTotal.Text = Convert.ToString(result);
        }

        private void txtnumNiños_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtnumGeneral_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            generar();
        }

        public void detalle(int idpel)
        {
            Pelicula = idpel;
        }

        void generar()
        {
            tbl = objCineMgr.funcion(true, Pelicula, DateTime.Now.ToString("yyyy-MM-dd"));
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Text = tbl.Rows[i][0].ToString();
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.Font= new Font("Century Gothic", 15.5f);
                btn.Width = 138;
                btn.Height = 50;
                btn.Tag = tbl.Rows[i][1].ToString();
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach  (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.Tag != sala.ToString())
                {
                    btn.BackColor = Color.FromArgb(39, 57, 80);
                    btn.FlatAppearance.BorderColor = Color.Gray;
                }
            }
            ((Button)sender).BackColor = Color.SteelBlue;
            ((Button)sender).FlatAppearance.BorderColor = Color.Yellow;
            hora = ((Button)sender).Text;
            sala = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnSgt_Click(object sender, EventArgs e)
        {
            numbutaca = Convert.ToInt32(txtnumGeneral.Value) + Convert.ToInt32(txtnumNiños.Value);
            if (numbutaca != 0)
            {
                frmButaca frm = new frmButaca();
                frm.detalle(Pelicula, sala, hora, numbutaca, result);
                frm.Show();
                this.Hide();
            }
        }
    }
}
