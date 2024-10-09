using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTanPhat
{
    internal class Program
    {
        static public void menu()
        {
            Console.WriteLine("1.Nhap thong tin viec can lam." +
                "\n2.Xuat thong tin viec can lam da khai bao." +
                "\n3.Xoa thong tin theo vi tri (Vi tri dau tien la: > 1 <)." +
                "\n4.Cap nhat trang thai viec can lam theo vi tri (Vi tri dau tien la: > 1 <)." +
                "\n5.Tim kiem theo ten viec can lam." +
                "\n6.Xuat thong tin viec can lam theo uu tien giam dan (Cong viec dang o trang thai: Cho)." +
                "\n(Esc hoac q de thoat)");
        }
        static void Main(string[] args)
        {
            int n, pos, chon;
            Todo_List doLst = new Todo_List();
            while (true)
            {

                menu();
                Console.WriteLine();
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape || key.KeyChar == 'q')
                {
                    Console.WriteLine("!!!Stop!!!");
                    break;
                }
                chon = int.Parse(key.KeyChar.ToString());
                switch (chon)
                {
                    case 1:
                        do
                        {
                            Console.Write("Nhap so luong cong viec: ");
                            n = int.Parse(Console.ReadLine());
                        } while (n <= 0);
                        doLst.Add_List(n); break;
                    case 2:
                        doLst.Export_List(); break;
                    case 3:
                        do
                        {
                            Console.Write("Nhap vi tri muon xoa: "); pos = int.Parse(Console.ReadLine());
                        } while (pos < 1);
                        doLst.Delete_Info(pos); break;
                    case 4:
                        do
                        {
                            Console.Write("Nhap vi tri cap nhat trang thai: "); pos = int.Parse(Console.ReadLine());
                        } while (pos < 1);
                        doLst.Update_Condition(pos); break;
                    case 5:
                        string do_Name;
                        Console.Write("Nhap ten viec lam muon tim: "); do_Name = Console.ReadLine();
                        Todo work = doLst.Find_Todo(do_Name);
                        work.ExportInfo();
                        break;
                    case 6:
                        Console.WriteLine("Sap xep theo thu tu giam dan");
                        doLst.Export_DoList_DecresePriority(); break;
                    default:
                        Console.WriteLine("Khong ton tai!!!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
