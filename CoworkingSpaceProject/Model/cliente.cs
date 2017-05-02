using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Model
{
    class cliente
    {
        public static string CD_CLIENTE = "cd_cliente";
        public static string NM_CLIENTE = "nm_cliente";
        public static string DS_LOGRADOURO = "ds_logradouro";
        public static string DS_COMPLEMENTO = "ds_complemento";
        public static string DS_BAIRRO = "ds_bairro";
        public static string NR_TELEFONE_RES = "nr_telefone_res";
        public static string NR_TELEFONE_COM = "nr_telefone_com";
        public static string NR_TELEFONE_CEL = "nr_telefone_cel";
        public static string DS_EMAIL = "ds_email";

        public int cd_cliente { get; set; }
        public cliente responsavel { get; set; }
        public localidade localidade { get; set; }
        public string nm_cliente { get; set; }
        public string ds_logradouro { get; set; }
        public string ds_complemento { get; set; }
        public string ds_bairro { get; set; }
        public string nr_telefone_res { get; set; }
        public string nr_telefone_com { get; set; }
        public string nr_telefone_cel { get; set; }
        public string ds_email { get; set; }
    }
}
