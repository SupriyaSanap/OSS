using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace CRMWebApp.Models
{
    public class HRManager
    {
        public static string path = @"F:\try\employees.dat";
        public static List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            return employees;
        }
        public static bool Insert(Employee emp) {
            bool status = false;
            try
            {
                List<Employee> employees = new List<Employee>();
                employees = LoadData(path);
                employees.Add(emp);
                SaveData(path, employees);
                status = true;
            }
            catch (Exception ex)
            {
                string exeMessage = ex.Message;
            }
            return status;




        }
        public static bool Update(Employee empToUpdate)
        {
            bool status = false;
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);

            var result = from r in employees
                         where r.ID == empToUpdate.ID
                         select r;

            result.First().FirstName = empToUpdate.FirstName;
            result.First().LastName = empToUpdate.LastName;
            result.First().Email = empToUpdate.Email;
            result.First().ContactNumber = empToUpdate.ContactNumber;
            result.First().Location = empToUpdate.Location;
            result.First().Department = empToUpdate.Department;

            status = SaveData(path, employees); ;
            return status;
        }
        public static bool Delete(int id)
        {
            bool status = false;
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            int no = employees.RemoveAll(emp => emp.ID == id);
            if (no > 0)
            {
                SaveData(path, employees);
                status = true;
            }
            return status;
        }
        public static Employee GetById(int id) {
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            var employee = employees.Find(e => e.ID == id);
            return employee as Employee;

        }
        public static List<Employee> LoadData (String path)
        {
            //Deserialization

            List<Employee> employees = new List<Employee>();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            employees = bf.Deserialize(fs) as List<Employee>;
            fs.Close();
            return employees;
        }
        public static bool SaveData(string path, List<Employee> employees)
        {
            bool status = false;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, employees);
            fs.Close();
            return status;

        }
    }
}