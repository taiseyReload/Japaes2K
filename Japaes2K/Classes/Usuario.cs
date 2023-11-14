using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japaes2K.Classes
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


        // Métodos:

        // Logar:
        public DataTable Logar()
        {
            string comando = "SELECT id, nome_completo, email, senha" +
                " FROM usuarios WHERE email = @email AND senha = @senha";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            // Substituir os 'coringas' por valores:
            cmd.Parameters.AddWithValue("@email", Email);
            // Obter o hash da senha:
            var hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta:
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public DataTable ListarTudo()
        {
            string comando = "SELECT id, nome_completo, email FROM usuarios";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta:
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO usuarios (nome_completo, email, senha) " +
                "VALUES (@nome_completo, @email, @senha)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@email", Email);
            // Obter o hash:
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
