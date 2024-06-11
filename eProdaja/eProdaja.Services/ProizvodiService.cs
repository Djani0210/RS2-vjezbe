using eProdaja.Model;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        eProdajaContext _context;
        public ProizvodiService(eProdajaContext context) {
            _context = context;
        }

        List<Model.Proizvodi> proizvodi = new List<Model.Proizvodi>()
        {
            new Model.Proizvodi()
            {
                ProizvodId=1,
                Naziv="Laptopiss"
            }
        };
        public IList<Model.Proizvodi> Get()
        {
            var list = _context.Proizvodis.ToList();
            return proizvodi;
        }
    }
}
