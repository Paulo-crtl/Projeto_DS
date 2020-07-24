using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Produto
    {
        public static string CadProduto(DTO_Produto obj)
        {
            if (string.IsNullOrWhiteSpace(obj.CodBarras))
            {
                throw new Exception("Campo código de barras vazio");
            }
            try
            {
                Convert.ToInt64(obj.CodBarras);
            }
            catch
            {
                throw new Exception("Código de barras deve ser numérico!");
            }
            if (obj.CodBarras.Length != 13)
            {
                throw new Exception("Código de barras deve ter 13 digitos!");
            }
            if (obj.Acao == "cadastro")
            {
                bool retorno = DAL_Produto.ValidarCodBarras(obj.CodBarras);
            
                  if (retorno == true)
                  {
                      throw new Exception("Código de barras já esta em uso!");
                  }
            }
            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                throw new Exception("Campo nome vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.Descricao))
            {
                throw new Exception("Campo descrição vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.Preço))
            {
                throw new Exception("Campo preço vazio");
            }
            try
            {
                Convert.ToDouble(obj.Preço);
            }
            catch
            {
                throw new Exception("Preço deve ser numérico!");
            }
            if (string.IsNullOrWhiteSpace(obj.Estoque))
            {
                throw new Exception("Campo estoque vazio");
            }
            try
            {
                Convert.ToInt32(obj.Estoque);
            }
            catch
            {
                throw new Exception("Estoque deve ser numérico!");
            }
            if (string.IsNullOrWhiteSpace(obj.Unidade))
            {
                throw new Exception("Campo unidade vazio");
            }
            try
            {
                Convert.ToInt32(obj.Unidade);
            }
            catch
            {
                throw new Exception("Estoque deve ser numérico!");
            }
            if (obj.Acao == "cadastro")
            {
                if (string.IsNullOrWhiteSpace(obj.Tipo))
                {
                    throw new Exception("Campo tipo vazio");
                }
            }
            if (string.IsNullOrWhiteSpace(obj.Ativo))
            {
                throw new Exception("Selecione se o produto está ativo ou inativo!");
            }

            switch (obj.Acao)
            {
                case "cadastro":
                    return DAL_Produto.CadProduto(obj);
                
                case "alteracao":
                    return DAL_Produto.AlterarProduto(obj);
                default:
                    throw new Exception("algo errado aconteceu!");
            }
            
        }

        public static DTO_Produto BuscarProduto (string codBarras)
        {
            if (string.IsNullOrWhiteSpace(codBarras))
            {
                throw new Exception("Digite o código de barras do produto!");
            }
            try
            {
                Convert.ToInt64(codBarras);
            }
            catch
            {
                throw new Exception("Código de barras deve ser numérico!");
            }
            if (codBarras.Length != 13)
            {
                throw new Exception("Código de barras deve ter 13 digitos!");
            }
            return DAL_Produto.BuscarProduto(codBarras);
        }
    }
}
