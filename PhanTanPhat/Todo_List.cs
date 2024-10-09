using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTanPhat
{
    internal class Todo_List
    {
        List<Todo> do_List;

        public Todo_List()
        {
            do_List = new List<Todo>();
        }

        public Todo_List(List<Todo> do_List)
        {
            Do_List = do_List;
        }

        internal List<Todo> Do_List { get => do_List; set => do_List = value; }
        public void Add_List(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\tViec thu: {0}", i + 1);
                Todo t = new Todo();
                t.EnterInfo();
                Do_List.Add(t);
            }
        }

        public void Export_List()
        {
            Console.WriteLine("\t\tDanh sach viec can lam");
            foreach (Todo t in Do_List)
            {
                Console.WriteLine("\t===>Viec thu: {0}", Do_List.IndexOf(t) + 1);
                t.ExportInfo();
            }
        }

        public void Delete_Info(int pos) => Do_List.RemoveAt(pos - 1);
       

        public void Update_Condition(int pos)
        {
            foreach (var t in Do_List)
            {
                if (Do_List.IndexOf(t) + 1 == pos)
                {
                    Console.WriteLine("Trang thai ban dau: {0} - {1}",t.Do_Condition, t.Condition());
                    Console.Write("Trang thai thay doi: "); t.Do_Condition = int.Parse(Console.ReadLine());
                }
            }
        }

        public Todo Find_Todo(string do_Name) => Do_List.FirstOrDefault(i => i.Do_Name == do_Name);
        
        public void Export_DoList_DecresePriority()
        {
            Todo_List lst = new Todo_List();
            lst.Do_List = Do_List.Where(i => i.Do_Condition == 2).OrderByDescending(j => j.Do_Priority).ToList();
            lst.Export_List();
        }
    }
}
