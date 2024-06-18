using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class CandidatoDTO
    {
        public short? Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string Numero { get; set; } = String.Empty;
        public int Idade { get; set; }
        public short? PartidoId { get; set; }
        public int? Cargo { get; set; }
    }
}
