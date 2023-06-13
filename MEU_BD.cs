using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gestor
{
    internal class MEU_BD
    {
        // conexao é o objeto que representa a conexão com o banco de dados
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username:root;password=;data=sga_estudantes_bd");
        public MySqlConnection getConexao
        {
            get { return conexao; }
        }
        // Método para ABRIR/INICIALIZAR a conexão
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            { 
                conexao.Open();
            }
        }
        // Método para fechar a conexão
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
