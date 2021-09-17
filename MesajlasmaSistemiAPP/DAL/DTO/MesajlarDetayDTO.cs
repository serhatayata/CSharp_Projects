using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class MesajlarDetayDTO
    {
        public int MESAJID { get; set; }
        public string GONDEREN { get; set; }
        public string ALICI { get; set; }
        public string BASLIK { get; set; }
        public string ICERIK { get; set; }
    }
}
