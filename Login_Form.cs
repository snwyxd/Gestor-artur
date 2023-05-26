using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Coloca a imagem user.png na picture box da janela
            pictureBox2.Image = Image.FromFile("../../imagens/user.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
