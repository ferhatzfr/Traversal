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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public AppUser GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
           _appUserDal.Delete(t);
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.TGetList();
        }

        public void TUpdate(AppUser t)
        {
            _appUserDal.Update(t);
        }
    }
}
