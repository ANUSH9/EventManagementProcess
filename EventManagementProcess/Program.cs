using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Event obj = new Event();
            //string a = obj.update();
            //Console.WriteLine(a);
            //Console.ReadKey();

            //Customer obj = new Customer();
            //string a = obj.update();
            //Console.WriteLine(a);
            //Console.ReadKey();

            //Customer obj = new Customer();
            //DataTable dt = obj.show();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        Console.Write(dt.Rows[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.ReadKey();
            //}

            //Customer obj = new Customer();
            //Console.WriteLine("select by id into customer table");
            //int id = Convert.ToInt32(Console.ReadLine());

            //DataTable dt1 = obj.ShowById(id);
            //for (int i = 0; i < dt1.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt1.Columns.Count; j++)
            //    {
            //        Console.Write(dt1.Rows[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.ReadKey();
            //}

            //Admin obj1 = new Admin();
            //string a1 = obj1.update();
            //Console.WriteLine(a1);
            //Console.ReadKey();

            //SuperAdmin obj = new SuperAdmin();
            //string a = obj.update();
            //Console.WriteLine(a);
            //Console.ReadKey();

            //SuperAdmin obj = new SuperAdmin();
            //DataTable dt = obj.show();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        Console.Write(dt.Rows[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.ReadKey();
            //}

            //Event obj1 = new Event();
            //Console.WriteLine("Enter ID to delete: ");
            //int Id = Convert.ToInt32(Console.ReadLine());
            //string a = obj1.Delete(Id);
            //Console.WriteLine(a);
            //Console.ReadKey();

            //Console.WriteLine("Delete by Id");
            //Customer obj1 = new Customer();
            //Console.WriteLine("Enter ID to delete: ");
            //int Id = Convert.ToInt32(Console.ReadLine());
            //string a1 = obj1.Delete(Id);
            //Console.WriteLine(a1);
            //Console.ReadKey();
           
            data obj = new data();
            obj.loginAs();



        }
    }
}
