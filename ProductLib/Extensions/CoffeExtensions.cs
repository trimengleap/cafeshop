using CoffeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeLib.Extensions
{
    public static class CoffeExtensions
    {
        public static CoffeResponse ToResponse(this Coffee prd)
        {
            return new CoffeResponse()
            {
                Id = prd.Id,
                Code = prd.Code,
                Name = prd.Name,
                Category = Enum.GetName<Category>(prd.Category),
                Price=prd.Price                
            };
        }
        public static Coffee ToEntity(this CoffeCreateReq req)
        {
            var category = Category.None;
            Category.TryParse(req.Category, out category);
            return new Coffee()
            {
                Id = Guid.NewGuid().ToString(),
                Code = req.Code,
                Name = req.Name,
                Category = category,
                Price = req.Price,
                CreatedOn = DateTime.Now,
            };
        }
        public static void Copy(this Coffee prd, CoffeUpdateReq req)
        {
            var category = Category.None;
            Category.TryParse(req.Category,out category);
            prd.Name = req.Name;
            prd.Category = category;
        }
        public static Coffee Clone(this Coffee prd)
        {
            return new Coffee()
            {
                Id = prd.Id,
                Code = prd.Code,
                Name = prd.Name,
                Category = prd.Category,
                Price = prd.Price,
                CreatedOn = prd.CreatedOn,
            };
        }
        public static void Copy(this Coffee prd, Coffee other)
        {
            prd.Id = other.Id;
            prd.Code = other.Code;
            prd.Name = other.Name;
            prd.Category = other.Category;
            prd.Price = other.Price;
            prd.CreatedOn = other.CreatedOn;
        }
    }
}
