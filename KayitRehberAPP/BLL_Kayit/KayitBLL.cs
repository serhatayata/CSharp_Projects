using DAL_Kayit.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Kayit;
using DAL_Kayit.DAO;
using DAL_Kayit.DTO;

namespace BLL_Kayit
{
    public class KayitBLL
    {
        public static KayitDTO GetAll()
        {
            KayitDTO dto = new KayitDTO();
            dto.Kisiler = KayitDAO.KayitGetir();
            return dto;
        }

        public static void KayitEkle(KISILER kayitt)
        {
            KayitDAO.KayitEkle(kayitt);
        }

        public static void KayitGuncelle(KayitDetayDTO kayit)
        {
            KayitDAO.KayitGuncelle(kayit);
        }

        public static void KayitSil(KayitDetayDTO kayit)
        {
            KayitDAO.KayitSil(kayit);
        }
    }
}
