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

        public virtual bool Insert(T row)
        {
            try
            {
                if (FindById(row.Id) != null)
                {
                    Console.WriteLine($"{typeof(T).Name} with Id {row.Id} already exists");
                    return false;
                }
                db.InsertTable(row);
                Console.WriteLine($"Insert {typeof(T).Name.ToLower()} successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Insert failed: {ex.Message}");
                return false;
            }
        }

        public virtual bool Update(T row)
        {
            try
            {
                if (FindById(row.Id) == null)
                {
                    Console.WriteLine($"{typeof(T).Name} with Id {row.Id} does not exist");
                    return false;
                }
                db.UpdateTable(row);
                Console.WriteLine($"Update {typeof(T).Name.ToLower()} successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Update failed: {ex.Message}");
                return false;
            }
        }

        public virtual bool Delete(T row)
        {
            try
            {
                if (FindById(row.Id) == null)
                {
                    Console.WriteLine($"{typeof(T).Name} with Id {row.Id} does not exist");
                    return false;
                }
                db.DeleteTable(row);
                Console.WriteLine($"Delete {typeof(T).Name.ToLower()} successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delete failed: {ex.Message}");
                return false;
            }
        }

        public virtual List<T> FindAll()
        {
            return db.FindAll<T>();
        }

        public virtual T FindById(int id)
        {
            var entity = db.FindById<T>(id);
            return entity;
        }

        public virtual T FindByName(string name)
        {
            var entity = db.FindAll<T>().FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (entity == null)
            {
                Console.WriteLine($"{typeof(T).Name} with name {name} not found");
            }
            return entity;
        }
    }

}

