using DCComics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCComics.Repository.Common
{
    interface IPersonRepository: IGenericRepository<Person>
    {
        Person GetById(long id);
    }
}
