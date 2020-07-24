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
    public class DAL_Login
    {
        public static DTO_Usuario ValidarLogin(DTO_Login obj)
        {
            try
            //inicia o bloco de tratamento de exception
            {
                string script = "SELECT * FROM Usuario WHERE(userName = @login OR email = @login) " +
                    "AND senha = @senha AND ativo = 'ativo'; ";
                // cria a string com consulta sql
                SqlCommand cm = new SqlCommand(script, conexao.Conectar());
                //cria o comando para rodar a instrução, passando instrução sql e conexão
                cm.Parameters.AddWithValue("@login", obj.Usuario);
                cm.Parameters.AddWithValue("@senha", obj.Senha);
                //substitui as variaveis na instrução sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a instrução sql e atribui resultado no SqlDataReader

                DTO_Usuario usuario = new DTO_Usuario();

                while (dados.Read())
                //le a proxima linha do resultado da sua instrução
                {
                    if (dados.HasRows)
                    //verifica se existe a linha com as credenciais
                    {
                        usuario.idUsuario = int.Parse(dados["idUsuario"].ToString());
                        usuario.Nome = dados["nome"].ToString();
                        usuario.Email = dados["email"].ToString();
                        usuario.UserName = dados["userName"].ToString();
                        usuario.Senha = dados["senha"].ToString();
                        usuario.Tipo = dados["tipo"].ToString();
                        usuario.Ativo = dados["ativo"].ToString();
                        usuario.CPF = dados["CPF"].ToString();
                        usuario.StatusLogin = true;
                        return usuario;
                    }
                }
                usuario.StatusLogin = false;
                return usuario;
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