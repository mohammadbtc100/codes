using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OWIN
{
    public class ProductsController : ApiController
    {
        private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Product A", Price = 10.00m },
        new Product { Id = 2, Name = "Product B", Price = 20.00m },
        new Product { Id = 3, Name = "Product C", Price = 30.00m }
    };

        // GET api/products
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/products/5
        public IHttpActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/products
        public IHttpActionResult Post([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Invalid product data.");
            }

            product.Id = products.Max(p => p.Id) + 1; // Generate new ID
            products.Add(product);
            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        // PUT api/products/5
        public IHttpActionResult Put(int id, [FromBody] Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/products/5
        public IHttpActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);
            return Ok(product);
        }
    }

}
