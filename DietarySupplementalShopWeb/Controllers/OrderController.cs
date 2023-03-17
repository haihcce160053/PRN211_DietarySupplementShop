using DataAccess.DataAccess;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DietarySupplementalShopWeb.Controllers
{
    public class OrderController : Controller
    {
        IOrderListRepository orderListRepository = null;
        IOrderDetailRepository orderDetailRepository = null;
        public OrderController()
        {
            orderListRepository = new OrderListRepository();
            orderDetailRepository = new OrderDetailRepository();
        }

        // GET: OrderController
        public ActionResult Index()
        {
            var order = orderListRepository.GetOrderList();
            return View(order);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.OrderList = orderListRepository.GetOrderListByID(id);
            orderViewModel.OrderDetail = orderDetailRepository.GetOrderDetailByID(id);

            for (int i = 0; i < orderViewModel.OrderDetail.Count(); i++)
            {
                Console.WriteLine(orderViewModel.OrderDetail);
            }

            if (orderViewModel == null)
            {
                return NotFound();
            }
            return View(orderViewModel);
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OrderViewModel orderView = new OrderViewModel();
            orderView.OrderList = orderListRepository.GetOrderListByID(id);
            orderView.OrderDetail = orderDetailRepository.GetOrderDetailByID(id);
            if (orderView == null)
            {
                return NotFound();
            }
            return View(orderView);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrderViewModel orderView)
        {
            try
            {
                if (orderView == null)
                {
                    return NotFound();
                }
                orderListRepository.UpdateOrderList(orderView.OrderList);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
