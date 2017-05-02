using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Model
{
    class localidade
    {
        public static string NR_LOCALIDADE = "nr_localidade";
        public static string NM_LOCALIDADE = "nm_localidade";
        public static string SG_UF = "sg_uf";

        public int nr_localidade { get; set; }
        public string nm_localidade { get; set; }
        public string sg_uf { get; set; }
    }
}
