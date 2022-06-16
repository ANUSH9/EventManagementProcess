using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementProcess
{
    public class Admin
    {
        public static string sqlConnect = @" Data Source=DESKTOP-F0DS2US\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";
        public string Insert()
        {
            Console.Write("Enter Admin ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Admin name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Event Name : ");
            string EventName = Console.ReadLine();

            Console.Write("Enter Event ID: ");
            int eID = Convert.ToInt32(Console.ReadLine());




            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            SqlCommand obj1 = new SqlCommand("insert into Adminn values(" + ID + ",'" + name + "','" + EventName + "'," + eID + ")", sqlConnection);
            sqlConnection.Open();
            obj1.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
           
        }
        public string update()
        {

            Console.Write("Update Admin Id : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Update Admin name: ");
            string name = Console.ReadLine();

            Console.Write("Update Event Name: ");
            string Address = Console.ReadLine();

            Console.Write("Update Event ID: ");
            int Cost = Convert.ToInt32(Console.ReadLine());

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnect);//connection establishment
            SqlCommand cmd = new SqlCommand("update Adminn set AdminID=" + ID + ",AdminName='" + name + "',EventName='" + Address + "',EventID=" + Cost + " where AdminID=" + ID + "", sqlConnection);
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
            SqlCommand cmd = new SqlCommand("select* from Adminn", sqlConnection);
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
            SqlCommand cmd = new SqlCommand("select* from Adminn where AdminID =" + id, sqlConnection);
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
            SqlCommand cmd = new SqlCommand("delete from Adminn where AdminID=" + Id, sqlConnection);
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
