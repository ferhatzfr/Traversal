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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }
        public ContactUS GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(ContactUS t)
        {
            _contactUsDal.Insert(t);
        }

        public void TDelete(ContactUS t)
        {
            _contactUsDal.Delete(t);
        }

        public List<ContactUS> TGetList()
        {
            return _contactUsDal.TGetList();
        }

        public void TUpdate(ContactUS t)
        {
            _contactUsDal.Update(t);
        }
    }
}
