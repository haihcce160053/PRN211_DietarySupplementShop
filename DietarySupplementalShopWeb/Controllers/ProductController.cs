using DataAccess.DataAccess;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Principal;

namespace DietarySupplementalShopWeb.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository = null;
        IProductInformationRepository productInformationRepository = null;
        public ProductController()
        {
            productRepository = new ProductRepository();
            productInformationRepository = new ProductInformationRepository();
        }

        // GET: ProductController
        public ActionResult Index()
        {
            var productList = productRepository.GetProductList();
            return View(productList);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductViewModel productView = new ProductViewModel();
            productView.Product = productRepository.GetProductByID(id);
            productView.ProductInformation = productInformationRepository.GetProductInfoByID(id);
            if (productView == null)
            {
                return NotFound();
            }
            return View(productView);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel ProductViewModel)
        {
            if (ProductViewModel == null)
            {
                return NotFound();
            }
            productRepository.AddProduct(ProductViewModel.Product);
            productInformationRepository.AddProductInfo(ProductViewModel.ProductInformation);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductViewModel productView = new ProductViewModel();
            productView.Product = productRepository.GetProductByID(id);
            productView.ProductInformation = productInformationRepository.GetProductInfoByID(id);
            if (productView == null)
            {
                return NotFound();
            }
            return View(productView);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productView)
        {
            try
            {
                if (productView == null)
                {
                    return NotFound();
                }
                productRepository.UpdateProduct(productView.Product);
                productInformationRepository.UpdateProductInfo(productView.ProductInformation);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.ProductId = id;
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProductViewModel productView)
        {
            try
            {
                if (productView == null)
                {
                    return NotFound();
                }
                productInformationRepository.DeleteProductInfo(productView.Product.ProductId);
                productRepository.DeleteProduct(productView.ProductInformation.ProductId);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
