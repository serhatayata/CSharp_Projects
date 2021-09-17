using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;
namespace BLL
{
    public class MesajBLL
    {
        public static MesajlarDTO gidenKutusuGetir()
        {
            MesajlarDTO dto = new MesajlarDTO();
            dto.Mesajlar = MesajlarDAO.GidenMesajGetir();
            return dto;
        }

        public static MesajlarDTO gelenKutusuGetir()
        {
            MesajlarDTO dto = new MesajlarDTO();
            dto.Mesajlar = MesajlarDAO.GelenMesajGetir();
            return dto;
        }

        public static void MesajEkle(TBL_MESAJLAR tb)
        {
            MesajlarDAO.MesajEkle(tb);
        }
    }
}
