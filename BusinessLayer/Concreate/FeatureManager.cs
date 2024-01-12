using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class FeatureManager : IFeatureDal
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Delete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetListByFilter(Expression<Func<Feature, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Feature t)
        {
            _featureDal.Insert(t);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.TGetList();
        }

        public void Update(Feature t)
        {
           _featureDal.Update(t);
        }
    }
}
