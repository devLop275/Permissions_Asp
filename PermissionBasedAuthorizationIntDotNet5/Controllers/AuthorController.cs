using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermissionBasedAuthorizationIntDotNet5.Models;
using PermissionBasedAuthorizationIntDotNet5.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PermissionBasedAuthorizationIntDotNet5.Contants;

namespace PermissionBasedAuthorizationIntDotNet5.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IPermissionsAuthorRepository<Author> authorRepository;

        public AuthorController(IPermissionsAuthorRepository<Author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        // GET: AuthorController1
        public ActionResult Index()
        {
            var authors = authorRepository.List();
            return View(authors);
        }

        // GET: AuthorController1/Details/5
        public ActionResult Details(int id)
        {
            var author = authorRepository.Find(id);
            return View(author);
        }

        // GET: AuthorController1/Create
        [Authorize(Permissions.Author.Create)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Permissions.Author.Create)]
        public ActionResult Create(Author author)
        {
            try
            {
                authorRepository.Add(author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController1/Edit/5
        [Authorize(Permissions.Author.Edit)]
        public ActionResult Edit(int id)
        {
            var author = authorRepository.Find(id);
            return View(author);
        }

        // POST: AuthorController1/Edit/5
        [Authorize(Permissions.Author.Edit)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Author  author)
        {
            try
            {
                authorRepository.Update(id, author);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController1/Delete/5
        [Authorize(Permissions.Author.Delete)]
        public ActionResult Delete(int id)
        {
            var author = authorRepository.Find(id);
            return View(author);
        }

        // POST: AuthorController1/Delete/5
        [Authorize(Permissions.Author.Delete)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Author  author)
        {
            try
            {
                authorRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
