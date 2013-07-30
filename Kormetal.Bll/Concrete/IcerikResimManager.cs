using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kormetal.Dal.Abstract;
using Kormetal.Entities.Concrete;
using Kormetal.Interfaces;

namespace Kormetal.Bll.Concrete
{
   public class IcerikResimManager:IIcerikResimService
   {
       private IIcerikResimDal _icerikResimDal;

       public IcerikResimManager(IIcerikResimDal icerikResimDal)
       {
           _icerikResimDal = icerikResimDal;
       }

       public List<KMICERIKRESIM> GetAll()
       {
           return _icerikResimDal.GetAll();
       }

       public KMICERIKRESIM Get(int id)
       {
           return _icerikResimDal.Get(id);
       }

       public void Delete(int id)
       {
           _icerikResimDal.Delete(id);
       }

       public void Add(KMICERIKRESIM entity)
       {
           _icerikResimDal.Add(entity);
       }

       public void Update(KMICERIKRESIM entity)
       {
           _icerikResimDal.Update(entity);
       }
    }
}
