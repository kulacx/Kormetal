using System.Collections.Generic;
using System.ServiceModel;
using Kormetal.Entities.Concrete;

namespace Kormetal.Interfaces
{
    [ServiceContract]
   public interface IIcerikService
    {
        [OperationContract]
        List<KMICERIK> GetAll();

        [OperationContract]
        KMICERIK Get(int id);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(KMICERIK entity);

        [OperationContract]
        void Update(KMICERIK entity);
    }
}
