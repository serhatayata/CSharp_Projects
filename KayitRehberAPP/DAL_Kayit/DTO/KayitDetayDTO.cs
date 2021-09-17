using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Kayit.DTO
{
    public class KayitDetayDTO
    {
        public int Kayit_ID { get; set; }
        public string Kayit_Ad { get; set; }
        public string Kayit_Soyad { get; set; }
        public string Kayit_Telefon { get; set; }
        public string Kayit_Mail { get; set; }
    }
}
