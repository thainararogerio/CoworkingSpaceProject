using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Model
{
    class sala_equipamento
    {
        public static string DT_RECEBIDO = "dt_recebido";

        public DateTime dt_recebido { get; set; }
        public sala sala { get; set; }
        public equipamento equipamento { get; set; }
    }
}
