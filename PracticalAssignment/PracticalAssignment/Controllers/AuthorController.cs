using Microsoft.AspNetCore.Mvc;
using PracticalAssignment.Business.Model.Authors;
using PracticalAssignment.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignment.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var authors = await authorService.GetAllAsync();
            return View(authors);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AuthorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await authorService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var author = await authorService.GetByIdAsync(id);
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AuthorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await authorService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
        
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var author = authorService.GetByIdAsync(id);
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(AuthorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await authorService.Delete(model.Id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View(model);
            }
        }
    }
}
