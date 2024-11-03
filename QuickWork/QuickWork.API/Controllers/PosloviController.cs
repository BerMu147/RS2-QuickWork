using Microsoft.AspNetCore.Mvc;
using QuickWork.Model;
using QuickWork.Services;

namespace QuickWork.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PosloviController : ControllerBase
    {
        protected IPosloviService _posloviService;
        public PosloviController(IPosloviService service) {
            _posloviService = service;
        }

        [HttpGet]
        public List<Poslovi> GetList()
        {
            return _posloviService.GetList();
        }
    }
}
