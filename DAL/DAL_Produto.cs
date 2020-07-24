using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_Produto
    {
        public static string CadProduto(DTO_Produto obj)
        {
            try
            {
                string script = "INSERT INTO Produto (codBarras, nome, descricao, preco, estoque, unidade, tipo, ativo) VALUES (@codBarras, @nome, @descricao, @preco, @estoque, @unidade, @tipo, @ativo)";
                SqlCommand cm = new SqlCommand(script, conexao.Conectar());
                cm.Parameters.AddWithValue("@codBarras", obj.CodBarras);
                cm.Parameters.AddWithValue("@nome", obj.Nome);
                cm.Parameters.AddWithValue("@descricao", obj.Descricao);
                cm.Parameters.AddWithValue("@preco", obj.Preço);
                cm.Parameters.AddWithValue("@estoque", obj.Estoque);
                cm.Parameters.AddWithValue("@unidade", obj.Unidade);
                cm.Parameters.AddWithValue("@tipo", obj.Tipo);
                cm.Parameters.AddWithValue("@ativo", obj.Ativo);

                cm.ExecuteNonQuery();

                return "Produto cadastrado com sucesso!";

            }
            catch (Exception ex)
            {
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

        public static DTO_Produto BuscarProduto(string codBarras)
        {
            try
            {
                string script = "SELECT * FROM Produto WHERE codBarras = @codBarras";
                SqlCommand cm = new SqlCommand(script, conexao.Conectar());

                cm.Parameters.AddWithValue("@codBarras", codBarras);

                SqlDataReader dados = cm.ExecuteReader();

                while (dados.Read())
                {
                    if (dados.HasRows)
                    {
                        DTO_Produto produto = new DTO_Produto();
                        produto.IdProduto = int.Parse(dados["idProduto"].ToString());
                        produto.CodBarras = dados["codBarras"].ToString();
                        produto.Nome = dados["nome"].ToString();
                        produto.Descricao = dados["descricao"].ToString();
                        produto.Preço = dados["preco"].ToString();
                        produto.Estoque = dados["estoque"].ToString();
                        produto.Unidade = dados["unidade"].ToString();
                        produto.Tipo = dados["tipo"].ToString();
                        produto.Ativo = dados["ativo"].ToString();

                        return produto;
                    }

                }
                throw new Exception("produto não encontrado");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na conexão" + ex.Message);
            }
            finally 
            {
                if (conexao.Conectar().State != ConnectionState.Closed)
                {
                    conexao.Conectar().Close();
                }
            }
        }

        public static bool ValidarCodBarras(string codBarras)
        {
            try
            {
                string script = "SELECT * FROM Produto WHERE codBarras = @codBarras";
                SqlCommand cm = new SqlCommand(script, conexao.Conectar());

                cm.Parameters.AddWithValue("@codBarras", codBarras);

                SqlDataReader dados = cm.ExecuteReader();

                while (dados.Read())
                {
                    if (dados.HasRows)
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na conexão " + ex.Message);
            }
            finally 
            {
                if (conexao.Conectar().State != ConnectionState.Closed)
                {
                    conexao.Conectar().Close();
                }
            }
        }

        public static string AlterarProduto(DTO_Produto obj)
        {
            try
            {
                string script = "UPDATE Produto SET codBarras = @codBarras, nome = @nome, descricao = @descricao, preco = @preco, estoque = @estoque, unidade = @unidade, tipo = @tipo, ativo = @ativo WHERE idProduto = @idProduto";
                SqlCommand cm = new SqlCommand(script, conexao.Conectar());
                cm.Parameters.AddWithValue("@idProduto", obj.IdProduto);
                cm.Parameters.AddWithValue("@codBarras", obj.CodBarras);
                cm.Parameters.AddWithValue("@nome", obj.Nome);
                cm.Parameters.AddWithValue("@descricao", obj.Descricao);
                cm.Parameters.AddWithValue("@preco", obj.Preço);
                cm.Parameters.AddWithValue("@estoque", obj.Estoque);
                cm.Parameters.AddWithValue("@unidade", obj.Unidade);
                cm.Parameters.AddWithValue("@tipo", obj.Tipo);
                cm.Parameters.AddWithValue("@ativo", obj.Ativo);

                cm.ExecuteNonQuery();

                return "Produto alterado com sucesso!";

            }
            catch (Exception ex)
            {
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
