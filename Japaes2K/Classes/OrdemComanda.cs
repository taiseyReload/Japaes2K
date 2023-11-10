using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japaes2K.Classes
{
    public class OrdemComanda
    {
        public int Id { get; set; }
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int IdResp { get; set; }
        public DateTime DataAdic { get; set; }
        public int Situacao { get; set; }
    }
}
