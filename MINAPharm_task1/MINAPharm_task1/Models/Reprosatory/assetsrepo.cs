using Microsoft.EntityFrameworkCore;
using MINAPharm_task1.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MINAPharm_task1.Models.Reprosatory
{
    public class assetsrepo : Irepoassets<Assets>
    {

        private readonly AppDbcontext db;
        public assetsrepo(AppDbcontext _context)

        {
            this.db = _context;
        }

        public void creat(Assets assettt)
        {
            

            db.assett.Add(assettt);
            db.SaveChanges();

        }
          public void delete(int id)
        {
            var y = db.assett.Find(id);

                if (y !=null)
            {
                db.assett.Remove(y);
            }
            db.SaveChanges();

        }

        public List<Assets> getallassets()
        {
            var x =db.assett.ToList();
            return x;
        }

        public Assets search(int id)
        {

            var x = db.assett.Find(id);
            return x;
        }

        public void update(Assets assett)
        {

            db.assett.Update(assett);
            db.SaveChanges();

        }
    }
}
