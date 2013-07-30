using System.Collections.Generic;
using System.ServiceModel;
using Kormetal.Entities.Concrete;

namespace Kormetal.Interfaces
{
    [ServiceContract]
    public interface IIcerikResimService
    {
        [OperationContract]
        List<KMICERIKRESIM> GetAll();

        [OperationContract]
        KMICERIKRESIM Get(int id);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(KMICERIKRESIM entity);

        [OperationContract]
        void Update(KMICERIKRESIM entity);
    }
}
