using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;

namespace Model.Models
{
    public class Partido : ModelBase
    {
        public short Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
    }
}
