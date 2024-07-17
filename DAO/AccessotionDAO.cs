using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.DAO
{
    internal class AccessoryDAO : BaseDAO<Accessotion>
    {

        /*tim kiem Accessotion theo ten
         * @pram Func<Product, bool> where
         * retuen List<Accessotion> */
        public List<Accessotion> Search(Func<Accessotion, bool> where = null)
        {
            var accessories = db.FindAll<Accessotion>();
            return (where == null) ? accessories : accessories.Where(where).ToList();
        }
    }
}
