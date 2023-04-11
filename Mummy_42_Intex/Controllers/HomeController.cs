using Microsoft.AspNetCore.Mvc;
using Mummy_42_Intex.Data;
using Mummy_42_Intex.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummy_42_Intex.Controllers
{
    public class HomeController : Controller
    {

        private IMummyRepository repo;

        public HomeController(IMummyRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 5;

            //we have two models we are using so if we need to pass data to both, do it here
            var passInfo = new MummyViewModel
            {
                Artifacts = repo.Artifacts
                .OrderBy(a => a.Description)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBurials = repo.Artifacts.Count(),
                    BurialsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(passInfo);
        }
    }
}
