using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Jan24ConsoleApp
{
    public class CompanyData {
        static SqlConnection connect() { 
            string str= ConfigurationManager.ConnectionStrings["con_str"].ToString();
            SqlConnection connection = new SqlConnection(str);
            return connection;
        }
        public void InsertCom() { 
        using(SqlConnection con = connect())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Customers",con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dataTable = ds.Tables[0];
                DataRow dataRow = dataTable.NewRow();

                Console.WriteLine("Enter customer id");
                dataRow["Cid"] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter customer name");
                dataRow["CName"] = Console.ReadLine();
                Console.WriteLine("Enter city");
                dataRow["City"] = Console.ReadLine();
                dataTable.Rows.Add(dataRow);
                adapter.Update(dataTable);
             
                Console.WriteLine("1 row inserted successfully");
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            CompanyData companyData = new CompanyData();
            companyData.InsertCom();
            Console.ReadLine();
        }
    }
}
