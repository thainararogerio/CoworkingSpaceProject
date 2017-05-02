using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Model
{
    class equipamento
    {
        public static string CD_EQUIPAMENTO = "cd_equipamento";
        public static string SERIE = "serie";

        public int cd_equipamento { get; set; }

        public tp_equipamento tp_equipamento { get; set; }

        public string serie { get; set; }
    }
}
