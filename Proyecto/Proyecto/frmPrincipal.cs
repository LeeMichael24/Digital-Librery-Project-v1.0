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
            tcPrincipal.SelectedIndex = 0;
            
        }

        private void btmEvento_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 1;
        }

        private void btmColeccion_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 2;
            //Asegurarse que salga vacio cada textbox
            txtAuditorio_piso01.Clear();
            txtBiblio_piso01.Clear();
            txtComputo_piso01.Clear();
            txtInclusion_piso01.Clear();
            txtLudico_piso01.Clear();
            //Para area biblioteca piso 01
            List<Area> biblioteca = funcionesUtilitarias.funcionMostrar(1, "Biblioteca variada"); //Mando 1 porque es el primer piso
            //Aqui esta el problema
            txtBiblio_piso01.AppendText(biblioteca.ToString());
            txtBiblio_piso01.AppendText(biblioteca + Environment.NewLine);
            //Para area ludica piso 01
            List<Area> inclusion = funcionesUtilitarias.funcionMostrar(1, "salon para menores de edad"); //Mando 1 porque es el primer piso
            txtInclusion_piso01.AppendText(inclusion.AreaNombre + ": " + inclusion.AreaDescripcion + " - ");
            txtInclusion_piso01.AppendText(inclusion.AreaHorario + Environment.NewLine);
            //Para area computacion piso 01
            List<Area> computo = funcionesUtilitarias.funcionMostrar(1, "Area de computo"); //Mando 1 porque es el primer piso
            txtComputo_piso01.AppendText(computo.AreaNombre + ": " + computo.AreaDescripcion + " - ");
            txtComputo_piso01.AppendText(computo.AreaHorario + Environment.NewLine);
            //Para area auditorium piso 01
            List<Area> auditorio = funcionesUtilitarias.funcionMostrar(1, "Auditorium para conferencias/peliculas"); //Mando 1 porque es el primer piso
            txtAuditorio_piso01.AppendText(auditorio.AreaNombre + ": " + auditorio.AreaDescripcion + " - ");
            txtAuditorio_piso01.AppendText(auditorio.AreaHorario + Environment.NewLine);
        }

        private void btmBusqueda_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 3;
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = EjemplarDAO.obtenerTodos();
        }

        private void btmPrestamo_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 4;
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

        private void btmPlanta4_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 3;
        }

        private void tabInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControlAreasPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}