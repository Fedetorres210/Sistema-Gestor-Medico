namespace Capa_Presentación
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMedico = new FontAwesome.Sharp.IconMenuItem();
            this.MenuPacientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuFuncionarios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCentros = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMedico,
            this.MenuPacientes,
            this.MenuFuncionarios,
            this.MenuCentros,
            this.MenuAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(951, 78);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMedico
            // 
            this.MenuMedico.AutoSize = false;
            this.MenuMedico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.MenuMedico.IconColor = System.Drawing.Color.Black;
            this.MenuMedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMedico.IconSize = 60;
            this.MenuMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMedico.Name = "MenuMedico";
            this.MenuMedico.Size = new System.Drawing.Size(95, 74);
            this.MenuMedico.Text = "Médicos";
            this.MenuMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuPacientes
            // 
            this.MenuPacientes.AutoSize = false;
            this.MenuPacientes.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.MenuPacientes.IconColor = System.Drawing.Color.Black;
            this.MenuPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuPacientes.IconSize = 60;
            this.MenuPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuPacientes.Name = "MenuPacientes";
            this.MenuPacientes.Size = new System.Drawing.Size(95, 74);
            this.MenuPacientes.Text = "Pacientes";
            this.MenuPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.AutoSize = false;
            this.MenuFuncionarios.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.MenuFuncionarios.IconColor = System.Drawing.Color.Black;
            this.MenuFuncionarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuFuncionarios.IconSize = 60;
            this.MenuFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(95, 74);
            this.MenuFuncionarios.Text = "Funcionarios";
            this.MenuFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuFuncionarios.Click += new System.EventHandler(this.MenuFuncionarios_Click);
            // 
            // MenuCentros
            // 
            this.MenuCentros.AutoSize = false;
            this.MenuCentros.IconChar = FontAwesome.Sharp.IconChar.HospitalWide;
            this.MenuCentros.IconColor = System.Drawing.Color.Black;
            this.MenuCentros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCentros.IconSize = 60;
            this.MenuCentros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCentros.Name = "MenuCentros";
            this.MenuCentros.Size = new System.Drawing.Size(95, 74);
            this.MenuCentros.Text = "Centros";
            this.MenuCentros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuCentros.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.AutoSize = false;
            this.MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercaDe.IconSize = 60;
            this.MenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Size = new System.Drawing.Size(152, 74);
            this.MenuAcercaDe.Text = "Acerca de";
            this.MenuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuAcercaDe.Click += new System.EventHandler(this.MenuAcercaDe_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.Crimson;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(951, 69);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Gestión Médica";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 147);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(951, 378);
            this.Contenedor.TabIndex = 3;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 525);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem MenuMedico;
        private FontAwesome.Sharp.IconMenuItem MenuPacientes;
        private FontAwesome.Sharp.IconMenuItem MenuFuncionarios;
        private FontAwesome.Sharp.IconMenuItem MenuCentros;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Contenedor;
    }
}

