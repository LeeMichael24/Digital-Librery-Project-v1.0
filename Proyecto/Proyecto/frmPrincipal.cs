using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Properties;

namespace Proyecto
{
    public partial class frmPrincipal : Form
    {
        private List<Bitmap> ImagenesInicioSlide;
        public frmPrincipal()
        {
            InitializeComponent();
            ImagenesInicioSlide = new List<Bitmap>();
            //ImagenesInicioSlide.Add(Resources._6);
            //ImagenesInicioSlide.Add(Resources._5);
            //ImagenesInicioSlide.Add(Resources._4);
            //ImagenesInicioSlide.Add(Resources._3);
           // ImagenesInicioSlide.Add(Resources._2);

        }

        private void btmInicio_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            
        }

        private void btmEvento_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btmColeccion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void btmBusqueda_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void btmPrestamo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void btmPlanta1_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 0;
        }

        private void btmPlanta2_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 3;
        }
    }
}