﻿using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {   
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlInicio = new System.Windows.Forms.TabControl();
            this.tabInicioLogin1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtboxNombreLoginAd = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtboxContraLoginAd = new System.Windows.Forms.TextBox();
            this.btmInicioLoginAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtboxUsuarioLoginUsua = new System.Windows.Forms.TextBox();
            this.btnHomeU = new System.Windows.Forms.Button();
            this.txtboxContraLoginUsua = new System.Windows.Forms.TextBox();
            this.btnLoginUsuario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlInicio.SuspendLayout();
            this.tabInicioLogin1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControlInicio, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControlInicio
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControlInicio, 2);
            this.tabControlInicio.Controls.Add(this.tabInicioLogin1);
            this.tabControlInicio.Controls.Add(this.tabControlAdmin);
            this.tabControlInicio.Controls.Add(this.tabUsuario);
            this.tabControlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInicio.Location = new System.Drawing.Point(3, 3);
            this.tabControlInicio.Name = "tabControlInicio";
            this.tableLayoutPanel1.SetRowSpan(this.tabControlInicio, 2);
            this.tabControlInicio.SelectedIndex = 0;
            this.tabControlInicio.Size = new System.Drawing.Size(687, 766);
            this.tabControlInicio.TabIndex = 0;
            // 
            // tabInicioLogin1
            // 
            this.tabInicioLogin1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabInicioLogin1.Controls.Add(this.label15);
            this.tabInicioLogin1.Controls.Add(this.label14);
            this.tabInicioLogin1.Controls.Add(this.label13);
            this.tabInicioLogin1.Controls.Add(this.label12);
            this.tabInicioLogin1.Controls.Add(this.groupBox1);
            this.tabInicioLogin1.Location = new System.Drawing.Point(4, 25);
            this.tabInicioLogin1.Name = "tabInicioLogin1";
            this.tabInicioLogin1.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicioLogin1.Size = new System.Drawing.Size(679, 737);
            this.tabInicioLogin1.TabIndex = 0;
            this.tabInicioLogin1.Text = "tabPage1";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Location = new System.Drawing.Point(609, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 574);
            this.label15.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Location = new System.Drawing.Point(24, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 574);
            this.label14.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(24, 642);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(622, 31);
            this.label13.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Location = new System.Drawing.Point(24, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(622, 31);
            this.label12.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUsuario);
            this.groupBox1.Location = new System.Drawing.Point(87, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 510);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(57, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(387, 100);
            this.label9.TabIndex = 7;
            this.label9.Text = "BINAES";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(57, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 79);
            this.label8.TabIndex = 3;
            this.label8.Text = "Inica sesión";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmin.Image = ((System.Drawing.Image) (resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmin.Location = new System.Drawing.Point(274, 338);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(170, 98);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(57, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 79);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Cómo deseas iniciar sessión?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Image = ((System.Drawing.Image) (resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(57, 338);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(170, 98);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabControlAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabControlAdmin.Controls.Add(this.groupBox2);
            this.tabControlAdmin.Controls.Add(this.label4);
            this.tabControlAdmin.Controls.Add(this.label3);
            this.tabControlAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlAdmin.Size = new System.Drawing.Size(675, 721);
            this.tabControlAdmin.TabIndex = 1;
            this.tabControlAdmin.Text = "Admin";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtboxNombreLoginAd);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.txtboxContraLoginAd);
            this.groupBox2.Controls.Add(this.btmInicioLoginAdmin);
            this.groupBox2.Location = new System.Drawing.Point(59, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 602);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(89, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 78);
            this.label11.TabIndex = 10;
            this.label11.Text = "Administrador";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(89, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "Contraseña";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(89, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(101, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(259, 26);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Recuerdame";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtboxNombreLoginAd
            // 
            this.txtboxNombreLoginAd.Location = new System.Drawing.Point(229, 180);
            this.txtboxNombreLoginAd.Multiline = true;
            this.txtboxNombreLoginAd.Name = "txtboxNombreLoginAd";
            this.txtboxNombreLoginAd.Size = new System.Drawing.Size(216, 28);
            this.txtboxNombreLoginAd.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.Image = ((System.Drawing.Image) (resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(468, 526);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 44);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtboxContraLoginAd
            // 
            this.txtboxContraLoginAd.Location = new System.Drawing.Point(229, 229);
            this.txtboxContraLoginAd.Multiline = true;
            this.txtboxContraLoginAd.Name = "txtboxContraLoginAd";
            this.txtboxContraLoginAd.PasswordChar = '*';
            this.txtboxContraLoginAd.Size = new System.Drawing.Size(216, 28);
            this.txtboxContraLoginAd.TabIndex = 4;
            // 
            // btmInicioLoginAdmin
            // 
            this.btmInicioLoginAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btmInicioLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmInicioLoginAdmin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btmInicioLoginAdmin.Location = new System.Drawing.Point(101, 353);
            this.btmInicioLoginAdmin.Name = "btmInicioLoginAdmin";
            this.btmInicioLoginAdmin.Size = new System.Drawing.Size(344, 54);
            this.btmInicioLoginAdmin.TabIndex = 5;
            this.btmInicioLoginAdmin.Text = "Login";
            this.btmInicioLoginAdmin.UseVisualStyleBackColor = false;
            this.btmInicioLoginAdmin.Click += new System.EventHandler(this.btmLoginAd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(92, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(115, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 1;
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabUsuario.Controls.Add(this.groupBox3);
            this.tabUsuario.Controls.Add(this.label7);
            this.tabUsuario.Controls.Add(this.label6);
            this.tabUsuario.Location = new System.Drawing.Point(4, 25);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(675, 721);
            this.tabUsuario.TabIndex = 2;
            this.tabUsuario.Text = "Usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Controls.Add(this.txtboxUsuarioLoginUsua);
            this.groupBox3.Controls.Add(this.btnHomeU);
            this.groupBox3.Controls.Add(this.txtboxContraLoginUsua);
            this.groupBox3.Controls.Add(this.btnLoginUsuario);
            this.groupBox3.Location = new System.Drawing.Point(63, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 577);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // txtboxUsuarioLoginUsua
            // 
            this.txtboxUsuarioLoginUsua.Location = new System.Drawing.Point(166, 172);
            this.txtboxUsuarioLoginUsua.Multiline = true;
            this.txtboxUsuarioLoginUsua.Name = "txtboxUsuarioLoginUsua";
            this.txtboxUsuarioLoginUsua.Size = new System.Drawing.Size(226, 31);
            this.txtboxUsuarioLoginUsua.TabIndex = 3;
            // 
            // btnHomeU
            // 
            this.btnHomeU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHomeU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeU.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHomeU.Image = ((System.Drawing.Image) (resources.GetObject("btnHomeU.Image")));
            this.btnHomeU.Location = new System.Drawing.Point(420, 488);
            this.btnHomeU.Name = "btnHomeU";
            this.btnHomeU.Size = new System.Drawing.Size(70, 48);
            this.btnHomeU.TabIndex = 7;
            this.btnHomeU.UseVisualStyleBackColor = true;
            this.btnHomeU.Click += new System.EventHandler(this.btnHomeU_Click);
            // 
            // txtboxContraLoginUsua
            // 
            this.txtboxContraLoginUsua.Location = new System.Drawing.Point(166, 236);
            this.txtboxContraLoginUsua.Multiline = true;
            this.txtboxContraLoginUsua.Name = "txtboxContraLoginUsua";
            this.txtboxContraLoginUsua.Size = new System.Drawing.Size(226, 31);
            this.txtboxContraLoginUsua.TabIndex = 4;
            // 
            // btnLoginUsuario
            // 
            this.btnLoginUsuario.Location = new System.Drawing.Point(186, 316);
            this.btnLoginUsuario.Name = "btnLoginUsuario";
            this.btnLoginUsuario.Size = new System.Drawing.Size(206, 54);
            this.btnLoginUsuario.TabIndex = 5;
            this.btnLoginUsuario.Text = "Login";
            this.btnLoginUsuario.UseVisualStyleBackColor = true;
            this.btnLoginUsuario.Click += new System.EventHandler(this.btnLoginUsuario_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(83, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 38);
            this.label7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(114, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 1;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(693, 772);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlInicio.ResumeLayout(false);
            this.tabInicioLogin1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnAdmin;

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHomeU;

        private System.Windows.Forms.TextBox txtboxContraLoginUsua;
        private System.Windows.Forms.Button btnLoginUsuario;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxUsuarioLoginUsua;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button btmInicioLoginAdmin;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxNombreLoginAd;
        private System.Windows.Forms.TextBox txtboxContraLoginAd;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TabPage tabUsuario;

        private System.Windows.Forms.TabControl tabControlInicio;
        private System.Windows.Forms.TabPage tabInicioLogin1;
        private System.Windows.Forms.TabPage tabControlAdmin;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        

        private void btmLoginAd_Click(object sender, EventArgs e)
        {
            using (frmPrincipal Ventana = new frmPrincipal())
            {
                DialogResult Resultado = Ventana.ShowDialog();
                if (Resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Your logged was succeed!!", "Cuenta Administrador", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                }

            }
        }

        private void btnLoginUsuario_Click(object sender, EventArgs e)
        {
            using (frmPrincipal Ventana = new frmPrincipal())
            {
                DialogResult Resultado = Ventana.ShowDialog();
                if (Resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Your logged was succeed!!", "Cuenta Usuario", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                }

            }
        }


        private void btnUsuario_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 2;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 0;
        }

        private void btnHomeU_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 0;
        }
    }
}