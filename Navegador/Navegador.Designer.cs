namespace Navegador
{
    partial class Frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            this.url_text = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_navegar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_stop = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pg_inicial = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_avancar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_voltar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_refresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // url_text
            // 
            this.url_text.BackColor = System.Drawing.Color.DarkGray;
            this.url_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url_text.FocusedLineColor = System.Drawing.Color.White;
            this.url_text.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_text.ForeColor = System.Drawing.Color.White;
            this.url_text.LineColor = System.Drawing.Color.Silver;
            this.url_text.Location = new System.Drawing.Point(-8, 0);
            this.url_text.Name = "url_text";
            this.url_text.PasswordChar = '\0';
            this.url_text.SelectedText = "";
            this.url_text.Size = new System.Drawing.Size(530, 35);
            this.url_text.TabIndex = 0;
            this.url_text.Text = "www.google.com.ao";
            this.url_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.url_text.TextOffsetX = 0;
            this.url_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url_text_KeyDown);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.Color.Silver;
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaGradientPanel1.Controls.Add(this.btn_navegar);
            this.gunaGradientPanel1.Controls.Add(this.btn_stop);
            this.gunaGradientPanel1.Controls.Add(this.pg_inicial);
            this.gunaGradientPanel1.Controls.Add(this.btn_avancar);
            this.gunaGradientPanel1.Controls.Add(this.btn_voltar);
            this.gunaGradientPanel1.Controls.Add(this.btn_refresh);
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel1);
            this.gunaGradientPanel1.Controls.Add(this.url_text);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.DimGray;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.GhostWhite;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.LightCyan;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1043, 42);
            this.gunaGradientPanel1.TabIndex = 1;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(1190, 0);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(138, 35);
            this.gunaAdvenceButton1.TabIndex = 10;
            this.gunaAdvenceButton1.Text = "Def.Pag.Inicial";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btn_navegar
            // 
            this.btn_navegar.AnimationHoverSpeed = 0.07F;
            this.btn_navegar.AnimationSpeed = 0.03F;
            this.btn_navegar.BaseColor = System.Drawing.Color.Transparent;
            this.btn_navegar.BorderColor = System.Drawing.Color.Black;
            this.btn_navegar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_navegar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_navegar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_navegar.CheckedImage = null;
            this.btn_navegar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_navegar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_navegar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_navegar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_navegar.ForeColor = System.Drawing.Color.White;
            this.btn_navegar.Image = null;
            this.btn_navegar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_navegar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_navegar.Location = new System.Drawing.Point(528, 0);
            this.btn_navegar.Name = "btn_navegar";
            this.btn_navegar.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_navegar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_navegar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_navegar.OnHoverImage = null;
            this.btn_navegar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_navegar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_navegar.Size = new System.Drawing.Size(100, 35);
            this.btn_navegar.TabIndex = 9;
            this.btn_navegar.Text = "Navegar";
            this.btn_navegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_navegar.Click += new System.EventHandler(this.btn_navegar_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.AnimationHoverSpeed = 0.07F;
            this.btn_stop.AnimationSpeed = 0.03F;
            this.btn_stop.BaseColor = System.Drawing.Color.Transparent;
            this.btn_stop.BorderColor = System.Drawing.Color.Black;
            this.btn_stop.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_stop.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_stop.CheckedForeColor = System.Drawing.Color.White;
            this.btn_stop.CheckedImage = null;
            this.btn_stop.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stop.FocusedColor = System.Drawing.Color.Empty;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Image = null;
            this.btn_stop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_stop.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_stop.Location = new System.Drawing.Point(634, 0);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_stop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_stop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_stop.OnHoverImage = null;
            this.btn_stop.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_stop.Size = new System.Drawing.Size(81, 35);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "Parar";
            this.btn_stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // pg_inicial
            // 
            this.pg_inicial.AnimationHoverSpeed = 0.07F;
            this.pg_inicial.AnimationSpeed = 0.03F;
            this.pg_inicial.BaseColor = System.Drawing.Color.Transparent;
            this.pg_inicial.BorderColor = System.Drawing.Color.Black;
            this.pg_inicial.CheckedBaseColor = System.Drawing.Color.Gray;
            this.pg_inicial.CheckedBorderColor = System.Drawing.Color.Black;
            this.pg_inicial.CheckedForeColor = System.Drawing.Color.White;
            this.pg_inicial.CheckedImage = null;
            this.pg_inicial.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pg_inicial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pg_inicial.FocusedColor = System.Drawing.Color.Empty;
            this.pg_inicial.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pg_inicial.ForeColor = System.Drawing.Color.White;
            this.pg_inicial.Image = null;
            this.pg_inicial.ImageSize = new System.Drawing.Size(20, 20);
            this.pg_inicial.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.pg_inicial.Location = new System.Drawing.Point(1047, 0);
            this.pg_inicial.Name = "pg_inicial";
            this.pg_inicial.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.pg_inicial.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pg_inicial.OnHoverForeColor = System.Drawing.Color.White;
            this.pg_inicial.OnHoverImage = null;
            this.pg_inicial.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pg_inicial.OnPressedColor = System.Drawing.Color.Black;
            this.pg_inicial.Size = new System.Drawing.Size(137, 35);
            this.pg_inicial.TabIndex = 7;
            this.pg_inicial.Text = "Pagina Inicial";
            this.pg_inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pg_inicial.Click += new System.EventHandler(this.pg_inicial_Click);
            // 
            // btn_avancar
            // 
            this.btn_avancar.AnimationHoverSpeed = 0.07F;
            this.btn_avancar.AnimationSpeed = 0.03F;
            this.btn_avancar.BaseColor = System.Drawing.Color.Transparent;
            this.btn_avancar.BorderColor = System.Drawing.Color.Black;
            this.btn_avancar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_avancar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_avancar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_avancar.CheckedImage = null;
            this.btn_avancar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_avancar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_avancar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_avancar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_avancar.ForeColor = System.Drawing.Color.White;
            this.btn_avancar.Image = null;
            this.btn_avancar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_avancar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_avancar.Location = new System.Drawing.Point(954, 0);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_avancar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_avancar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_avancar.OnHoverImage = null;
            this.btn_avancar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_avancar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_avancar.Size = new System.Drawing.Size(87, 35);
            this.btn_avancar.TabIndex = 4;
            this.btn_avancar.Text = "Avançar";
            this.btn_avancar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_avancar.Click += new System.EventHandler(this.btn_avancar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.AnimationHoverSpeed = 0.07F;
            this.btn_voltar.AnimationSpeed = 0.03F;
            this.btn_voltar.BaseColor = System.Drawing.Color.Transparent;
            this.btn_voltar.BorderColor = System.Drawing.Color.Black;
            this.btn_voltar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_voltar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_voltar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_voltar.CheckedImage = null;
            this.btn_voltar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_voltar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_voltar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_voltar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Image = null;
            this.btn_voltar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_voltar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_voltar.Location = new System.Drawing.Point(860, 0);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_voltar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_voltar.OnHoverImage = null;
            this.btn_voltar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_voltar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_voltar.Size = new System.Drawing.Size(88, 35);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AnimationHoverSpeed = 0.07F;
            this.btn_refresh.AnimationSpeed = 0.03F;
            this.btn_refresh.BaseColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.Black;
            this.btn_refresh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_refresh.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.CheckedForeColor = System.Drawing.Color.White;
            this.btn_refresh.CheckedImage = null;
            this.btn_refresh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_refresh.FocusedColor = System.Drawing.Color.Empty;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = null;
            this.btn_refresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_refresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_refresh.Location = new System.Drawing.Point(721, 0);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = null;
            this.btn_refresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Size = new System.Drawing.Size(133, 35);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Actualizar";
            this.btn_refresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(4, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 15);
            this.gunaLabel1.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1043, 429);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 471);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_principal";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox url_text;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_avancar;
        private Guna.UI.WinForms.GunaAdvenceButton btn_voltar;
        private Guna.UI.WinForms.GunaAdvenceButton btn_refresh;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_navegar;
        private Guna.UI.WinForms.GunaAdvenceButton btn_stop;
        private Guna.UI.WinForms.GunaAdvenceButton pg_inicial;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}

