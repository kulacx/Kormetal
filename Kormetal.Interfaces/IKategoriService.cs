using System.Collections.Generic;
using System.ServiceModel.Activation;
using Kormetal.Entities.Concrete;
using System.ServiceModel;

namespace Kormetal.Interfaces
{
    [ServiceContract]
    public interface IKategoriService
    {
        [OperationContract]
        List<KMKATEGORI> GetAll();

        [OperationContract]
        KMKATEGORI Get(int id);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(KMKATEGORI entity);

        [OperationContract]
        void Update(KMKATEGORI entity);
    }
}
