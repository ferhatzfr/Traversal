using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repository;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithreservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserID == id).ToList();
            }
        }

        public List<Reservation> GetListWithreservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserID == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
           using (var context = new Context()) 
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.AppUserID == id).ToList();
            }
        }
    }
}
