using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kormetal.Dal.Abstract;
using Kormetal.Entities.Concrete;
using Kormetal.Interfaces;

namespace Kormetal.Bll.Concrete
{

   public class KategoriManager:IKategoriService
   {
       private IKategoriDal _kategoriDal;

       public KategoriManager(IKategoriDal kategoriDal)
       {
           _kategoriDal = kategoriDal;
       }

       public List<KMKATEGORI> GetAll()
       {
           return _kategoriDal.GetAll();
       }

       public KMKATEGORI Get(int id)
       {
           return _kategoriDal.Get(id);
       }

       public void Delete(int id)
       {
           _kategoriDal.Delete(id);
       }

       public void Add(KMKATEGORI entity)
       {
           _kategoriDal.Add(entity);
       }

       public void Update(KMKATEGORI entity)
       {
           throw new NotImplementedException();
       }
    }
}
