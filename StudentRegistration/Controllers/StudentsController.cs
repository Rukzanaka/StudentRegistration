using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentRegistration.Controllers
{
    public class StudentsController : ApiController
    {
        [HttpGet]
        public string StudentSave(string name,int malayalam,int hindi)
        {
            string connectionString = "Server=DESKTOP-T7TL75O\\SQLEXPRESS;Database=Student;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("StudentSave", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Malayalam",malayalam);
            command.Parameters.AddWithValue("Hindi", hindi);

            Students students = new Students();
            students.Name = name;
            students.Malayalam = malayalam.ToString();
            students.Hindi = hindi.ToString();


            return students.ToString();


        }

    }
}
