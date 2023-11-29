using Atelier1.Models.Repositories;
using Atelier1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atelier1.Controllers
{


    public class EmployeeController : Controller
    {
        readonly IRepository<Employee> employeRepository;

        // Injection de dépendance
        public EmployeeController(IRepository<Employee> empRepository)
        {
            employeRepository = empRepository;
        }
        // GET: EmployeeController
     
        public ActionResult Index()
        {
            var employees = employeRepository.GetAll();
            ViewData["EmployeesCount"] = employees.Count();
            ViewData["SalaryAverage"] = employeRepository.SalaryAverage();
            ViewData["MaxSalary"] = employeRepository.MaxSalary();
            ViewData["HREmployeesCount"] = employeRepository.HrEmployeesCount();
            return View(employees);
        }
        public ActionResult Search(string term)
        {
            var result = employeRepository.Search(term);
            return View("Index", result);
        }



        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var employees = employeRepository.GetAll();
            return View(employees);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee e)
        {
            try
            {
                // Ajouter un nouvel employé
                employeRepository.Add(e);
                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = employeRepository.FindByID(id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee newemployee)
        {
            try
            {
                // Mettre à jour un employé
                employeRepository.Update(id, newemployee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = employeRepository.FindByID(id);
            return View(employee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // Supprimer un employé
                employeRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
