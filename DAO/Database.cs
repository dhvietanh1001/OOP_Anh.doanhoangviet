using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Anh.doanhoangviet.DAO
{
    internal class Database    {


        private List<Product> products = new List<Product>();
        private List<Accessotion> accessotions = new List<Accessotion>();
        private List<Category> categories = new List<Category>();

        public Database()
        {

        }

        private static Database instance;
        
        // instance null  tạo mới 
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        /*them ban ghi vao bang
         * @param string name, T row
         * return void*/
        public void InsertTable<T>(string name,T row) where T : BaseRow
        {
            GetListByType<T>(name).Add(row);
        }

        /*lay ban ghi tu trong bang theo dieu kien
         * @param string name, Func<T, bool> where = null
         * return list<T>*/
        public List<T> SelectTable<T>(string name, Func<T, bool> where = null) where T : BaseRow
        {
            var list = GetListByType<T>(name);
            return (where == null) ? list : list.Where(where).ToList();
        }

        /*cap nhat ban ghi vao bang
         * @param sreing name, T row
         * return void*/
        public void UpdateTable<T>(string name, T row) where T : BaseRow
        {
            if (row is Product)
            {
                UpdateList<Product>(products, row as Product);
            }
            if (row is Category)
            {
                UpdateList<Category>(categories, row as Category);
            }
            if (row is Accessotion)
            {
                UpdateList<Accessotion>(accessotions, row as Accessotion);
            }
        }

        /*xoa ban ghi vao bang
         * @param sreing name, T row
         * return void*/
        public void DeleteTable<T>(string name, T row) where T : BaseRow
        {
            if(row is Product)
            {
                DeleteFromList<Product>(products, row as Product);
            }
            if (row is Category)
            {
                DeleteFromList<Category>(categories, row as Category);
            }
            if (row is Accessotion)
            {
                DeleteFromList<Accessotion>(accessotions, row as Accessotion);
            }

        }

        /*xoa du lieu tat ca cac bang 
         * return void*/
        public void TruncateTable<T>(string name) where T : BaseRow
        {
            GetListByType<T>(name).Clear();
        }

        /*lay ra toan bo ban ghi cua 1 bang
         * return List<T>*/
        public List<T> FindAll<T>(string name) where T : BaseRow
        {
            return GetListByType<T>(name);
        }

        /*lay ra danh sach cuar 1 bang
         * return List<T>*/
        private List<T> GetListByType<T>(string name) where T : BaseRow
        {
            if (typeof(T) == typeof(Product))
            {
                return products as List<T>;
            }
            if (typeof(T) == typeof(Accessotion))
            {
                return accessotions as List<T>;
            }
            if (typeof(T) == typeof(Category))
            {
                return categories as List<T>;
            }
            throw new ArgumentException("Invalid type", nameof(T));
        }

        /*in ra bang
         * return void*/
        public void PrintTable<T>(string name) where T : BaseRow
        {
            var list = GetListByType<T>(name);
            Console.WriteLine("Count:"+list.Count);
            foreach (var item in list)
            {
                item.Print();
            }
        }

        /*thay doi du lieu ban ghi trong danh sachs
         * @param T row
         * return void*/
        private void UpdateList<T>(List<T> list, T row) where T : BaseRow
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == row.Id)
                {
                    list[i] = row;
                    return;
                }
            }
        }


        /*xoa du lieu ban ghi trong danh sachs
         * return void*/
        private void DeleteFromList<T>(List<T> list, T row) where T : BaseRow
        {
            list.RemoveAll(r => r.Id == row.Id);
        }


        /*tim kiem ban ghi trong danh sach bang id
         * @param int id
         * return void*/
        public T FindById<T>(string name,int id) where T:BaseRow
        {
             var objectFind = GetListByType<T>(name).SingleOrDefault(t=>t.Id==id);
            if (objectFind == null)
            {
                return null;
            }
            return objectFind;
        }

    }
}


