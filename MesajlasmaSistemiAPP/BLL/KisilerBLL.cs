using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
namespace BLL
{
    public class KisilerBLL
    {
        public static KisilerDTO GetAll()
        {
            KisilerDTO dto = new KisilerDTO();
            dto.Kisiler = KisilerDAO.KisilerGetir();
            return dto;
        }

        public static List<TBL_KISILER> KisilerGetir(string v, string text)
        {
            return KisilerDAO.KisilerGetir(v,text);
        }
    }
}
