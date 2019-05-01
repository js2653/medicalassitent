
namespace medicalassitent.web.Controllers
{
    using System.Threading.Tasks;
    using Data;
    using Data.Entities;
    using Helpers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class DocumentTypesController : Controller
    {
        private readonly IRepository repository;
        private readonly IUserHelper userHelper;

        public DocumentTypesController(IRepository repository, IUserHelper userHelper)
        {
            this.repository = repository;
            this.userHelper = userHelper;
        }

        // GET: DocumentTypes
        public IActionResult Index()
        {
            return View(this.repository.GetDocumentTypes());
        }

        // GET: DocumentTypes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentType = this.repository.GetDocumentType(id.Value);
            if (documentType == null)
            {
                return NotFound();
            }

            return View(documentType);
        }

        // GET: DocumentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DocumentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name")] DocumentType documentType)
        {
            if (ModelState.IsValid)
            {
                //TODO: Cambiar este por el usuario legeado
                documentType.User = await this.userHelper.GetUserByEmalAsync("jpoolvalverde@gmail.com");
                repository.AddDocumentType(documentType);
                await repository.SaveAllAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(documentType);
        }

        // GET: DocumentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentType = repository.GetDocumentType(id.Value);
            if (documentType == null)
            {
                return NotFound();
            }
            return View(documentType);
        }

        // POST: DocumentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoDeDocumento")] DocumentType documentType)
        {
            if (id != documentType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //TODO: Cambiar este por el usuario legeado
                    documentType.User = await this.userHelper.GetUserByEmalAsync("jpoolvalverde@gmail.com");
                    repository.UpdateDocumentType(documentType);
                    await repository.SaveAllAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!repository.DocumentTypeExists(documentType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(documentType);
        }

        // GET: DocumentTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentType = repository.GetDocumentType(id.Value);
            if (documentType == null)
            {
                return NotFound();
            }

            return View(documentType);
        }
    }
}
