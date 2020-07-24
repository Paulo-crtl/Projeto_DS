using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Produto
    {
        public int IdProduto { get; set; }
        public string CodBarras { get; set; }
        public string Nome { get; set; }
        public string Produto { get; set; }
        public string Preço { get; set; }
        public string Estoque { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string Tipo { get; set; }
        public string Ativo { get; set; }
        public string Acao { get; set; }
        public string Foto { get; set; }
    }
}
