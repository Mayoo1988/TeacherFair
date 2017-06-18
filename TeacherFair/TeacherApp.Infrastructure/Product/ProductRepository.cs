using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherApp.core;

namespace TeacherApp.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        ProductContext context = new ProductContext();
        public void AddProduct()
        {
            ProductContext context = new ProductContext();


            context.AddNewEmployee(new Product
            {
                id = 3,
                Name = "NAchiket",
                Instock = true,
                Price = 30,
                
            });
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void UpdateData()
        {
            throw new NotImplementedException();
        }

        public void Updateproducts()
        {
            throw new NotImplementedException();
        }
    }
}
