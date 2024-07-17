using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.DAO
{
    internal class ProductDAO : BaseDAO<Product>
    {
        /*tim kiem  Product theo ten va categoryid
         * @pram Func<Product, bool> where
         * retuen List<Product> */
        public List<Product> Search(Func<Product, bool> where = null)
        {
            var products = db.FindAll<Product>("Product");
            return (where == null) ? products : products.Where(where).ToList();
        }
    }

}
