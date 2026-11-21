using Microsoft.AspNetCore.Mvc; using self_learning.Models;

namespace self_learning.Controllers
{
public class StudentController : Controller
{
private static List<Student> students = new List<Student>();
private static int nextId = 1; public IActionResult Index()
{
return View(students);
}

[HttpGet]
public IActionResult Create()
{
return View();
}
 
[HttpPost] [ValidateAntiForgeryToken]
public IActionResult Create(Student student)
{
if (ModelState.IsValid)
{
student.Id = nextId++; students.Add(student);

return RedirectToAction("Index");
}

return View(student);
}
public IActionResult Details(int id)
{
var student = students.FirstOrDefault( s => s.Id == id
);
if (student == null)
{
return NotFound();
}

return View(student);
}
}
}
