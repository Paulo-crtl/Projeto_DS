using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Usuario
    {
        public int idUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string SenhaC { get; set; }
        public string Tipo { get; set; }
        public string Ativo { get; set; }
        public string CPF { get; set; }
        public bool StatusLogin { get; set; }
    }
}
