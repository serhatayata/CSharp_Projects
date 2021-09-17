using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class MesajlarDAO : DataContext
    {
        public static List<MesajlarDetayDTO> GidenMesajGetir()
        {
            List<MesajlarDetayDTO> liste = new List<MesajlarDetayDTO>();
            var list = (from p in db.TBL_MESAJLARs
                        where p.GONDEREN == UserStatic.Numara
                        select new
                        {
                           MesajID = p.MESAJID,
                           Gonderen = p.GONDEREN,
                           Alici = p.ALICI,
                           Baslik = p.BASLIK,
                           Icerik = p.ICERIK
                        }
                        ).OrderBy(x => x.MesajID).ToList();
            foreach (var item in list)
            {
                MesajlarDetayDTO dto = new MesajlarDetayDTO();
                dto.MESAJID = item.MesajID;
                dto.GONDEREN = item.Gonderen;
                dto.ALICI = item.Alici;
                dto.BASLIK = item.Baslik;
                dto.ICERIK = item.Icerik;
                liste.Add(dto);
            }
            return liste;
        }

        public static void MesajEkle(TBL_MESAJLAR tb)
        {
            try
            {
                db.TBL_MESAJLARs.InsertOnSubmit(tb);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<MesajlarDetayDTO> GelenMesajGetir()
        {
            List<MesajlarDetayDTO> liste = new List<MesajlarDetayDTO>();
            var list = (from p in db.TBL_MESAJLARs
                        join k in db.TBL_KISILERs on p.ALICI equals k.NUMARA
                        join d in db.TBL_KISILERs on p.GONDEREN equals d.NUMARA
                        where p.ALICI == UserStatic.Numara
                        select new
                        {
                            MesajID = p.MESAJID,
                            Gonderen = k.AD +" "+ k.SOYAD,
                            Alici = d.AD+" "+d.SOYAD,
                            Baslik = p.BASLIK,
                            Icerik = p.ICERIK
                        }
                        ).OrderBy(x => x.MesajID).ToList();
            foreach (var item in list)
            {
                MesajlarDetayDTO dto = new MesajlarDetayDTO();
                dto.MESAJID = item.MesajID;
                dto.GONDEREN = item.Gonderen;
                dto.ALICI = item.Alici;
                dto.BASLIK = item.Baslik;
                dto.ICERIK = item.Icerik;
                liste.Add(dto);
            }
            return liste;
        }
    }
}
