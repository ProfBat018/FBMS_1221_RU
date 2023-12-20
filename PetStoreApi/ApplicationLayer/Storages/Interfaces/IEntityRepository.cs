using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Storages.Interfaces;

public interface IEntityRepository<T>
{
    void Update(T category);
    T FindById(int id);
}
