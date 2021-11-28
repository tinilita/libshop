using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace libshopsoul.Controllers
{
    [Route("api/shop")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly ILogger<ShopController> _logger;
        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
            /*
             * 1. добавить разделение приложения по слоям (ApplicationServices, Infrastructure, Core)
             * 2. добавить абстракции и модели для прохождения флоу "добавление магазина"
             * 3. установить SQLite ***
             * 4. прочитать про EF, миграции ***
             * 
             */
        }

        [HttpGet("")]
        public List<Shop> GetAllShops()
        {
            return new()
            {
                new Shop()
                {
                    Name = "Читай город",
                    Address = "Улица Пушкина"
                },
                new Shop()
                {
                    Address = "Улица Колотушкина",
                    Name = "Киви"
                }

            };
        }

        [HttpPost("add")]
        public void AddShop()
        {
            
        }

        [HttpGet("/list-books/{shopId}")]
        public void ListShopBooks(Guid shopId)
        {
            
        }
        
    }
}
