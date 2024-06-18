using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Helpers
{
    public static class Enum
    {
        public enum Cargo
        {
            [Description("Prefeito")]
            Prefeito = 1,
            [Description("Vereador")]
            Vereador = 2,
            [Description("Presidente")]
            Presidente = 3,
            [Description("Governador")]
            Governador = 4,
            [Description("Deputado Estadual")]
            DeputadoEstadual = 5,
            [Description("Deputado Federal")]
            DeputadoFederal = 6
        }
    }
}
