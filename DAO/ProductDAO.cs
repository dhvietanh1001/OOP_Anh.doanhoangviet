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
        public List<Product> Search(string name, int categoryId)
        {
            var products = db.FindAll<Product>();
            if (!string.IsNullOrEmpty(name))
            {
                products = products.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (categoryId != -1)
            {
                products = products.Where(p => p.CategoryId == categoryId).ToList();
            }
            return products;
        }
    }

}
