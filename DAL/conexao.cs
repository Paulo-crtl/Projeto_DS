using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class conexao
    {
        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PDS_EAD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //pegar propriedades do banco 
                conn.Open();
                return conn;
            }
            catch
            {
                throw new Exception("Não foi possivel se conectar. Tentar novamente");
            }
        }
    }
}
