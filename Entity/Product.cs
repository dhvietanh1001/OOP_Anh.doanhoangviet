using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Entity
{
    internal class Product : BaseRow
    {
        public int CategoryId { get; set; }

        public Product() : base() { }

        public Product(int id, string name, int categoryId) : base(id, name)
        {
            CategoryId = categoryId;
        }
    }

}
