using System;
using System.Collections.Generic;
using System.Linq;
using Kormetal.Dal.Abstract;
using Kormetal.Entities;
using Kormetal.Entities.Concrete;

namespace Kormetal.Dal.Concrete.EntityFramework
{
   public class EfIcerikDal:IIcerikDal
    {
       KmContext _kmContext = new KmContext();

       public List<KMICERIK> GetAll()
       {
           return _kmContext.Icerik.ToList();
       }

       public KMICERIK Get(int id)
       {
           return _kmContext.Icerik.FirstOrDefault(p => p.ID.Equals(id));
       }

       public void Delete(int id)
       {
           _kmContext.Icerik.Remove(Get(id));
           _kmContext.SaveChanges();
       }

       public void Add(KMICERIK entity)
       {
           _kmContext.Icerik.Add(entity);
           _kmContext.SaveChanges();
       }

       public void Update(KMICERIK entity)
       {
           var icerikUpdate = Get(entity.ID);

           icerikUpdate.KATID = entity.KATID;
           icerikUpdate.RUANAHTARKELIME = entity.RUANAHTARKELIME;
           icerikUpdate.RUBASLIK = entity.RUBASLIK;
           icerikUpdate.RUICERIK = entity.RUICERIK;
           icerikUpdate.RUKISAICERIK = entity.RUKISAICERIK;
           icerikUpdate.TRANAHTARKELIME = entity.TRANAHTARKELIME;
           icerikUpdate.TRBASLIK = entity.TRBASLIK;
           icerikUpdate.TRICERIK = entity.TRICERIK;
           icerikUpdate.TRKISAICERIK = entity.TRKISAICERIK;
           icerikUpdate.ENANAHTARKELIME = entity.ENANAHTARKELIME;
           icerikUpdate.ENBASLIK = entity.ENBASLIK;
           icerikUpdate.ENICERIK = entity.ENICERIK;
           icerikUpdate.ENKISAICERIK = entity.ENKISAICERIK;

           _kmContext.SaveChanges();

       }
    }
}
