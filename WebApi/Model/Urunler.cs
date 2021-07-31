using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Urunler
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int YeniUrunCesiti  { get { return urunCesiti.Count; } }

        public ICollection<UrunCesiti> urunCesiti { get; set; } = new List<UrunCesiti>();



    }
}
