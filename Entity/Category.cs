using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Entity
{
    internal class Category : BaseRow
    {
        public Category() : base() { }

        public Category(int id, string name) : base(id, name) { }
    }

}
