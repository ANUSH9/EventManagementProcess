using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementProcess
{
    public class data
    {
        public void loginAs()
        {
        menu:
            Console.WriteLine("---------------Admin----------------------");
            Console.WriteLine(" Super Admin Press                        : 1");
            Console.WriteLine(" Admin Press                              : 2");
            Console.WriteLine(" Customer Press                           : 3");
            Console.WriteLine(" Exit Press                               : 4");
            Console.WriteLine("______________________________________");
            int user = Convert.ToInt32(Console.ReadLine());
            switch (user)
            {
                case 1:
                    {
                    Items:
                        SuperAdminMenu();
                        SuperAdmin obj = new SuperAdmin();
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("Insert");
                                string a = obj.Insert();
                                Console.WriteLine(a);
                                Console.ReadKey();
                                goto Items;
                            case 2:
                                Console.WriteLine("update");
                                string b = obj.update();
                                Console.WriteLine(b);
                                Console.ReadKey();
                                goto Items;
                            case 3:
                                Console.WriteLine("Show all");
                                DataTable dt = obj.show();
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dt.Columns.Count; j++)
                                    {
                                        Console.Write(dt.Rows[i][j] + "\t");
                                    }
                                    Console.WriteLine();

                                }
                                Console.ReadKey();
                                goto Items;
                            case 4:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto Items;

                        }
                    }
                    break;
                case 2:
                    {
                    Items:
                        AdminEventMenu();
                        Class1 obj = new Class1();
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                obj.Admins();
                                goto Items;
                            case 2:
                                obj.Events();
                                goto Items;
                            case 3:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto Items;

                        }
                    }
                    break;
                case 3:
                    {
                    CustomerM:
                        CustomerMenu();
                        Customer obj = new Customer();
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Event obj1 = new Event();
                                DataTable dt = obj1.show();
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dt.Columns.Count; j++)
                                    {
                                        Console.Write(dt.Rows[i][j] + "\t");
                                    }
                                    Console.WriteLine();

                                }
                                Console.ReadKey();
                                goto CustomerM;
                            case 2:
                                Console.WriteLine("Insert");
                                string a = obj.Insert();
                                Console.WriteLine(a);
                                Console.ReadKey();
                                goto CustomerM; ;
                            case 3:
                                Console.WriteLine("update");
                                string b = obj.update();
                                Console.WriteLine(b);
                                Console.ReadKey();
                                goto CustomerM;
                            case 4:
                                Console.WriteLine("Show all");
                                DataTable dtt = obj.show();
                                for (int i = 0; i < dtt.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dtt.Columns.Count; j++)
                                    {
                                        Console.Write(dtt.Rows[i][j] + "\t");
                                    }
                                    Console.WriteLine();

                                }
                                Console.ReadKey();
                                goto CustomerM;
                            case 5:
                                Console.WriteLine("show by ID");
                                Console.WriteLine("select by id into  table");
                                int id = Convert.ToInt32(Console.ReadLine());

                                DataTable dt1 = obj.ShowById(id);
                                for (int i = 0; i < dt1.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dt1.Columns.Count; j++)
                                    {
                                        Console.Write(dt1.Rows[i][j] + "\t");
                                    }
                                    Console.WriteLine();

                                }
                                Console.ReadKey();
                                goto CustomerM;
                            case 6:
                                Console.WriteLine("Delete by Id");

                                Console.WriteLine("Enter ID to delete: ");
                                int Id = Convert.ToInt32(Console.ReadLine());
                                string a1 = obj.Delete(Id);
                                Console.WriteLine(a1);
                                Console.ReadKey();
                                goto CustomerM;

                            case 7:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto CustomerM; ;


                        }
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" bad Input ");
                    Console.WriteLine("try Again");
                    goto menu;


            }
            




        }
        private void SuperAdminMenu()
        {
            Console.WriteLine("----------------Super Admen Menu----------------");
            Console.WriteLine("Adding New Admin Press          : 1");
            Console.WriteLine("Edit The Existing Admin Press   : 2");
            Console.WriteLine("View All Admin Press            : 3");
            Console.WriteLine("Exit Press                      : 4");
        }
        private void AdminEventMenu()
        {
            Console.WriteLine("----------------Menu----------------");
            Console.WriteLine(" Admin Menu Press                        : 1");
            Console.WriteLine(" Event Menu Press                        : 2");
            Console.WriteLine(" Exit Press                              : 3");
        }
        private void CustomerMenu()
        {
            Console.WriteLine("----------------Customer Menu----------------");
            Console.WriteLine("Show All Events  Press          : 1");
            Console.WriteLine("Adding  Event Press             : 2");
            Console.WriteLine("Edit Event Press                : 3");
            Console.WriteLine("View All SelectEvent Press      : 4");
            Console.WriteLine("Search Event By Id Press        : 5");
            Console.WriteLine("Delete Event By Id Press        : 6");
            Console.WriteLine("Exit Press 7");
        }
    }
   



}
