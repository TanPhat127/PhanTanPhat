using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTanPhat
{
    internal class Todo
    {
        string do_Name, do_Describe;
        int do_Priority, do_Condition;

        public Todo()
        {
        }

        public Todo(string do_Name, string do_Describe, int do_Priority, int do_Condition)
        {
            Do_Name = do_Name;
            Do_Describe = do_Describe;
            Do_Priority = do_Priority;
            Do_Condition = do_Condition;
        }

        public string Do_Name { get => do_Name; set => do_Name = value; }
        public string Do_Describe { get => do_Describe; set => do_Describe = value; }
        public int Do_Priority
        {
            get => do_Priority; set
            {
                if (value < 1 || value > 5) do_Priority = 1;
                else do_Priority = value;
            }
        }
        public int Do_Condition
        {
            get => do_Condition; set
            {
                if (value < 0 || value > 2) do_Condition = 0;
                else do_Condition = value;
            }
        }

        public void EnterInfo()
        {
            Console.Write("Viec can lam: "); Do_Name = Console.ReadLine();
            Console.Write("Do uu tien: "); Do_Priority = int.Parse(Console.ReadLine());
            Console.Write("Mo ta thong tin: "); Do_Describe = Console.ReadLine();
            Console.Write("Trang thai: \n0-Huy\n1-Hoan thanh\n2-Cho\n--> "); Do_Condition = int.Parse(Console.ReadLine());
        }

        public string Condition()
        {
            if (Do_Condition == 0) return "Huy";
            else if (Do_Condition == 1) return "Hoan Thanh";
            else return "Cho";
        }

        public void ExportInfo()
        {
            Console.WriteLine($"{Do_Name}\tUu tien: {Do_Priority}\nThong tin: {Do_Describe}\nTrang thai: {Condition()}");
        }
    }
}
