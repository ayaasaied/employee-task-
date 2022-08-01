using Admin.Core.Models;
using Admin.Core.ViewModel;
using Admin.Infrastructure.Shared.UnitOfWorks;
using Admin.Services.Service;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Presentation.Controllers
{
   
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly ILkpServices iLkpServices;
        private readonly IEmployeeServices employeeServices;

        public EmployeeController(IUnitOfWorks unitOfWorks, ILkpServices iLkpServices , IEmployeeServices employeeServices)
        {
            this.iLkpServices = iLkpServices;
            this.unitOfWorks = unitOfWorks;
            this.employeeServices = employeeServices;

        }



        [HttpGet]
        public  List<lineofbussienessAccount> GetLineOfBussinesId(int Lineofid)
        {
            List<lineofbussienessAccount> lineofbussienessAccounts=new List<lineofbussienessAccount>();
             var Linebyaccount = iLkpServices.LineOfBussinessId(Lineofid);
           for (int i = 0; i < Linebyaccount.Count; i++)
            { 
                lineofbussienessAccounts.Add(new lineofbussienessAccount()
                {
                    id = Linebyaccount[i].Id,
                    name = Linebyaccount[i].Name,
                }
                );
            }
            
            return lineofbussienessAccounts;
        }

        [HttpGet]
        public List<LangugaelevelVM> LangugelevelId(int Languofid)
        {
            List<LangugaelevelVM> langugaelevels = new List<LangugaelevelVM>();
            var langugebylevel = iLkpServices.LanguagelevelId(Languofid);
            for (int i = 0; i < langugebylevel.Count; i++)
            {
                langugaelevels.Add(new LangugaelevelVM()
                {
                    id = langugebylevel[i].Id,
                    name = langugebylevel[i].Name,
                }
                );
            }

            return langugaelevels;
        }

        public async Task<ActionResult> DashBoard(int id)
            
        {
            List<Account> Account = await iLkpServices.GetAllLAcount();
            ViewData["Account"] = Account;
            var EmpByAccountId= iLkpServices.EmployeebyAccountId(id);
            ViewData["EmpByAccountId"] = EmpByAccountId;
            var EmpByAccountcount = iLkpServices.EmployeebyAccountId(id).Count();

            return View(EmpByAccountcount);
        }


        public async Task<ActionResult<EmployeeVM>> AllEmployee()
            {
         
            List<Languagelevel> languagelevels = await iLkpServices.GetAllLangugeLevel();
            ViewData["languagelevels"] = languagelevels;


            List<EmployeeVM> employees = await unitOfWorks.Employee.GetAll();
           
                return View(employees);
            }




        //add -register
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<Account> Account = await iLkpServices.GetAllLAcount();
            ViewData["Account"] = Account;
            List<Language> languages = await iLkpServices.GetAllLanguge();
            ViewData["languages"] = languages;
            List<Languagelevel> languagelevels = await iLkpServices.GetAllLangugeLevel();
            ViewData["languagelevels"] = languagelevels;

            ViewBag.LineOfBusiness = new SelectList(await iLkpServices.GetAllLineOfBussiness(), "Id", "Name");

            List<LineofBusiness> lineofBusinesses = await iLkpServices.GetAllLineOfBussiness();
            ViewData["lineofBusinesses"] = lineofBusinesses;

           return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeVM employee)
        {

            if (ModelState.IsValid == true)
            {
                if (employee.LineofBusinessId > 0 && employee.langaugeslevelids.Count > 0 && employee.AccountId > 0 && employee.langugeId > 0)
                {
                    await unitOfWorks.Employee.AddAsync(employee);
                 
                }
                unitOfWorks.Complete();

                return RedirectToAction("AllEmployee");
            }
            List<Account> Account = await iLkpServices.GetAllLAcount();
            ViewData["Account"] = Account;
            List<LineofBusiness> lineofBusinesses = await iLkpServices.GetAllLineOfBussiness();
            ViewData["lineofBusinesses"] = lineofBusinesses;
            List<Language> languages = await iLkpServices.GetAllLanguge();
            ViewData["languages"] = languages;
            List<Languagelevel> languagelevels = await iLkpServices.GetAllLangugeLevel();
            ViewData["languagelevels"] = languagelevels;

            return View("Create", employee);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            
            
                EmployeeVM empModel = unitOfWorks.Employee.GetByIdVM(id);
                List<Account> Account = await iLkpServices.GetAllLAcount();
                ViewData["Account"] = Account;
                List<LineofBusiness> lineofBusinesses = await iLkpServices.GetAllLineOfBussiness();
                ViewData["lineofBusinesses"] = lineofBusinesses;
                List<Language> languages = await iLkpServices.GetAllLanguge();
                ViewData["languages"] = languages;
                List<Languagelevel> languagelevels = await iLkpServices.GetAllLangugeLevel();
                ViewData["languagelevels"] = languagelevels;

                return View(empModel);
           

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, EmployeeVM employee)
        {
            if (id != 0)
            {
                if (ModelState.IsValid)
                {
                    if (employee.LineofBusinessId > 0 && employee.langaugeslevelids.Count > 0 && employee.AccountId > 0 && employee.langugeId > 0)
                    {
                       // unitOfWorks.Employee.Update(id, employee);
                       employeeServices.Update(id, employee);   


                    }
                    unitOfWorks.Complete();
                    return RedirectToAction("AllEmployee");
                }
            }
            List<Account> Account = await iLkpServices.GetAllLAcount();
            ViewData["Account"] = Account;
            List<Language> languages = await iLkpServices.GetAllLanguge();
            ViewData["languages"] = languages;
            List<Languagelevel> languagelevels = await iLkpServices.GetAllLangugeLevel();
            ViewData["languagelevels"] = languagelevels;
            List<LineofBusiness> lineofBusinesses = await iLkpServices.GetAllLineOfBussiness();
            ViewData["lineofBusinesses"] = lineofBusinesses;
            return View("Edit", employee);

        }

        //delete
        public async Task<IActionResult> Delete(int id)
        {
            if (id != 0)
            {
                await unitOfWorks.Employee.Remove(id);

                unitOfWorks.Complete();
                return RedirectToAction("AllEmployee");
            }
            return RedirectToAction("Allempolyee");


         }

            //Ecel sheet
            public async Task<IActionResult> Excelsheet()
        {
            using (var workbook = new XLWorkbook())
            {
                List<EmployeeVM> GetAllEmployee = await unitOfWorks.Employee.GetAll();
             
                var worksheet = workbook.Worksheets.Add("employee");
                var currentRow = 1;
                worksheet.Cell(currentRow, 2).Value = "Name";
                worksheet.Cell(currentRow, 3).Value = "National Id";
                worksheet.Cell(currentRow, 4).Value = "Date Of Birth";
                worksheet.Cell(currentRow, 5).Value = "Account";
                worksheet.Cell(currentRow, 6).Value = "languge";
                worksheet.Cell(currentRow, 7).Value = "line of business";
                worksheet.Cell(currentRow, 8).Value = "langugae level";


                foreach (var emp in GetAllEmployee)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = emp.Name;
                    worksheet.Cell(currentRow, 2).Value = emp.NationalId.ToString();
                    worksheet.Cell(currentRow, 3).Value = emp.DateOfBirth;
                    worksheet.Cell(currentRow, 4).Value = emp.Account.Name;
                    worksheet.Cell(currentRow, 5).Value = emp.Language.Name;
                    
                    worksheet.Cell(currentRow, 6).Value = emp.LineofBusiness.Name;
                    //worksheet.Cell(currentRow ,7).Value = emp.Languagelevel.Name;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Employee.xlsx");
                }
            }

        }


        //private async Task<int>  getViewBag()
        //{
        //    try
        //    {
        //        List<Account> Account = await iLkpServices.GetAllLAcount();
        //        ViewData["Account"] = Account;
        //        List<Language> languages = await iLkpServices.GetAllLanguge();
        //        ViewData["languages"] = languages;
        //        List<Languagelevel> languagelevels = await iLkpServices.GetAllLangugeLevel();
        //        ViewData["languagelevels"] = languagelevels;
        //        List<LineofBusiness> lineofBusinesses = await iLkpServices.GetAllLineOfBussiness();
        //        ViewData["lineofBusinesses"] = lineofBusinesses;
        //        return 1;
        //    }
        //    catch { return 0; }
        //}

















    }


}

