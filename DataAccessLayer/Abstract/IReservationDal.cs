using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitAprroval(int id);
        List<Reservation> GetListWithreservationByAccepted(int id);
        List<Reservation> GetListWithreservationByPrevious(int id);
    }
}
