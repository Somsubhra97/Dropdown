using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dropdown.Models;
using Dropdown.EmployeeViewModel;

namespace Dropdown.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public EmployeeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }  

        public JsonResult GetCityList(int StateId){
            var list= new SelectList(_context.City.Where(c => c.StateId == StateId),"Id","CityName");
            return Json(list);         
        
       }

       [HttpPost]        
        public async Task<IActionResult> Post([Bind("FullName, Email, Position, Address, StateName, CityName")] Employee transactionModel)
        {
            try{
                if (ModelState.IsValid)
                {               
                    _context.Employee.Add(transactionModel);  
                    await _context.SaveChangesAsync();    
                }
            }
            catch(Exception)
            {
                throw;                
            }
            
            
        }

       public Task<IActionResult> GetAll(){


        return View(await ( from a in _context.Employee
                            from b in _context.State
                            from c in _context.City
                            where a.Id==b.EmployeeId And a.Id==c.EmployeeId
                            select new EmpView
                              {
                                  Name = a.FullName,
                                  Address = a.Address,
                                  Designation = a.Position,
                                  Email =A.Email,
                                  CityName=c.CityName,
                                  StateName=c.Name
                              }).ToListAsync()
                   );
                      
            }
       }
        
   }

