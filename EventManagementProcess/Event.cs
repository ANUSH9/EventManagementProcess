using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementProcess
{
    public class Event
    {
        public static string sqlConnect = @"Data Source=DESKTOP-F0DS2US\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";
        public string Insert()
        {
            Console.Write("Enter EventId: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Event name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Event Address: ");
            string Address = Console.ReadLine();

            Console.Write("Enter Event Cost: ");
            int Cost = Convert.ToInt32(Console.ReadLine());


            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            SqlCommand obj1 = new SqlCommand("insert into Eventt values(" + ID + ",'" + name + "','" + Address + "'," + Cost + ")", sqlConnection);
            sqlConnection.Open();
            obj1.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string update()
        {

            Console.Write("Update EventId : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Update Event name: ");
            string name = Console.ReadLine();

            Console.Write("Update Event Address: ");
            string Address = Console.ReadLine();

            Console.Write("Update Event Cost: ");
            int Cost = Convert.ToInt32(Console.ReadLine());

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnect);//connection establishment
            SqlCommand cmd = new SqlCommand("update Eventt set EventID=" + ID + ",EventName='" + name + "',EventAddress='"+Address+ "',EventCost="+Cost+ " where EventID=" + ID + "", sqlConnection);
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
            SqlCommand cmd = new SqlCommand("select* from Eventt", sqlConnection);
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
            SqlCommand cmd = new SqlCommand("select* from Eventt where EventID ="+id, sqlConnection);
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
            SqlCommand cmd = new SqlCommand("delete from Eventt where EventID=" + Id, sqlConnection);
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
