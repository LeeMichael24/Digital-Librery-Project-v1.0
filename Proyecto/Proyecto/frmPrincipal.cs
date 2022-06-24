using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            
            gdvEventos.DataSource = null;
            gdvEventos.DataSource = EventosDAO.mostrarTodo();
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
            foreach (var a in AreaDAO.FiltrarPorPiso(1, "Biblioteca variada"))
            {
                txtBiblio_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            
            //Para area ludica piso 01
            foreach (var a in AreaDAO.FiltrarPorPiso(1, "salon para menores de edad"))
            {
                txtLudico_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            
            /*List<Area> inclusion = funcionesUtilitarias.funcionMostrar(1, "salon para menores de edad"); //Mando 1 porque es el primer piso
            txtInclusion_piso01.AppendText(inclusion.AreaNombre + ": " + inclusion.AreaDescripcion + " - ");
            txtInclusion_piso01.AppendText(inclusion.AreaHorario + Environment.NewLine);
            //Para area computacion piso 01
            List<Area> computo = funcionesUtilitarias.funcionMostrar(1, "Area de computo"); //Mando 1 porque es el primer piso
            txtComputo_piso01.AppendText(computo.AreaNombre + ": " + computo.AreaDescripcion + " - ");
            txtComputo_piso01.AppendText(computo.AreaHorario + Environment.NewLine);
            //Para area auditorium piso 01
            List<Area> auditorio = funcionesUtilitarias.funcionMostrar(1, "Auditorium para conferencias/peliculas"); //Mando 1 porque es el primer piso
            txtAuditorio_piso01.AppendText(auditorio.AreaNombre + ": " + auditorio.AreaDescripcion + " - ");
            txtAuditorio_piso01.AppendText(auditorio.AreaHorario + Environment.NewLine);*/
        }

        private void btmBusqueda_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 3;
            
            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = EjemplarDAO.obtenerTodos();
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
            string target = "https://www.google.com/maps/place/Biblioteca+Nacional+Francisco+Gavidia,+4+Calle+Ote.,+San+Salvador/@13.6969018,-89.1933095,17z/data=!3m1!4b1!4m5!3m4!1s0x8f6330e9bea6d59b:0x910e93d503e1f523!8m2!3d13.6969251!4d-89.191056";
            System.Diagnostics.Process.Start(target);
        }

        private void lblBienvenidosInicio_Click(object sender, EventArgs e)
        {
            
        }
    }
}