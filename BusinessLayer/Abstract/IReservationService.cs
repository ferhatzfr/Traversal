using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitAprroval(int id);
        List<Reservation> GetListWithreservationByAccepted(int id);
        List<Reservation> GetListWithreservationByPrevious(int id);
    }
}
