using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDMVCTayyab.Models
{
    public class StudentController : Controller
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-2H4EQN69;Initial Catalog=MVCCrud;Integrated Security=True");

        public List<StudentModel> GetStudent()
        {
            List<StudentModel> studentModels = new List<StudentModel>();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("GetAllStudent",sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlConnection.Close();
            foreach(DataRow dr in dt.Rows)
            {
                studentModels.Add(new StudentModel()
                {
                    StudentID = Convert.ToInt32(dr["StudentID"]),
                    StudentName = Convert.ToString(dr["StudentName"]),
                    StudentCity = Convert.ToString(dr["StudentCity"]),
                    StudentAdsress=Convert.ToString(dr["StudentAdsress"])
                });
            }
            return studentModels;

        }

        // GET: Student
        public ActionResult Index()
        {
            return View(GetStudent());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
