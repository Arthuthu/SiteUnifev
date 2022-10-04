using ProvaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ProvaLibrary
{
    public class BotoesDAO : Conexao
    {
        public List<BotoesModels> Listar()
        {
            List<BotoesModels> botoes = banco.Query<BotoesModels>("select * from Buttons").ToList();
            return botoes;
        }
    }
}
