using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_click(object sender, EventArgs e)
        {
            MEU_BD bancoDeDados = new MEU_BD();

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `usuario` WHERE `username` = @usn And `senha` =  @psw", bancoDeDados.getConexao);
            // atualizando os valores do comando acima
            comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsuario.Text;
            comando.Parameters.Add("@psw", MySqlDbType.VarChar).Value = txtSenha.Text;

            adaptador.SelectCommand = comando;

            adaptador.Fill(tabela);

            if (tabela.Rows.Count > 0)
            {
                MessageBox.Show("YES");
            }
            else 
            {
                MessageBox.Show("Usuário ou senha  inválidos", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}
