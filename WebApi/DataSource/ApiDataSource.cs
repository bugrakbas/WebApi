using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.DataSource
{
    public class ApiDataSource
    {

        public static ApiDataSource Current { get; } = new ApiDataSource();

        public List<Urunler> urunler { get; set; }

        public ApiDataSource()
        {
            urunler = new List<Urunler>()
            {
                new Urunler()
                {
                    Id=1,
                    Name="Telefon",
                    urunCesiti = new List<UrunCesiti>()
                    {
                        new UrunCesiti()
                        {
                            Id=1,
                            Name="Cep telefonu",
                            Brand="İphone"
                        },
                        new UrunCesiti()
                        {
                            Id=2,
                            Name="Cep Telefonu",
                            Brand="Samsung"
                        },
                        new UrunCesiti()
                        {
                            Id=3,
                            Name="Cep Telefonu",
                            Brand = "Lg"
                        }
                    }
                },
                new Urunler()
                {
                    Id=2,
                    Name="Bilgisayar",
                    urunCesiti = new List<UrunCesiti>()
                    {
                        new UrunCesiti()
                        {
                            Id=1,
                            Name="Dizüstü Bilgisayar",
                            Brand="Lenovo"
                        },
                        new UrunCesiti()
                        {
                            Id=2,
                            Name="Masaüstü Bilgisayar",
                            Brand="Asus"
                        },
                        new UrunCesiti()
                        {
                            Id=3,
                            Name="Dizüstü Bilgisayar",
                            Brand="Apple"
                        }
                    }
                    
                },
            };
        }
        
    
    
    }
}
