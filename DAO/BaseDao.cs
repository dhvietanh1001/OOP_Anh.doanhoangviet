using OOP_Anh.doanhoangviet.Entity;
using OOP_Anh.doanhoangviet.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.DAO
{
    internal abstract class BaseDAO<T> : IDao<T> where T : BaseRow
    {
        protected Database db = Database.Instance;

        /*them ban ghi vao bang
         * @pram T row
         * return bool */
        public virtual bool Insert(string name,T row)
        {
            try
            {
                if (FindById(name,row.Id) != null)
                {
                    Console.WriteLine($"{typeof(T).Name} with Id {row.Id} already exists");
                    return false;
                }
                db.InsertTable(name,row);
                Console.WriteLine($"Insert {typeof(T).Name.ToLower()} successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Insert failed: {ex.Message}");
                return false;
            }
        }

        /*cap nhat ban ghi vao bang
         * @pram T row
         * return bool */
        public virtual bool Update(string name,T row)
        {
            try
            {
                if (FindById(name, row.Id) == null)
                {
                    Console.WriteLine($"{typeof(T).Name} with Id {row.Id} does not exist");
                    return false;
                }
                db.UpdateTable(name, row);
                Console.WriteLine($"Update {typeof(T).Name.ToLower()} successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Update failed: {ex.Message}");
                return false;
            }
        }

        /*xoa ban ghi vao bang
         * @pram T row
         * return bool */
        public virtual bool Delete(string name,T row)
        {
            try
            {
                if (FindById(name,row.Id) == null)
                {
                    Console.WriteLine($"{typeof(T).Name} with Id {row.Id} does not exist");
                    return false;
                }
                db.DeleteTable(name, row);
                Console.WriteLine($"Delete {typeof(T).Name.ToLower()} successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delete failed: {ex.Message}");
                return false;
            }
        }

        /*lay ra tat ca ban ghi
         * List<T> */
        public virtual List<T> FindAll(string name)
        {
            return db.FindAll<T>(name);
        }

        /*tim kiem ban ghi theo id
         * @pram int id
         * retuen bool */
        public virtual T FindById(string name,int id)
        {
            var entity = db.FindById<T>(name,id);
            return entity;
        }

        /*tim kiem ban ghi theo name
         * @pram string name 
         * return bool*/
        public virtual T FindByName(string name)
        {
            var entity = db.FindAll<T>(name).FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (entity == null)
            {
                Console.WriteLine($"{typeof(T).Name} with name {name} not found");
            }
            return entity;
        }
    }

}

