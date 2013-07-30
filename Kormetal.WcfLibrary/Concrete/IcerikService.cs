using System.Collections.Generic;
using System.ServiceModel.Activation;
using Kormetal.Bll.Concrete;
using Kormetal.Dal.Concrete.EntityFramework;
using Kormetal.Entities.Concrete;
using Kormetal.Interfaces;

namespace Kormetal.WcfLibrary.Concrete
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public  class IcerikService:IIcerikService
  {

      private IIcerikService _icerikService;

      public IcerikService(IIcerikService icerikService)
      {
          _icerikService = icerikService;
      }
     // private IcerikManager _icerikService = new IcerikManager(new EfIcerikDal());
      public List<KMICERIK> GetAll()
      {
         return _icerikService.GetAll();
      }

      public KMICERIK Get(int id)
      {
         return _icerikService.Get(id);
      }

      public void Delete(int id)
      {
          _icerikService.Delete(id);
      }

      public void Update(KMICERIK entity)
      {
          _icerikService.Update(entity);
      }

      public void Add(KMICERIK entity)
      {
          _icerikService.Add(entity);
      }
    }
}
