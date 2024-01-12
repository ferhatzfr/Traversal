using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public Reservation GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithreservationByAccepted(int id)
        {
            return _reservationDal.GetListWithreservationByAccepted(id);
        }

        public List<Reservation> GetListWithreservationByPrevious(int id)
        {
            return _reservationDal.GetListWithreservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
           return _reservationDal.GetListWithReservationByWaitAprroval(id);
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
