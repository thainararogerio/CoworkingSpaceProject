using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Model
{
    class reserva
    {
        public static string CD_RESERVA = "cd_reserva";
        public static string CD_CLIENTE = "cd_cliente";
        public static string CD_SALA = "cd_sala";
        public static string DT_ENTRADA = "dt_entrada";
        public static string DT_SAIDA = "dt_saida";
        public static string VL_RESERVA = "vl_reserva";
        public static string FL_PAGO = "fl_pago";

        public int cd_reserva { get; set; }
        public int cd_cliente { get; set; }
        public int cd_sala { get; set; }
        public DateTime dt_entrada { get; set; }
        public DateTime dt_saida { get; set; }
        public float vl_reserva { get; set; }
        public bool fl_pago { get; set; }
    }
}
