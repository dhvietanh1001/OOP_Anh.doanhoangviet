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
         * @pram string name
         * retuen List<Accessotion> */
        public List<Accessotion> Search(string name)
    {
        var accessories = db.FindAll<Accessotion>();
        if (!string.IsNullOrEmpty(name))
        {
            accessories = accessories.Where(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        return accessories;
    }
}
}
