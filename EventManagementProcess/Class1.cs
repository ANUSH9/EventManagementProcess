using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementProcess
{
    public class Class1
    {
        public void Admins()
        {
        AdminM:
            AdminMenu();
            Admin obj2 = new Admin();

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {

                case 1:
                    Console.WriteLine("Insert");
                    string a = obj2.Insert();
                    Console.WriteLine(a);
                    Console.ReadKey();
                    goto AdminM; ;
                case 2:
                    Console.WriteLine("update");
                    string b = obj2.update();
                    Console.WriteLine(b);
                    Console.ReadKey();
                    goto AdminM;
                case 3:
                    Console.WriteLine("Show all");
                    DataTable dt = obj2.show();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Rows[i][j] + "\t");
                        }
                        Console.WriteLine();

                    }
                    Console.ReadKey();
                    goto AdminM;
                case 4:
                    Console.WriteLine("show by ID");
                    Console.WriteLine("select by id into  table");
                    int id = Convert.ToInt32(Console.ReadLine());

                    DataTable dt1 = obj2.ShowById(id);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt1.Columns.Count; j++)
                        {
                            Console.Write(dt1.Rows[i][j] + "\t");
                        }
                        Console.WriteLine();

                    }
                    Console.ReadKey();
                    goto AdminM;
                case 5:
                    Console.WriteLine("Delete by Id");

                    Console.WriteLine("Enter ID to delete: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    string a1 = obj2.Delete(Id);
                    Console.WriteLine(a1);
                    Console.ReadKey();
                    goto AdminM;
                case 6:
                    Customer obj = new Customer();
                    DataTable t = obj.show();
                    for (int i = 0; i < t.Rows.Count; i++)
                    {
                        for (int j = 0; j < t.Columns.Count; j++)
                        {
                            Console.Write(t.Rows[i][j] + "\t");
                        }
                        Console.WriteLine();

                    }
                    Console.ReadKey();
                    goto AdminM;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choise ");
                    goto AdminM;

            }
            
        }
        public void Events()
        {
        EventM:
            EventMenu();
            Event obj3 = new Event();

            int input1 = Convert.ToInt32(Console.ReadLine());
            switch (input1)
            {

                case 1:
                    Console.WriteLine("Insert");
                    string a = obj3.Insert();
                    Console.WriteLine(a);
                    Console.ReadKey();
                    goto EventM; ;
                case 2:
                    Console.WriteLine("update");
                    string b = obj3.update();
                    Console.WriteLine(b);
                    Console.ReadKey();
                    goto EventM;
                case 3:
                    Console.WriteLine("Show all");
                    DataTable dt = obj3.show();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            Console.Write(dt.Rows[i][j] + "\t");
                        }
                        Console.WriteLine();

                    }
                    Console.ReadKey();
                    goto EventM;
                case 4:
                    Console.WriteLine("show by ID");
                    Console.WriteLine("select by id into  table");
                    int id = Convert.ToInt32(Console.ReadLine());

                    DataTable dt1 = obj3.ShowById(id);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt1.Columns.Count; j++)
                        {
                            Console.Write(dt1.Rows[i][j] + "\t");
                        }
                        Console.WriteLine();

                    }
                    Console.ReadKey();
                    goto EventM;
                case 5:
                    Console.WriteLine("Delete by Id");

                    Console.WriteLine("Enter ID to delete: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    string a1 = obj3.Delete(Id);
                    Console.WriteLine(a1);
                    Console.ReadKey();
                    goto EventM;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choise ");
                    goto EventM; ;


            }

        }
        private void AdminMenu()
        {
            Console.WriteLine("----------------Admin Menu----------------");
            Console.WriteLine("Adding New Event Press          : 1");
            Console.WriteLine("Edit Event Press                : 2");
            Console.WriteLine("View All Event Press            : 3");
            Console.WriteLine("Search Event By Id Press        : 4");
            Console.WriteLine("Delete Event By Id Press        : 5");
            Console.WriteLine("Show Customer Event Press       : 6");
            Console.WriteLine("Exit Press                      : 7");
        }


        private void EventMenu()
        {
            Console.WriteLine("----------------Admin Menu----------------");
            Console.WriteLine("Adding New Event Press          : 1");
            Console.WriteLine("Edit Event Press                : 2");
            Console.WriteLine("View All Event Press            : 3");
            Console.WriteLine("Search Event By Id Press        : 4");
            Console.WriteLine("Delete Event By Id Press        : 5");
            Console.WriteLine("Exit Press                      : 6");
        }
    }
}
