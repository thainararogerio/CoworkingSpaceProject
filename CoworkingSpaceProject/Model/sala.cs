using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Model
{
    class sala
    {
        public static string CD_SALA = "cd_sala";
        public static string NM_SALA = "nm_sala";
        public static string OBSERVACAO = "observacao";

        public int cd_sala { get; set; }

        public tp_sala tp_sala { get; set; }

        public string nm_sala { get; set; }
        public string observacao { get; set; }
}
}
