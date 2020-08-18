using pre_qualification_web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace pre_qualification_web.Controllers
{
    public class ToDoController : Controller
    {
        public ActionResult ToDoList()
        {
            //FILE: Read line
            string[] lines = GetNewLines();
                       
            return View(lines);
        }

        [HttpPost]
        public ActionResult ToDoList(string act)
        {
            //FILE: Insert lines 
            string fileName = @"C:\\Users\\fdossantosco\\source\repos\\pre_qualification_web\\database\\database.txt";
            
            if (!System.IO.File.Exists(fileName))
            {
                System.IO.File.Create(fileName).Close();
            }

            System.IO.TextWriter file = System.IO.File.AppendText(fileName);
            file.WriteLine(act);

            file.Close();

            string[] lines = GetNewLines();

            return View(lines);
        }

        public ActionResult RemoveActivity(int numLine)
        {
            //FILE: Remove lines
            List<string> linesList = System.IO.File.ReadAllLines(@"C:\\Users\\fdossantosco\\source\repos\\pre_qualification_web\\database\\database.txt").ToList();
            linesList.RemoveAt(numLine);
            System.IO.File.WriteAllLines((@"C:\\Users\\fdossantosco\\source\repos\\pre_qualification_web\\database\\database.txt"), linesList.ToArray());       

            string[] newLines = GetNewLines();

            return RedirectToAction("ToDoList");
        }

        public string[] GetNewLines()
        {
            //FILE: Get new lines
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\fdossantosco\\source\repos\\pre_qualification_web\\database\\database.txt");
            return (lines);
        }
    }
}