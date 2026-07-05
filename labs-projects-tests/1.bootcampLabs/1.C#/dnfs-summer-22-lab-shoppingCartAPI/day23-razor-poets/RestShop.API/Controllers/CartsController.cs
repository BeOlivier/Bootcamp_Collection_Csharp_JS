using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RestShop.API.Data;
using RestShop.API.Model;


namespace RestShop.Api.Controllers
{
    [ApiController]
    [Route("api/Carts/")]
    public class CartsController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;

        public CartsController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        [HttpPost]
        public ActionResult<Cart> CreateCart()
        {
            // var result = _cartRepository.GetAll();
            var cart = _cartRepository.Create();
            return CreatedAtAction("GetCart", new { id = cart.Id }, cart);
            // return  Created($"http://localhost/api/Carts/{cart.Id}", cart);
            // return Created(url, cart);
        }

        [HttpGet]
        public ActionResult<Cart> GetCart(string id)
        {
            var cart = _cartRepository.GetOne(id);
            if (cart == null) return NotFound();
            return Ok(cart);
        }


        // [HttpPatch("{id}")]
        [HttpPatch]
        public ActionResult<Cart> AddProductToCart(string id, AddProductCartProductRequest request)
        {
            var cart = _cartRepository.Update(id, request);
            return Ok(cart);
        }

        [HttpDelete]
        public ActionResult<Cart> DeleteCart(string id)
        {
            _cartRepository.Delete(id);
            return Accepted();
        }

        // public ActionResult<Cart> PatchACart(string id, AddProductCartProductRequest toBeAdded)
        // {
        //     var cart = _cartRepository.Update(id, toBeAdded);
        //     return Ok(cart);
        //
        // }
        
        
        //method post async
        //  -return a status OK()
        //      -return other stuff
        //var heroListResponse = await _swApiClient.getHerosFromSwapi();
    }
}