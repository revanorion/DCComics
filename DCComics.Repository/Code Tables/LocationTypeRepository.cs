using DCComics.Model.Code_Tables;
using DCComics.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCComics.Repository.Code_Tables
{
    public class LocationTypeRepository : GenericRepository<LocationType>, ILocationTypeRepository
    {
        public LocationTypeRepository(DbContext context)
            : base(context)
        {

        }

        public override IEnumerable<LocationType> GetAll()
        {
            return _entities.Set<LocationType>().AsEnumerable();
        }

        public LocationType GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
