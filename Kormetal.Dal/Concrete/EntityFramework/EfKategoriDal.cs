using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kormetal.Dal.Abstract;
using Kormetal.Entities.Concrete;

namespace Kormetal.Dal.Concrete.EntityFramework
{
    public class EfKategoriDal:IKategoriDal
    {
        private KmContext _kmContext = new KmContext();
        

        public List<KMKATEGORI> GetAll()
        {
           return _kmContext.Kategori.ToList();
        }

        public KMKATEGORI Get(int id)
        {
           return _kmContext.Kategori.FirstOrDefault(p => p.ID.Equals(id));
        }

        public void Delete(int id)
        {
            _kmContext.Kategori.Remove(Get(id));
            _kmContext.SaveChanges();
        }

        public void Add(KMKATEGORI entity)
        {
            _kmContext.Kategori.Add(entity);
            _kmContext.SaveChanges();
        }

        public void Update(KMKATEGORI entity)
        {
            var kategoriUpdate = Get(entity.ID);
            kategoriUpdate.PARENTID = entity.PARENTID;
            kategoriUpdate.RUAD = entity.RUAD;
            kategoriUpdate.SIRA = entity.SIRA;
            kategoriUpdate.TRAD = entity.TRAD;
            kategoriUpdate.URL = entity.URL;
            kategoriUpdate.YENIPENCERE = entity.YENIPENCERE;

            _kmContext.SaveChanges();
        }
    }
}
