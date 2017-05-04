using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Model
{
    class multa
    {
        public static string CD_MULTA = "cd_multa";
        public static string CD_RESERVA = "cd_reserva";
        public static string VL_MULTA = "vl_multa";
        public static string DT_PAGTO = "dt_pagto";
        
        public int cd_multa { get; set; }
        public int cd_reserva { get; set; }
        public float vl_multa { get; set; }
        public DateTime dt_pagto { get; set; }
        
    }
}
