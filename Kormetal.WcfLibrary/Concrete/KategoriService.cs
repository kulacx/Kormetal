using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using Kormetal.Bll.Concrete;
using Kormetal.Dal.Concrete.EntityFramework;
using Kormetal.Entities.Concrete;
using Kormetal.Interfaces;

namespace Kormetal.WcfLibrary.Concrete
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
   public class KategoriService:IKategoriService
   {

       private IKategoriService _kategoriService;

       public KategoriService(IKategoriService kategoriService)
       {
           _kategoriService = kategoriService;
       }

      // private KategoriManager _kategoriService = new KategoriManager(new EfKategoriDal());

       public List<KMKATEGORI> GetAll()
       {
          return _kategoriService.GetAll();
       }

       public KMKATEGORI Get(int id)
       {
          return _kategoriService.Get(id);
       }

       public void Delete(int id)
       {
           _kategoriService.Delete(id);
       }

       public void Add(KMKATEGORI entity)
       {
           _kategoriService.Add(entity);
       }

       public void Update(KMKATEGORI entity)
       {
           _kategoriService.Update(entity);
       }
    }
}
