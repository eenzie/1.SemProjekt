using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Repositories
{
    public class Database_Shop : Database_Abstract
    {
        public List<Shop> GetAllShops()
        {
            List<Shop> shops = new List<Shop>();
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string selectSqlString = $"select * from Shops";
                    SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read()) {
                        int id = sqlDataReader.GetInt32(0);
                        string address = sqlDataReader.GetString(1);
                        int postCode = sqlDataReader.GetInt32(2);

                        Shop store = new Shop(id, address, postCode);
                        shops.Add(store);
                    }
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Shop), nameof(GetAllShops));
            }

            return shops;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string selectSqlString = $"select * from Employees";
                SqlCommand sqlCommand = new SqlCommand( selectSqlString, sqlConnection);

                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Shop> shops = GetAllShops();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string phone = reader.GetString(2);
                    int shopID = reader.GetInt32(3);
                    Shop shop = shops.Find(x => x.ID == shopID);

                    Employee employee = new Employee(id, name, phone, shop);
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public List<Employee> GetAllEmployees(Shop shop) {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string selectSqlString = $"select * from Employees where ShopId = {shop.ID};";
                SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);

                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Shop> shops = GetAllShops();

                while (reader.Read()) {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string phone = reader.GetString(2);

                    Employee employee = new Employee(id, name, phone, shop);
                    employees.Add(employee);
                }
            }

            return employees;
        }

    }
}
