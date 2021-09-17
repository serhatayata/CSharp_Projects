using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
namespace DAL.DAO
{
    public class KisilerDAO : DataContext
    {
        public static List<KisilerDetayDTO> KisilerGetir()
        {
            List<KisilerDetayDTO> liste = new List<KisilerDetayDTO>();
            var list = (from k in db.TBL_KISILERs
                        select new
                        {
                            KisiID = k.ID,
                            AD = k.AD,
                            SOYAD = k.SOYAD,
                            NUMARA = k.NUMARA,
                            SIFRE = k.SIFRE
                        }
                        ).OrderBy(x => x.KisiID).ToList();
            foreach (var item in list)
            {
                KisilerDetayDTO dto = new KisilerDetayDTO();
                dto.ID = item.KisiID;
                dto.AD = item.AD;
                dto.SOYAD = item.SOYAD;
                dto.NUMARA = item.NUMARA;
                dto.SIFRE = item.SIFRE;
                liste.Add(dto);
            }
            return liste;
        }

        public static List<TBL_KISILER> KisilerGetir(string v, string text)
        {
            return db.TBL_KISILERs.Where(x=> x.NUMARA == v &&  x.SIFRE == text).ToList();
        }
    }
}
