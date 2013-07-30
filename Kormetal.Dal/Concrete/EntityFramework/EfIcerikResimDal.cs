using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kormetal.Dal.Abstract;
using Kormetal.Entities.Concrete;

namespace Kormetal.Dal.Concrete.EntityFramework
{
   public class EfIcerikResimDal:IIcerikResimDal
    {

       KmContext _efKmContext = new KmContext();

       public List<KMICERIKRESIM> GetAll()
       {
           return _efKmContext.IcerikResim.ToList();
       }

       public KMICERIKRESIM Get(int id)
       {
           return _efKmContext.IcerikResim.FirstOrDefault(p => p.ID.Equals(id));
       }

       public void Delete(int id)
       {
           _efKmContext.IcerikResim.Remove(Get(id));
       }

       public void Add(KMICERIKRESIM entity)
       {
           _efKmContext.IcerikResim.Add(entity);
           _efKmContext.SaveChanges();
       }

       public void Update(KMICERIKRESIM entity)
       {
           var icerikResimUpdate = Get(entity.ID);
           icerikResimUpdate.ALT = entity.ALT;
           _efKmContext.SaveChanges();
       }
    }
}
