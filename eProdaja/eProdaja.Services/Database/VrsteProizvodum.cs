using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Database
{
    public partial class VrsteProizvodum
    {
        public VrsteProizvodum()
        {
            Proizvodis = new HashSet<Proizvodi>();
        }

        public int VrstaId { get; set; }
        public string Naziv { get; set; } = null!;

        public virtual ICollection<Proizvodi> Proizvodis { get; set; }
    }
}
