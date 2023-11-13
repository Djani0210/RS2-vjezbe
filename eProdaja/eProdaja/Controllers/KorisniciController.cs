using eProdaja.Model;
using eProdaja.Services;
using eProdaja.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _korisniciService;

        

        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService= korisniciService;
        }

        [HttpGet]
        public IEnumerable<Model.Korisnici> Get()
        {
            return _korisniciService.Get();
        }
        [HttpPost]
        public Model.Korisnici Insert(Model.Requests.KorisniciInsertRequest request)
        {
            return _korisniciService.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, Model.Requests.KorisniciUpdateRequest request)
        {
            return _korisniciService.Update(id,request);
        }
    }
}