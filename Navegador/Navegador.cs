using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Frm_principal : Form
    {
    
        public Frm_principal()
        {
            InitializeComponent();
        }
        navegar navigation = new navegar();
        
        private void navegar(string url)
        {
            
            if(url_text != null)
            {
                webBrowser1.Navigate(url);
            }
            else
            {
                webBrowser1.Navigate("error404");
            }
            

        }
        private void Frm_principal_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(navigation.home);
        }
        private void pg_inicial_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(navigation.home);
        }
        private void btn_navegar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url_text.Text);
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void btn_avancar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            navigation.home = url_text.ToString();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void url_text_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                navegar(url_text.Text);
            }
        }
    }
}