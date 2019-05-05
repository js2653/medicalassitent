
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
        private readonly IDocumentTypeRepository documentTypeRepository;

        private readonly IUserHelper userHelper;

        public DocumentTypesController(IDocumentTypeRepository documentTypeRepository, IUserHelper userHelper)
        {
            this.documentTypeRepository = documentTypeRepository;
            this.userHelper = userHelper;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(this.documentTypeRepository.GetAll());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.documentTypeRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DocumentType documentType)
        {
            if (ModelState.IsValid)
            {
                // TODO: Pending to change to: this.User.Identity.Name
                documentType.User = await this.userHelper.GetUserByEmalAsync("jzuluaga55@gmail.com");
                await this.documentTypeRepository.CreateAsync(documentType);
                return RedirectToAction(nameof(Index));
            }

            return View(documentType);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.documentTypeRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DocumentType documentType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Pending to change to: this.User.Identity.Name
                    documentType.User = await this.userHelper.GetUserByEmalAsync("jzuluaga55@gmail.com");
                    await this.documentTypeRepository.UpdateAsync(documentType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.documentTypeRepository.ExistAsync(documentType.Id))
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

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.documentTypeRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await this.documentTypeRepository.GetByIdAsync(id);
            await this.documentTypeRepository.DeleteAsync(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
