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
        bool Insert(T row);
        /*cap nhat ban ghi
         * @param row
         * return bool
         * */
        bool Update(T row);
        /*xoa ban ghi
         * @param row
         * return bool
         * */
        bool Delete(T row);
        /*lay ra tat ca ban ghi
         * return list<T>
         * */
        List<T> FindAll();
        /*tim ban ghi theo id
         * @param id
         * return T
         * */
        T FindById(int id);
    }
}
