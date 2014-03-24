using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.IDAL
{
    public interface IBaseRepository<T> where T : class,new()
    {
        T Insert(T entity);
        bool Update(T entity);
        bool Delete(object keyId);
        List<T> LoadEntities(object where);
        List<T> LoadPageEntities(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara);
    }
}
