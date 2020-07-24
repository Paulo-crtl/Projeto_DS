using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace DAL
{
   public class DAL_Cadastro
    {
        public static string CadastrarUsuario(DTO_Usuario obj)
        {
            try
            //inicia o bloco de tratamento de exception
            {
                string script = "INSERT INTO Usuario(nome, email, userName, senha, tipo, ativo, CPF) VALUES(@nome, @email, @userName, @senha, 'cliente', 'ativo', @CPF); ";
                // cria a string com consulta sql
                SqlCommand cm = new SqlCommand(script, conexao.Conectar());
                //cria o comando para rodar a instrução, passando instrução sql e conexão
                cm.Parameters.AddWithValue("@nome", obj.Nome);
                cm.Parameters.AddWithValue("@email", obj.Email);
                cm.Parameters.AddWithValue("@userName", obj.UserName);
                cm.Parameters.AddWithValue("@senha", obj.Senha);
                cm.Parameters.AddWithValue("@CPF", obj.CPF);
                //substitui as variaveis na instrução sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                return "eai blz?";
            }
            catch (Exception ex)
            //esse bloco é executado caso aconteça exceção no bloco try
            {
                //ex = new Exception("erro");
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao.Conectar().State != ConnectionState.Closed)
                {
                    conexao.Conectar().Close();
                }
            }
        }
    }
}
