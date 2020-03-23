using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaraCadir.Northwind.Business.Abstract;
using KaraCadir.Northwind.MvcWebUI.Models;
using KaraCadir.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KaraCadir.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, productToBeAdded);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", string.Format($"{productToBeAdded.ProductName} sepetinize eklendi"));

            return RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel cartSummaryViewModel = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(cartSummaryViewModel);
        }
    }
}