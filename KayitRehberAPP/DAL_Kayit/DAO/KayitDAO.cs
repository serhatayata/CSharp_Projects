using DAL_Kayit.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Kayit.DAO
{
    public class KayitDAO : DataContext
    {
        public static List<KayitDetayDTO> KayitGetir()
        {
            List<KayitDetayDTO> liste = new List<KayitDetayDTO>();
            var list = (from p in db.KISILERs
                        select new
                        {
                            KayitID = p.ID,
                            KayitAd = p.AD,
                            KayitSoyad = p.SOYAD,
                            KayitTelefon = p.TELEFON,
                            KayitMail = p.MAIL
                        }
                );
            foreach (var item in list)
            {
                KayitDetayDTO dto = new KayitDetayDTO();
                dto.Kayit_ID = item.KayitID;
                dto.Kayit_Ad = item.KayitAd;
                dto.Kayit_Soyad = item.KayitSoyad;
                dto.Kayit_Telefon = item.KayitTelefon;
                dto.Kayit_Mail = item.KayitMail;
                liste.Add(dto);
            }
            return liste;
        }

        public static void KayitSil(KayitDetayDTO kayit)
        {
            try
            {
                var deleteOrder = (from x in db.KISILERs
                                   where x.ID == kayit.Kayit_ID
                                   select x
               );
                foreach (var item in deleteOrder)
                {
                    db.KISILERs.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void KayitGuncelle(KayitDetayDTO kayit)
        {
            try
            {
                KISILER k = db.KISILERs.First(x => x.ID == kayit.Kayit_ID);
                k.AD = kayit.Kayit_Ad;
                k.SOYAD = kayit.Kayit_Soyad;
                k.MAIL = kayit.Kayit_Mail;
                k.TELEFON = kayit.Kayit_Telefon;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void KayitEkle(KISILER kayitt)
        {
            try
            {
                db.KISILERs.InsertOnSubmit(kayitt);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
