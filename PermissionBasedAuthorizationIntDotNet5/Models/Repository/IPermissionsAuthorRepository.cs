using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermissionBasedAuthorizationIntDotNet5.Models.Repository
{
    public interface IPermissionsAuthorRepository<IEntity>
    {
        IList<IEntity> List();

        IEntity Find(int id);
        void Add(IEntity entity);
        void Update(int id, IEntity entity);
        void Delete(int id);
       
    }
}
