using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kormetal.Dal.Abstract;
using Kormetal.Dal.Concrete.EntityFramework;
using Kormetal.Entities.Concrete;
using Kormetal.Interfaces;

namespace Kormetal.Bll.Concrete
{
   public class IcerikManager:IIcerikService
    {
        private IIcerikDal _icerikDal;

        public IcerikManager(IIcerikDal icerikDal)
        {
            this._icerikDal = icerikDal;
        }


       public List<KMICERIK> GetAll()
       {
           return _icerikDal.GetAll();
       }

       public KMICERIK Get(int id)
       {
          return _icerikDal.Get(id);
       }

       public void Delete(int id)
       {
           _icerikDal.Delete(id);
       }

       public void Add(KMICERIK entity)
       {
           _icerikDal.Add(entity);
       }

       public void Update(KMICERIK entity)
       {
           _icerikDal.Update(entity);
       }
    }
}
