using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataSource;
using Microsoft.Extensions.Logging;

namespace WebApi
{
    
    [Route("api/urun")]
    public class UrunController : Controller
    {
        public IActionResult GetUrunler()
        {
            return Ok(ApiDataSource.Current.urunler);
        }
        [HttpGet("{Id}")]
        public IActionResult GetUrunler(int Id)
        {
            var data = ApiDataSource.Current.urunler.FirstOrDefault(c => c.Id == Id);

            if (data == null)
                return NotFound();
            return Ok(data);
        }
        [HttpGet("brand/{Name}")]
        public IActionResult GetBrands(string name)
        {



            var data = ApiDataSource.Current.urunler.SelectMany(b => b.urunCesiti.Select(i => new { i.Id, i.Name, i.Brand })).Where(a =>
              a.Brand.ToLower().Contains(name.ToLower())).FirstOrDefault();


            if (data == null)
                return NotFound();
            return Ok(data);
        }

    }
}
