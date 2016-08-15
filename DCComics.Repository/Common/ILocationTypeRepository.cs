using DCComics.Model.Code_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCComics.Repository.Common
{
    interface ILocationTypeRepository : IGenericRepository<LocationType>
    {
        LocationType GetById(long id);
    }
}
