using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaLibrary
{
    public class Conexao
    {
        public SqlConnection banco;

        public Conexao()
        {
            banco = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SiteUnifevDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
