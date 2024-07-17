using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Interface
{
    public interface IDao<T>
    {
        /*them ban ghi
         * @param row
         * return bool
         * */
        bool Insert(string name,T row);
        /*cap nhat ban ghi
         * @param row
         * return bool
         * */
        bool Update(string name, T row);
        /*xoa ban ghi
         * @param row
         * return bool
         * */
        bool Delete(string name,T row);
        /*lay ra tat ca ban ghi
         * return list<T>
         * */
        List<T> FindAll(string name);
        /*tim ban ghi theo id
         * @param id
         * return T
         * */
        T FindById(string name,int id);
    }
}
