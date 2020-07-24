using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Cadastro
    {
        public static string ValidarCadastro(DTO_Usuario obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                throw new Exception("Nome vazio");
            }
            if (obj.CPF.Length != 11)
            {
                throw new Exception("o CPF deve conter 11 digitos");
            }
            if (string.IsNullOrWhiteSpace(obj.UserName))
            {
                throw new Exception("Nom de de usuário vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.Email))
            {
                throw new Exception("Email vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.Senha))
            {
                throw new Exception("Senha vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.SenhaC))
            {
                throw new Exception("Confirmar senha vazio");
            }
            if (obj.Senha != obj.SenhaC)
            {
                throw new Exception("As senhas não correspondem");
            }
            return DAL_Cadastro.CadastrarUsuario(obj);
        }
    }
}
