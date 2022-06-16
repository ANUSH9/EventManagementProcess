using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementProcess
{
    internal class SuperAdmin
    {
        public static string sqlConnect = @"Data Source=DESKTOP-F0DS2US\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";
        public string Insert()
        {
            Console.Write("Enter Id: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Admin Id: ");
            int AdminID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Admin name: ");
            string AdminName = Console.ReadLine();

            Console.Write("Enter Admin Role: ");
            string AdminRole = Console.ReadLine();

          


            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            SqlCommand obj1 = new SqlCommand("insert into SuperAdmin values(" + ID + "," + AdminID + ",'" + AdminName + "','" + AdminRole + "')", sqlConnection);
            sqlConnection.Open();
            obj1.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
            
        }
        public string update()
        {

            Console.Write("Update  Id : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Update Admin id: ");
            int aID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Update Admin Name: ");
            string Address = Console.ReadLine();

            Console.Write("Update Admin Role: ");
            string role = Console.ReadLine();

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnect);//connection establishment
            SqlCommand cmd = new SqlCommand("update SuperAdmin set id=" + ID + ",AdminID=" + aID + ",AdminName='" + Address + "',AdminRole='" + role + "' where id=" + ID + "", sqlConnection);
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
            SqlCommand cmd = new SqlCommand("select* from SuperAdmin", sqlConnection);
            sqlConnection.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(DataReader);

            sqlConnection.Close();
            return dataTable;
           
        }
        
    }

}
