using S3Exam.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Exam.Northwind.DAL
{
    public class Repository
    {
        private NorthwindModel model = new NorthwindModel();

        public List<Employee> GetAllEmployees()
            => model.Employees.ToList();

        public void Update(Employee employee)
        {
            model.Employees.AddOrUpdate(employee);
            model.SaveChanges();
        }

        public void Insert(Employee employee)
        {
            model.Employees.Add(employee);
            model.SaveChanges();
        }
    }
}
