using Microsoft.AspNetCore.Mvc;
using PracticalAssignment.Business.Model.Books;
using PracticalAssignment.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignment.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var authors = await bookService.GetAllAsync();
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
        public async Task<IActionResult> Create(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await bookService.Create(model);
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
            var author = await bookService.GetByIdAsync(id);
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await bookService.Update(model);
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
            var author = bookService.GetByIdAsync(id);
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await bookService.Delete(model.Id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View(model);
            }
        }
    }
}
