using DataAccess.Models;
using DataAccess.Repositories;

namespace BusinessLogic.Servicies
{
    public interface IBaseService<TEntityRequest, TEntityResponse> where TEntityRequest : class
                                                                   where TEntityResponse : BaseEntity
    {
        List<TEntityResponse> GetAll();
        TEntityResponse? GetById(int id);
        TEntityResponse Create(TEntityRequest entity);
        TEntityResponse? Update(TEntityRequest entity);
        bool DeleteById(int id);
    }
}
