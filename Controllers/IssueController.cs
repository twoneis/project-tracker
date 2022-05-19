using Microsoft.AspNetCore.Mvc;
using project_tracker.Data;
using project_tracker.Models;

namespace project_tracker.Controllers 
{
    public class IssueController : Controller 
    {

        private readonly ApplicationDBContext _db;

        public IssueController(ApplicationDBContext db) 
        {
            _db = db;
        }

        public IActionResult Index() 
        {
            IEnumerable<Issue> IssueList = _db.Issues.ToList();
            return View(IssueList); 
        }
        //GET
        public IActionResult Add() { 
            return View(); 
        }

        public IActionResult Display(int? id) {
            if(id == null) { return NotFound(); }
            var issue = _db.Issues.Find(id);
            if (issue == null) { return NotFound(); }
            return View(issue);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Issue obj)
        {
            _db.Issues.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Issue obj)
        {
            _db.Issues.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Category updated successfully";
            return RedirectToAction("Index");
        }
    }
}
