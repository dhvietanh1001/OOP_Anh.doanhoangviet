using OOP_Anh.doanhoangviet.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Entity
{
    internal abstract class BaseRow: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        protected BaseRow() { }

        protected BaseRow(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
