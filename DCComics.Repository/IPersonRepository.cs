using DCComics.Model;
using DCComics.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCComics.Repository
{
    public interface IPersonRepository: IGenericRepository<Person>
    {
        Person GetById(long id);
    }
}
