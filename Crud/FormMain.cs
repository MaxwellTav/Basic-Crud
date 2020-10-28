using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Está saliendo del programa, ¿Seguro de que quieres continuar?", "Atención, saliendo del programa...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //mostrar el form de visualizar
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            userControlView1.BringToFront();
            userControlView1.Visible = true;
            userControlAdd1.Visible = false;
        }

        //Al pasar el mouse por encima
        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            toolTipView.SetToolTip(bunifuImageButton1, "Click para ir.");
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            userControlAdd1.BringToFront();
            userControlAdd1.Visible = true;
            userControlView1.Visible = false;
        }

        private void bunifuImageButton2_MouseEnter(object sender, EventArgs e)
        {
            toolTipAdd.SetToolTip(bunifuImageButton2, "Click para ir.");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolTipExit.SetToolTip(button1, "Click para salir");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                toolTipMax.SetToolTip(button2, "Click para maximizar ventana");
            else
                toolTipMax.SetToolTip(button2, "Click para restaurar ventana");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            toolTipMin.SetToolTip(button3, "Click para minimizar ventana");
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            userControlView1.BringToFront();
            userControlView1.Visible = true;
            userControlAdd1.Visible = false;
        }
    }
}
