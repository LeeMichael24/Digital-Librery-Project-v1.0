using System;
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlInicio = new System.Windows.Forms.TabControl();
            this.tabInicioLogin1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlAdmin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btmInicioLoginAdmin = new System.Windows.Forms.Button();
            this.txtboxContraLoginAd = new System.Windows.Forms.TextBox();
            this.txtboxNombreLoginAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoginUsuario = new System.Windows.Forms.Button();
            this.txtboxContraLoginUsua = new System.Windows.Forms.TextBox();
            this.txtboxUsuarioLoginUsua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlInicio.SuspendLayout();
            this.tabInicioLogin1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabUsuario.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 795);
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
            this.tabControlInicio.Size = new System.Drawing.Size(625, 789);
            this.tabControlInicio.TabIndex = 0;
            // 
            // tabInicioLogin1
            // 
            this.tabInicioLogin1.Controls.Add(this.label8);
            this.tabInicioLogin1.Controls.Add(this.button4);
            this.tabInicioLogin1.Controls.Add(this.button3);
            this.tabInicioLogin1.Controls.Add(this.tableLayoutPanel2);
            this.tabInicioLogin1.Location = new System.Drawing.Point(4, 25);
            this.tabInicioLogin1.Name = "tabInicioLogin1";
            this.tabInicioLogin1.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicioLogin1.Size = new System.Drawing.Size(617, 760);
            this.tabInicioLogin1.TabIndex = 0;
            this.tabInicioLogin1.Text = "tabPage1";
            this.tabInicioLogin1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(615, 84);
            this.label8.TabIndex = 3;
            this.label8.Text = "Inicio de sessión";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 89);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 91);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(614, 110);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tableLayoutPanel2.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(608, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido/a a BINAES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.tabControlAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabControlAdmin.Controls.Add(this.button1);
            this.tabControlAdmin.Controls.Add(this.btmInicioLoginAdmin);
            this.tabControlAdmin.Controls.Add(this.txtboxContraLoginAd);
            this.tabControlAdmin.Controls.Add(this.txtboxNombreLoginAd);
            this.tabControlAdmin.Controls.Add(this.label4);
            this.tabControlAdmin.Controls.Add(this.label3);
            this.tabControlAdmin.Controls.Add(this.label2);
            this.tabControlAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlAdmin.Size = new System.Drawing.Size(615, 752);
            this.tabControlAdmin.TabIndex = 1;
            this.tabControlAdmin.Text = "Admin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btmInicioLoginAdmin
            // 
            this.btmInicioLoginAdmin.Location = new System.Drawing.Point(175, 315);
            this.btmInicioLoginAdmin.Name = "btmInicioLoginAdmin";
            this.btmInicioLoginAdmin.Size = new System.Drawing.Size(201, 54);
            this.btmInicioLoginAdmin.TabIndex = 5;
            this.btmInicioLoginAdmin.Text = "Login";
            this.btmInicioLoginAdmin.UseVisualStyleBackColor = true;
            this.btmInicioLoginAdmin.Click += new System.EventHandler(this.btmLoginAd_Click);
            // 
            // txtboxContraLoginAd
            // 
            this.txtboxContraLoginAd.Location = new System.Drawing.Point(212, 226);
            this.txtboxContraLoginAd.Multiline = true;
            this.txtboxContraLoginAd.Name = "txtboxContraLoginAd";
            this.txtboxContraLoginAd.PasswordChar = '*';
            this.txtboxContraLoginAd.Size = new System.Drawing.Size(216, 28);
            this.txtboxContraLoginAd.TabIndex = 4;
            // 
            // txtboxNombreLoginAd
            // 
            this.txtboxNombreLoginAd.Location = new System.Drawing.Point(212, 178);
            this.txtboxNombreLoginAd.Multiline = true;
            this.txtboxNombreLoginAd.Name = "txtboxNombreLoginAd";
            this.txtboxNombreLoginAd.Size = new System.Drawing.Size(216, 28);
            this.txtboxNombreLoginAd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 102);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio de sesión como \"Administrador\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.tabUsuario.Controls.Add(this.button2);
            this.tabUsuario.Controls.Add(this.btnLoginUsuario);
            this.tabUsuario.Controls.Add(this.txtboxContraLoginUsua);
            this.tabUsuario.Controls.Add(this.txtboxUsuarioLoginUsua);
            this.tabUsuario.Controls.Add(this.label7);
            this.tabUsuario.Controls.Add(this.label6);
            this.tabUsuario.Controls.Add(this.label5);
            this.tabUsuario.Location = new System.Drawing.Point(4, 25);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(615, 752);
            this.tabUsuario.TabIndex = 2;
            this.tabUsuario.Text = "Usuario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLoginUsuario
            // 
            this.btnLoginUsuario.Location = new System.Drawing.Point(176, 318);
            this.btnLoginUsuario.Name = "btnLoginUsuario";
            this.btnLoginUsuario.Size = new System.Drawing.Size(206, 54);
            this.btnLoginUsuario.TabIndex = 5;
            this.btnLoginUsuario.Text = "Login";
            this.btnLoginUsuario.UseVisualStyleBackColor = true;
            this.btnLoginUsuario.Click += new System.EventHandler(this.btnLoginUsuario_Click);
            // 
            // txtboxContraLoginUsua
            // 
            this.txtboxContraLoginUsua.Location = new System.Drawing.Point(210, 235);
            this.txtboxContraLoginUsua.Multiline = true;
            this.txtboxContraLoginUsua.Name = "txtboxContraLoginUsua";
            this.txtboxContraLoginUsua.Size = new System.Drawing.Size(226, 31);
            this.txtboxContraLoginUsua.TabIndex = 4;
            // 
            // txtboxUsuarioLoginUsua
            // 
            this.txtboxUsuarioLoginUsua.Location = new System.Drawing.Point(210, 185);
            this.txtboxUsuarioLoginUsua.Multiline = true;
            this.txtboxUsuarioLoginUsua.Name = "txtboxUsuarioLoginUsua";
            this.txtboxUsuarioLoginUsua.Size = new System.Drawing.Size(226, 31);
            this.txtboxUsuarioLoginUsua.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 38);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contraseña :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "Usuario :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(2, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(530, 110);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inicio de sesión como \"Usuario\"";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(631, 795);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlInicio.ResumeLayout(false);
            this.tabInicioLogin1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabControlAdmin.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox txtboxContraLoginUsua;
        private System.Windows.Forms.Button btnLoginUsuario;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxUsuarioLoginUsua;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button btmInicioLoginAdmin;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxNombreLoginAd;
        private System.Windows.Forms.TextBox txtboxContraLoginAd;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabPage tabUsuario;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

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
        
        private void btnAdmistradorLogin_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 1;
        }
        
        private void btnUsuarioLogin_Click_1(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 2;
        }
        
    }
}