namespace medicalassitent.web.Controllers.API
{
    using medicalassitent.web.Data;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[Controller]")]
    public class DocumentTypesController : Controller
    {
        private readonly IDocumentTypeRepository documentTypeRepository;

        public DocumentTypesController(IDocumentTypeRepository documentTypeRepository)
        {
            this.documentTypeRepository = documentTypeRepository;
        }
        [HttpGet]
        public IActionResult GetDocumentTypes()
        {
            return Ok(this.documentTypeRepository.GetAll());
        }
    }
}
