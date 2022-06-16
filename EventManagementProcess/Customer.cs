using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementProcess
{
    public class Customer
    {
        public static string sqlConnect = @" Data Source=DESKTOP-F0DS2US\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";
        public string Insert()
        {
            Console.Write("Enter Customer ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Customer Address  : ");
            string Address = Console.ReadLine();

            Console.Write("Enter Event Name  : ");
            string EventName = Console.ReadLine();

            Console.Write("Enter Event Cost: ");
            int eID = Convert.ToInt32(Console.ReadLine());




            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            SqlCommand obj1 = new SqlCommand("insert into CustomerDetail values(" + ID + ",'" + name + "','" + Address + "','"+EventName+"'," + eID + ")", sqlConnection);
            sqlConnection.Open();
            obj1.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";

        }
        public string update()
        {

            Console.Write("Update Customer ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("update Customer name: ");
            string name = Console.ReadLine();

            Console.Write("update Customer Address  : ");
            string Address = Console.ReadLine();

            Console.Write("update Event Name  : ");
            string EventName = Console.ReadLine();

            Console.Write("update Event Cost: ");
            int eID = Convert.ToInt32(Console.ReadLine());

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnect);//connection establishment
            SqlCommand cmd = new SqlCommand("update CustomerDetail set CustomerID=" + ID + ",CustomerName='" + name + "',CustomerAddress='" + Address + "',EventName='" + EventName + "',EventCost=" + eID + " where CustomerID=" + ID + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
            

        }
        public DataTable show()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            string a = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select* from CustomerDetail", sqlConnection);
            sqlConnection.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(DataReader);

            sqlConnection.Close();
            return dataTable;

        }



        public DataTable ShowById(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            string a = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select* from CustomerDetail where CustomerID =" + id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(DataReader);

            sqlConnection.Close();
            return dataTable;

        }
        public string Delete(int Id)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnect);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from CustomerDetail where CustomerID=" + Id, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
            {
                return "notDeleted";
            }
            return "Deleted";
        }
    }
}
