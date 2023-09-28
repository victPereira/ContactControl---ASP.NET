using ContactControl.Models;
using ContactControl.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ContactControl.Controllers
{
    public class ContactController : Controller
    {

        private readonly IRepositoryContact _repositoryContact;

        public ContactController(IRepositoryContact repositoryContact)
        {
            _repositoryContact = repositoryContact;
        }

        //METODS GET - RECEBE AS INFO
        public IActionResult Index()
        {
           List<ContactModel> contacts = _repositoryContact.GetAll();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id) 
        {
           ContactModel contact = _repositoryContact.ListID(id);
            return View(contact);
        }

        public IActionResult DeleteConfirmation()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        // METODOS POST - ENVIANDO INFO

        [HttpPost]
        public IActionResult Create (ContactModel contact)
        {
            _repositoryContact.Add(contact);
            return RedirectToAction("Index");
        }


        // METODOS POST - EDITANDO INFO
        [HttpPost]
        public IActionResult Update(ContactModel contact)
        {
            _repositoryContact.Add(contact);
            return RedirectToAction("Index");
        }


    }
}
