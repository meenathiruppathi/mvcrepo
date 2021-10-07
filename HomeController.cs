using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Employee> employeeList = new List<Employee>();
            string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("Select * from employees", con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var employee1 = new Employee();
                employee1.Name = rdr["empname"].ToString();
                employee1.EmployeeId = Convert.ToInt32(rdr["empid"]);
                employeeList.Add(employee1);
                


            }
            ViewBag.Message = "Your contact page.";

            return View(employeeList);

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}