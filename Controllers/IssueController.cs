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

        public IActionResult Add() { return View(); }
    }
}
